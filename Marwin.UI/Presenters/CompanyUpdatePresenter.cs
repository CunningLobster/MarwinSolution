using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using Marwin.UI.Models;
using Marwin.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Presenters
{
    public class CompanyUpdatePresenter
    {
        private readonly CompanyUpdateView _companyUpdateView;

        private readonly ICompanyUpdaterService _companyUpdaterService;

        public CompanyUpdatePresenter(CompanyUpdateView companyUpdateView)
        {
            _companyUpdateView = companyUpdateView;
            _companyUpdaterService = Program.GetService<ICompanyUpdaterService>();
        }

        public async Task UpdateCompany(CompanyModel companyModel)
        {
            //Сформировать запрос на обновление на основе передаваемой модели
            CompanyUpdateRequest companyUpdateRequest = new CompanyUpdateRequest
            {
                CompanyId = companyModel.CompanyId,
                CompanyName = companyModel.CompanyName,
                Address = companyModel.Address,
                BIN = companyModel.BIN,
                Note = companyModel.Note
            };

            //Обновить компанию с помощью сервиса
            await _companyUpdaterService.UpdateCompany(companyUpdateRequest);
        }
    }
}
