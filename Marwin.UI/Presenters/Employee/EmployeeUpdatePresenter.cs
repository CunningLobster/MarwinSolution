using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using Marwin.UI.Models;
using Marwin.UI.Views.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Presenters.Employee
{
    public class EmployeeUpdatePresenter
    {
        private readonly IEmployeeUpdaterService _employeeUpdaterService;
        private readonly EmployeeUpdateView _employeeUpdateView;

        public EmployeeUpdatePresenter(EmployeeUpdateView employeeUpdateView)
        {
            _employeeUpdateView = employeeUpdateView;
            _employeeUpdaterService = Program.GetService<IEmployeeUpdaterService>();
        }

        public async Task UpdateEmployee(EmployeeModel employeeModel)
        {
            //Сформировать запрос на обновление на основе передаваемой модели
            EmployeeUpdateRequest employeeUpdateRequest = new EmployeeUpdateRequest
            {
                EmployeeId = employeeModel.EmployeeId,
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                ThirdName = employeeModel.ThirdName,
                TIN = employeeModel.TIN,
                CompanyId = employeeModel.CompanyId
            };

            //Обновить компанию с помощью сервиса
            await _employeeUpdaterService.UpdateEmployee(employeeUpdateRequest);
        }
    }
}
