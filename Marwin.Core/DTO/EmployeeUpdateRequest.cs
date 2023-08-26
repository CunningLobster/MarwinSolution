using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.DTO
{
    public class EmployeeUpdateRequest
    {
        /// <summary>
        /// Идентификатор сорудника
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>   
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        public string ThirdName { get; set; }
        /// <summary>
        /// ИИН сотрудника
        /// </summary>
        public string TIN { get; set; }
        /// <summary>
        /// Идентфикатор компании
        /// </summary>
        public Guid CompanyId { get; }

        public Employee ToEmployee()
        {
            return new Employee
            {
                EmployeeId = EmployeeId,
                FirstName = FirstName,
                LastName = LastName,
                ThirdName = ThirdName,
                TIN = TIN,
                CompanyId = CompanyId
            };
        }
    }
}
