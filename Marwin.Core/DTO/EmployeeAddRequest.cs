using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.DTO
{
    public class EmployeeAddRequest
    {
        /// <summary>
        /// Имя сотрудника
        /// </summary>   
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        [StringLength(30)]
        public string ThirdName { get; set; }
        /// <summary>
        /// ИИН сотрудника
        /// </summary>
        [Required]
        public string TIN { get; set; }
        /// <summary>
        /// Идентфикатор компании
        /// </summary>
        public Guid CompanyId { get; set; }

        public Employee ToEmployee() 
        {
            return new Employee
            {
                FirstName = FirstName,
                LastName = LastName,
                ThirdName = ThirdName,
                TIN = TIN,
                CompanyId = CompanyId
            };
        }

    }
}
