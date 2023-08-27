using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using Marwin.UI.Models;
using Marwin.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Presenters
{
    public class CompanyAddPresenter
    {
        private readonly CompanyAddView _companyAddView;

        private readonly ICompanyAdderService _companyAdderService;

        public CompanyAddPresenter(CompanyAddView companyAddView)
        {
            _companyAddView = companyAddView;
            _companyAdderService = Program.GetService<ICompanyAdderService>();
        }

        public async Task AddCompany(CompanyModel companyModel)
        {
            //Сформировать запрос на добавление на основе передаваемой модели
            CompanyAddRequest companyAddRequest = new CompanyAddRequest
            {
                CompanyName = companyModel.CompanyName,
                Address = companyModel.Address,
                BIN = companyModel.BIN,
                Note = companyModel.Note
            };

            //Добавить компанию с помощью сервиса
            await _companyAdderService.AddCompany(companyAddRequest);
        }
    }
}
