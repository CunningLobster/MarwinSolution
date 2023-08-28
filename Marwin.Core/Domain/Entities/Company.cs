using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Marwin.Core.Domain.Entities
{
    public class Company
    {
        /// <summary>
        /// Идентификатор компании
        /// </summary>
        [Key]
        public Guid CompanyId { get; set; }
        /// <summary>
        /// Наименование компании
        /// </summary>
        [StringLength(50)]
        public string CompanyName { get; set; }
        /// <summary>
        /// БИН компании
        /// </summary>
        [StringLength(12)]
        public string BIN { get; set; }
        /// <summary>
        /// Физический адрес компании
        /// </summary>
        [StringLength(200)]
        public string Address { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// Сотрудники
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
