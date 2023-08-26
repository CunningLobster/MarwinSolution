using Marwin.Core.Domain.Entities;
using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.EmployeeServiceContracts
{
    public interface IEmployeeGetterService
    {
        /// <summary>
        /// Получить список список сотрудников в компании
        /// </summary>
        /// <param name="companyId">Идентификатор компании</param>
        /// <returns>Список сотрудников компании</returns>
        Task<List<EmployeeResponse>> GetEmployeesByCompanyId(Guid companyId);
        /// <summary>
        /// Получить сотрудника по Идентификатору
        /// </summary>
        /// <param name="employeeId">Идентификатор сотрудника</param>
        /// <returns>Сотрудник с выбранным Идентификатором</returns>
        Task<EmployeeResponse> GetEmployeeById(Guid employeeId);
    }
}
