using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.CompanyServiceContracts
{
    public interface ICompanyDeleterService
    {
        /// <summary>
        /// Удалить компанию с выбранным Идентификатором
        /// </summary>
        /// <param name="companyUpdateRequest">Удаляемая компания</param>
        /// <returns>true, если удаление прошло успешно</returns>
        Task<bool> DeleteCompany(CompanyUpdateRequest companyUpdateRequest);
    }
}
