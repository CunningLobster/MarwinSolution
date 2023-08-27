using Marwin.UI.Models;
using Marwin.UI.Presenters.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marwin.UI.Views.Employee
{
    public partial class EmployeeDeleteView : Form
    {
        private readonly EmployeeDeletePresenter _employeeDeletePresenter;
        private readonly EmployeeModel _employeeModel;
        private readonly HomeView _homeView;

        public EmployeeDeleteView(HomeView homeView, EmployeeModel employeeModel)
        {
            InitializeComponent();
            _employeeDeletePresenter = new EmployeeDeletePresenter(this);
            _homeView = homeView;
            _employeeModel = employeeModel;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeDeleteView_Load(object sender, EventArgs e)
        {
            HeaderLabel.Text = $"Вы уверены, что хотите удалить сотрудника {_employeeModel.FirstName} {_employeeModel.LastName}?";
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await _employeeDeletePresenter.DeleteEmployee(_employeeModel.EmployeeId);
            await _homeView.RefreshEmployeeList(_employeeModel.CompanyId);

            Close();
        }
    }
}
