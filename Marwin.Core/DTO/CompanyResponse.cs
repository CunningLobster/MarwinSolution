using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.DTO
{
    public class CompanyResponse
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(CompanyResponse))
                return false;

            CompanyResponse company = (CompanyResponse)obj;

            return company.CompanyId == CompanyId &&
                company.CompanyName == CompanyName &&
                company.BIN == BIN &&
                company.Address == Address &&
                company.Note == Note;
        }

    }

    public static class CompanyExtensions
    {
        public static CompanyResponse ToCompanyResponse(this Company company)
        {
            return new CompanyResponse
            {
                CompanyId = company.CompanyId,
                CompanyName = company.CompanyName,
                BIN = company.BIN,
                Address = company.Address,
                Note = company.Note
            };
        }
    }

}
