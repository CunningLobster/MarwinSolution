using Marwin.Core.Domain.Entities;
using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.CompanyServiceContracts
{
    public interface ICompanyUpdaterService
    {
        /// <summary>
        /// Обновить данные о компании
        /// </summary>
        /// <param name="companyUpdateRequest">Компания</param>
        /// <returns>Обновленная компания</returns>
        Task<CompanyResponse> UpdateCompany(CompanyUpdateRequest companyUpdateRequest);
    }
}
