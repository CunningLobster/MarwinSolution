using Marwin.UI.Models;
using Marwin.UI.Presenters.Company;
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
    public partial class CompanyUpdateView : Form
    {
        private readonly HomeView _homeView;
        private readonly CompanyUpdatePresenter _companyUpdatePresenter;
        private readonly CompanyModel _companyModel;

        public CompanyUpdateView(HomeView homeView, CompanyModel companyModel)
        {
            InitializeComponent();
            _companyUpdatePresenter = new CompanyUpdatePresenter(this);
            _companyModel = companyModel;
            _homeView = homeView;
        }

        private void CompanyUpdateView_Load(object sender, EventArgs e)
        {
            HeaderLabel.Text = $"Обновить компанию {_companyModel.CompanyName}";

            //Заполнить поля из модели
            CompanyNameText.Text = _companyModel.CompanyName;
            AddressText.Text = _companyModel.Address;
            BINText.Text = _companyModel.BIN;
            NoteText.Text = _companyModel.Note;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            CompanyModel updatedCompany = new CompanyModel
            {
                CompanyId = _companyModel.CompanyId,
                CompanyName = CompanyNameText.Text,
                Address = AddressText.Text,
                BIN = BINText.Text,
                Note = NoteText.Text
            };

            await _companyUpdatePresenter.UpdateCompany(updatedCompany);
            await _homeView.RefreshCompanyList();

            Close();
        }
    }
}
