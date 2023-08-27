using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Models
{
    public class CompanyModel
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
    }
}
