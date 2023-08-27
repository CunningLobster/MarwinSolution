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
    public class EmployeeAddPresenter
    {
        private readonly IEmployeeAdderService _employeeAdderService;
        private readonly EmployeeAddView _employeeAddView;

        public EmployeeAddPresenter(EmployeeAddView employeeAddView)
        { 
            _employeeAdderService = Program.GetService<IEmployeeAdderService>();
            _employeeAddView = employeeAddView;
        }

        public async Task AddEmployee(EmployeeModel employeeModel)
        { 
            //Сформировать запрос на добавление на основе передаваемой модели
            EmployeeAddRequest employeeAddRequest = new EmployeeAddRequest
            {
                CompanyId = employeeModel.CompanyId,
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                ThirdName = employeeModel.ThirdName,
                TIN = employeeModel.TIN
            };

            //Добавить сотрудника с помощью сервиса
            await _employeeAdderService.AddEmployee(employeeAddRequest);
        }
    }
}
