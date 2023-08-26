using Marwin.Core.Domain.Entities;
using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.EmployeeServiceContracts
{
    public interface IEmployeeAdderService
    {
        /// <summary>
        /// Добавить нового сотрудника в компанию с выбранным Идентификатором
        /// </summary>
        /// <param name="employeeAddRequest">Добавляемый сотрудник</param>
        /// <param name="companyId">Идентификатор компании</param>
        /// <returns>Новый сотрудник</returns>
        Task<EmployeeResponse> AddEmployee(EmployeeAddRequest employeeAddRequest, Guid companyId);

    }
}
