using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Domain.Entities
{
    public class Employee
    {
        /// <summary>
        /// Идентификатор сорудника
        /// </summary>
        [Key]
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        [StringLength(30)]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>        
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
        [StringLength(12)]
        public string TIN{ get; set; }
        /// <summary>
        /// Идентфикатор компании
        /// </summary>
        public Guid CompanyId { get; set; }
        /// <summary>
        /// Компания
        /// </summary>
        public Company Company { get; set; }
    }
}
