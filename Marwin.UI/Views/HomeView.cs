using Marwin.UI.Models;
using Marwin.UI.Presenters;
using Marwin.UI.Presenters.Company;
using Marwin.UI.Views;
using Marwin.UI.Views.Company;
using Marwin.UI.Views.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Marwin.UI
{
    public partial class HomeView : Form
    {
        private readonly HomePresenter _homePresenter;

        public HomeView()
        {
            InitializeComponent();
            _homePresenter = new HomePresenter(this);
        }

        private async void HomeView_Load(object sender, EventArgs e)
        {
            await RefreshCompanyList();
        }

        private async void CompaniesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (CompaniesGridView.CurrentRow?.Index == e.RowIndex)
                return;

            var row = CompaniesGridView.Rows[e.RowIndex];

            Guid companyGuid = Guid.Parse(row.Cells[0].Value.ToString());
            await RefreshEmployeeList(companyGuid);
        }

        /// <summary>
        /// Обновить таблицу сотрудников в соответствии с выбранной компанией
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task RefreshEmployeeList(Guid companyId)
        {
            EmployeesGridView.Rows.Clear();

            List<EmployeeModel> employeeModels = await _homePresenter.GetEmployeesByCompanyId(companyId);
            foreach (EmployeeModel employee in employeeModels)
            {
                EmployeesGridView.Rows.Add(new string[] {
                    employee.EmployeeId.ToString(),
                    employee.LastName,
                    employee.FirstName,
                    employee.ThirdName,
                    employee.TIN
                });
            }
        }

        /// <summary>
        /// Обновить список компаний
        /// </summary>
        /// <returns></returns>
        public async Task RefreshCompanyList()
        {
            CompaniesGridView.Rows.Clear();

            List<CompanyModel> companyModels = await _homePresenter.GetCompanies();
            foreach (CompanyModel company in companyModels)
            {
                CompaniesGridView.Rows.Add(new string[] {
                    company.CompanyId.ToString(),
                    company.CompanyName,
                    company.BIN,
                    company.Address,
                    company.Note
                });
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new CompanyAddView(this).ShowDialog();
        }

        private void DeleteCompany_Click(object sender, EventArgs e)
        {
            var selectedRow = CompaniesGridView.CurrentRow;

            //Собрать модель из выбранной строки на таблице
            CompanyModel companyModel = new CompanyModel { 
                CompanyId = Guid.Parse(selectedRow.Cells[0].Value.ToString()),
                CompanyName = selectedRow.Cells[1].Value.ToString()
            };

            new CompanyDeleteView(this, companyModel).ShowDialog();
        }

        private void UpdateCompany_Click(object sender, EventArgs e)
        {
            var selectedRow = CompaniesGridView.CurrentRow;

            //Собрать модель из выбранной строки на таблице
            CompanyModel companyModel = new CompanyModel
            {
                CompanyId = Guid.Parse(selectedRow.Cells[0].Value.ToString()),
                CompanyName = selectedRow.Cells[1].Value.ToString(),
                BIN = selectedRow.Cells[2].Value.ToString(),
                Address = selectedRow.Cells[3].Value.ToString(),
                Note = selectedRow.Cells[4].Value.ToString()
            };

            new CompanyUpdateView(this, companyModel).ShowDialog();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeModel employeeModel = new EmployeeModel
            {
                CompanyId = Guid.Parse(CompaniesGridView.CurrentRow.Cells[0].Value.ToString())
            };

            new EmployeeAddView(this, employeeModel).ShowDialog();
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedEmployeeRow = EmployeesGridView.CurrentRow;
            var selectedCompanyRow = CompaniesGridView.CurrentRow;

            //Собрать модель из выбранной строки на таблице
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmployeeId = Guid.Parse(selectedEmployeeRow.Cells[0].Value.ToString()),
                LastName = selectedEmployeeRow.Cells[1].Value.ToString(),
                FirstName = selectedEmployeeRow.Cells[2].Value.ToString(),
                ThirdName = selectedEmployeeRow.Cells[3].Value.ToString(),
                TIN = selectedEmployeeRow.Cells[4].Value.ToString(),
                CompanyId = Guid.Parse(selectedCompanyRow.Cells[0].Value.ToString())
            };

            new EmployeeUpdateView(this, employeeModel).ShowDialog();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedEmployeeRow = EmployeesGridView.CurrentRow;
            var selectedCompanyRow = CompaniesGridView.CurrentRow;

            //Собрать модель из выбранной строки на таблице
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmployeeId = Guid.Parse(selectedEmployeeRow.Cells[0].Value.ToString()),
                LastName = selectedEmployeeRow.Cells[1].Value.ToString(),
                FirstName = selectedEmployeeRow.Cells[2].Value.ToString(),
                CompanyId = Guid.Parse(selectedCompanyRow.Cells[0].Value.ToString())
            };

            new EmployeeDeleteView(this, employeeModel).ShowDialog();
        }

        private async void ExportCSVButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "CSV File|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string path = saveFileDialog1.FileName;

            Guid companyId = Guid.Parse(CompaniesGridView.CurrentRow.Cells[0].Value.ToString());
            MemoryStream memoryStream = await _homePresenter.ExportEmployeesCSV(companyId);
            using (StreamReader reader = new StreamReader(memoryStream))
            {
                string s = reader.ReadToEnd();

                // сохраняем текст в файл
                File.WriteAllBytes(path, Encoding.Default.GetBytes(s.ToArray()));
            }
        }

        private async void ImportCSVButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "CSV File|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            Guid companyId = Guid.Parse(CompaniesGridView.CurrentRow.Cells[0].Value.ToString());
            // читаем файл в строку
            using (FileStream fileStream = File.OpenRead(openFileDialog1.FileName))
            { 
                await _homePresenter.ImportEmployeesCSV(fileStream, companyId);
            }

            await RefreshEmployeeList(companyId);
        }
    }
}
