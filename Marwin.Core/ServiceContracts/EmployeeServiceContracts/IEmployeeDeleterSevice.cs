using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.EmployeeServiceContracts
{
    public interface IEmployeeDeleterSevice
    {
        /// <summary>
        /// Удалить сотрудника с выбранным Идентификатором
        /// </summary>
        /// <param name="employeeId">Идентификатор сотрудника</param>
        /// <returns>true, если удаление прошло успешно</returns>
        Task<bool> DeleteEmployee(Guid employeeId);
    }
}
