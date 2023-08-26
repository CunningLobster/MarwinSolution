using Marwin.Core.Domain.Entities;
using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.EmployeeServiceContracts
{
    public interface IEmployeeUpdaterService
    {
        /// <summary>
        /// Обновить данные о сотруднике
        /// </summary>
        /// <param name="employeeResponse">Сотрудник</param>
        /// <returns>Обновленный сотрудник</returns>
        Task<EmployeeResponse> UpdateEmployee(EmployeeResponse employeeResponse);
    }
}
