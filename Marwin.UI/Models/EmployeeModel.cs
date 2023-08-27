using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Models
{
    public class EmployeeModel
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
        public Guid CompanyId { get; set; }

    }
}
