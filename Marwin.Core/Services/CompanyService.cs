using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Services
{
    public class CompanyService : ICompanyGetterService, ICompanyAdderService, ICompanyUpdaterService, ICompanyDeleterService
    {
        public Task<CompanyResponse> AddCompany(CompanyAddRequest company)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCompany(CompanyUpdateRequest company)
        {
            throw new NotImplementedException();
        }

        public Task<List<CompanyResponse>> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<CompanyResponse> GetCompanyById(Guid CompanyId)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyResponse> UpdateCompany(CompanyUpdateRequest company)
        {
            throw new NotImplementedException();
        }
    }
}
