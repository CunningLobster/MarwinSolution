using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using Marwin.UI.Views;
using Marwin.UI.Views.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Presenters.Company
{
    public class CompanyDeletePresenter
    {
        private readonly CompanyDeleteView _companyDeleteView;

        private readonly ICompanyDeleterService _companyDeleterService;

        public CompanyDeletePresenter(CompanyDeleteView companyDeleteView)
        {
            _companyDeleteView = companyDeleteView;
            _companyDeleterService = Program.GetService<ICompanyDeleterService>();
        }

        public async Task DeleteCompany(Guid companyId)
        {
            await _companyDeleterService.DeleteCompany(companyId);
        }
    }
}
