using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
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
    public partial class EmployeeUpdateView : Form
    {
        private readonly EmployeeModel _employeeModel;
        private readonly EmployeeUpdatePresenter _employeeUpdatePresenter;
        private readonly HomeView _homeView;

        public EmployeeUpdateView(HomeView homeView, EmployeeModel employeeModel)
        {
            InitializeComponent();
            _homeView = homeView;
            _employeeUpdatePresenter = new EmployeeUpdatePresenter(this);
            _employeeModel = employeeModel;
        }

        private void EmployeeUpdateView_Load(object sender, EventArgs e)
        {
            HeaderLabel.Text = $"Обновить сотрудника {_employeeModel.FirstName} {_employeeModel.LastName}";

            //Заполнить поля на форме
            FirstNameText.Text = _employeeModel.FirstName;
            LastNameText.Text = _employeeModel.LastName;
            ThirdNameText.Text = _employeeModel.ThirdName;
            TINText.Text = _employeeModel.TIN;
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
                EmployeeId = _employeeModel.EmployeeId,
                FirstName = FirstNameText.Text,
                LastName = LastNameText.Text,
                ThirdName = ThirdNameText.Text,
                TIN = TINText.Text,
                CompanyId = _employeeModel.CompanyId
            };

            await _employeeUpdatePresenter.UpdateEmployee(employeeModel);
            await _homeView.RefreshEmployeeList(employeeModel.CompanyId);

            Close();
        }

        private void TINText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
