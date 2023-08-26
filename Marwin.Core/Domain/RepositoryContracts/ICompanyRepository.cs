using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Domain.RepositoryContracts
{
    public interface ICompanyRepository
    {
        /// <summary>
        /// Получить список всех компаний
        /// </summary>
        /// <returns>Список всех компаний</returns>
        Task<List<Company>> GetCompanies();
        /// <summary>
        /// Получить компанию по Идентификатору
        /// </summary>
        /// <param name="CompanyId">Идентификатор компании</param>
        /// <returns></returns>
        Task<Company> GetCompanyById(Guid CompanyId);
        /// <summary>
        /// Добавить новую компанию
        /// </summary>
        /// <param name="company">Компания</param>
        /// <returns>Новая компания</returns>
        Task<Company> AddCompany(Company company);
        /// <summary>
        /// Обновить данные о компании
        /// </summary>
        /// <param name="company">Компания</param>
        /// <returns>Обновленная компания</returns>
        Task<Company> UpdateCompany(Company company);
        /// <summary>
        /// Удалить компанию с выбранным Идентификатором
        /// </summary>
        /// <param name="company">Удаляемая компания</param>
        /// <returns>true, если удаление прошло успешно</returns>
        Task<bool> DeleteCompany(Company company);
    }
}
