using Marwin.Core.Domain.Entities;
using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.CompanyServiceContracts
{
    public interface ICompanyGetterService
    {
        /// <summary>
        /// Получить список всех компаний
        /// </summary>
        /// <returns>Список всех компаний</returns>
        Task<List<CompanyResponse>> GetCompanies();
        /// <summary>
        /// Получить компанию по Идентификатору
        /// </summary>
        /// <param name="CompanyId">Идентификатор компании</param>
        /// <returns></returns>
        Task<CompanyResponse> GetCompanyById(Guid CompanyId);
    }
}
