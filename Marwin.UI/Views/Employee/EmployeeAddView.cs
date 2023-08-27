using Marwin.UI.Models;
using Marwin.UI.Presenters.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marwin.UI.Views.Employee
{
    public partial class EmployeeAddView : Form
    {
        private readonly EmployeeAddPresenter _employeeAddPresenter;
        private readonly EmployeeModel _employeeModel;
        private readonly HomeView _homeView;

        public EmployeeAddView(HomeView homeView, EmployeeModel employeeModel)
        {
            InitializeComponent();
            _employeeAddPresenter = new EmployeeAddPresenter(this);
            _homeView = homeView;
            _employeeModel = employeeModel;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            //Собрать модель из полей на форме
            EmployeeModel employeeModel = new EmployeeModel
            {
                CompanyId = _employeeModel.CompanyId,
                FirstName = FirstNameText.Text,
                LastName = LastNameText.Text,
                ThirdName = ThirdNameText.Text,
                TIN = TINText.Text
            };

            await _employeeAddPresenter.AddEmployee(employeeModel);
            await _homeView.RefreshCompanyList();

            Close();
        }
    }
}
