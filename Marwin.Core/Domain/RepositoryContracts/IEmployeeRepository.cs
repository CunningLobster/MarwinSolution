using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Domain.RepositoryContracts
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Получить список список сотрудников в компании
        /// </summary>
        /// <param name="companyId">Идентификатор компании</param>
        /// <returns>Список сотрудников компании</returns>
        Task<List<Employee>> GetEmployeesByCompanyId(Guid companyId);
        /// <summary>
        /// Получить сотрудника по Идентификатору
        /// </summary>
        /// <param name="employeeId">Идентификатор сотрудника</param>
        /// <returns>Сотрудник с выбранным Идентификатором</returns>
        Task<Employee> GetEmployeeById(Guid employeeId);
        /// <summary>
        /// Добавить нового сотрудника в компанию с выбранным Идентификатором
        /// </summary>
        /// <param name="employee">Добавляемый сотрудник</param>
        /// <param name="companyId">Идентификатор компании</param>
        /// <returns>Новый сотрудник</returns>
        Task<Employee> AddEmployee(Employee employee, Guid companyId);
        /// <summary>
        /// Обновить данные о сотруднике
        /// </summary>
        /// <param name="Employee">Сотрудник</param>
        /// <returns>Обновленный сотрудник</returns>
        Task<Employee> UpdateEmployee(Employee employee);
        /// <summary>
        /// Удалить сотрудника с выбранным Идентификатором
        /// </summary>
        /// <param name="employeeId">Идентификатор сотрудника</param>
        /// <returns>true, если удаление прошло успешно</returns>
        Task<bool> DeleteEmployee(Guid employeeId);

    }
}
