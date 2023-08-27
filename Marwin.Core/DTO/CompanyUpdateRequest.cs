using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.DTO
{
    public class CompanyUpdateRequest
    {
        /// <summary>
        /// Идентификатор компании
        /// </summary>
        [Required]
        public Guid CompanyId { get; set; }
        /// <summary>
        /// Наименование компании
        /// </summary>
        [Required]
        public string CompanyName { get; set; }
        /// <summary>
        /// БИН компании
        /// </summary>
        [Required]
        [StringLength(12)]
        public string BIN { get; set; }
        /// <summary>
        /// Физический адрес компании
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Address { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        public Company ToCompany()
        {
            return new Company
            {
                CompanyId = CompanyId,
                CompanyName = CompanyName,
                BIN = BIN,
                Address = Address,
                Note = Note
            };
        }

    }
}
