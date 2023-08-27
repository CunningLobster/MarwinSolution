using Marwin.UI.Models;
using Marwin.UI.Presenters;
using Marwin.UI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private async Task RefreshEmployeeList(Guid companyId)
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
    }
}
