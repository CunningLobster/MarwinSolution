using Marwin.UI.Models;
using Marwin.UI.Presenters;
using Marwin.UI.Presenters.Company;
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

namespace Marwin.UI.Views.Company
{
    public partial class CompanyAddView : Form
    {
        private readonly CompanyAddPresenter _companyAddPresenter;
        private readonly HomeView _homeView;

        public CompanyAddView(HomeView homeView)
        {
            InitializeComponent();
            _companyAddPresenter = new CompanyAddPresenter(this);
            _homeView = homeView;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            //Собираем модель на основе данных на форме
            CompanyModel companyModel = new CompanyModel()
            {
                CompanyName = CompanyNameText.Text,
                Address = AddressText.Text,
                BIN = BINText.Text,
                Note = NoteText.Text
            };

            //Добавление компании в БД
            await _companyAddPresenter.AddCompany(companyModel);
            await _homeView.RefreshCompanyList();

            Close();
        }

        private void BINText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void CompanyNameText_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.CheckToEmptyString((TextBox)sender, errorProvider1, e);
            ValidationHelper.CheckStringLength((TextBox)sender, 50, errorProvider1, e);
        }

        private void AddressText_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.CheckToEmptyString((TextBox)sender, errorProvider1, e);
            ValidationHelper.CheckStringLength((TextBox)sender, 200, errorProvider1, e);
        }

        private void BINText_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.CheckToEmptyString((TextBox)sender, errorProvider1, e);
            ValidationHelper.CheckStringLength((TextBox)sender, 12, errorProvider1, e);
        }
    }
}
