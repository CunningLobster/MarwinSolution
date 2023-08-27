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

namespace Marwin.UI.Views
{
    public partial class CompanyDeleteView : Form
    {
        private readonly HomeView _homeView;
        private readonly CompanyDeletePresenter _companyDeletePresenter;
        private readonly CompanyModel _companyModel;

        public CompanyDeleteView(HomeView homeView, CompanyModel companyModel)
        {
            InitializeComponent();
            _homeView = homeView;
            _companyDeletePresenter = new CompanyDeletePresenter(this);
            _companyModel = companyModel;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await _companyDeletePresenter.DeleteCompany(_companyModel.CompanyId);
            await _homeView.RefreshCompanyList();

            Close();
        }

        private void CompanyDeleteView_Load(object sender, EventArgs e)
        {
            HeaderLabel.Text = $"Вы действительно хотите удалить компанию {_companyModel.CompanyName}?";
        }
    }
}
