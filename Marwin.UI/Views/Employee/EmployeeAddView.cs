﻿using Marwin.UI.Models;
using Marwin.UI.Presenters.Employee;
using Marwin.UI.Validation;
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
            if (!ValidateChildren())
                return;

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

        private void LastNameText_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.CheckToEmptyString((TextBox)sender, errorProvider1, e);
            ValidationHelper.CheckStringLength((TextBox)sender, 30, errorProvider1, e);
        }

        private void FirstNameText_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.CheckToEmptyString((TextBox)sender, errorProvider1, e);
            ValidationHelper.CheckStringLength((TextBox)sender, 30, errorProvider1, e);
        }

        private void TINText_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.CheckToEmptyString((TextBox)sender, errorProvider1, e);
            ValidationHelper.CheckStringLength((TextBox)sender, 12, errorProvider1, e);
        }
    }
}
