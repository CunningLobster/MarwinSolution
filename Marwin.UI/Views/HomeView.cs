using Marwin.UI.Models;
using Marwin.UI.Presenters;
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

        private async void CompaniesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
