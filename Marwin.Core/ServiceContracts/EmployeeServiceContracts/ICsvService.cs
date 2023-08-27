using Marwin.Core.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.ServiceContracts.EmployeeServiceContracts
{
    public interface ICsvService
    {
        /// <summary>
        /// Экспортировать список сотрудников компании в CSV файл
        /// </summary>
        /// <param name="companyId">Идентификатор компании</param>
        /// <returns>Поток данных</returns>
        Task<MemoryStream> ExportEmployeesCSV(Guid companyId);

        /// <summary>
        /// Импортировать список сотрудников для компании из CSV файла
        /// </summary>
        /// <param name="memoryStream">Импортируемый поток данных</param>
        /// <param name="companyId">Идентификатор компании</param>
        /// <returns>Список импортируемых сотрудников</returns>
        Task<List<EmployeeResponse>> ImportEmployeesCSV(FileStream memoryStream, Guid companyId);
    }
}
