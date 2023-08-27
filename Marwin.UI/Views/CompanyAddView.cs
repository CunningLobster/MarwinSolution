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

        private async void CompanyAddView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
