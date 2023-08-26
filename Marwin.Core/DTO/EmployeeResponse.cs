using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.DTO
{
    public class EmployeeResponse
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
        /// <summary>
        /// Компания
        /// </summary>
        public string Company { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;
            if(obj.GetType() != typeof(EmployeeResponse))
                return false;

            EmployeeResponse employee = (EmployeeResponse)obj;
            return employee.EmployeeId == EmployeeId && 
                employee.FirstName == FirstName && 
                employee.LastName == LastName &&
                employee.ThirdName == ThirdName &&
                employee.TIN == TIN &&
                employee.CompanyId == CompanyId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class EmployeeExtensions
    { 
        public static EmployeeResponse ToEmployeeResponse(this Employee employee) 
        {
            return new EmployeeResponse 
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                ThirdName = employee.ThirdName,
                TIN = employee.TIN,
                CompanyId = employee.CompanyId,
                Company = employee.Company.CompanyName
            };
        }
    }
}
