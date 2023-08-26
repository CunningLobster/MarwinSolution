using Marwin.Core.Domain.Entities;
using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.CompanyServiceContracts
{
    public interface ICompanyAdderService
    {
        /// <summary>
        /// Добавить новую компанию
        /// </summary>
        /// <param name="company">Компания</param>
        /// <returns>Новая компания</returns>
        Task<CompanyResponse> AddCompany(CompanyAddRequest company);
    }
}
