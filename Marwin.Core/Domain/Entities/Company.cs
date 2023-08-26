using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Domain.Entities
{
    public class Company
    {
        /// <summary>
        /// Идентификатор компании
        /// </summary>
        public Guid CompanyId { get; set; }
        /// <summary>
        /// Наименование компании
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// БИН компании
        /// </summary>
        public string BIN { get; set; }
        /// <summary>
        /// Физический адрес компании
        /// </summary>
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
