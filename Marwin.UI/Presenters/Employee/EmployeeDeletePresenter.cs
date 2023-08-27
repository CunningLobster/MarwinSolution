using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using Marwin.UI.Views.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Presenters.Employee
{
    public class EmployeeDeletePresenter
    {
        private readonly IEmployeeDeleterSevice _employeeDeleterService;
        private readonly EmployeeDeleteView _employeeDeleteView;

        public EmployeeDeletePresenter(EmployeeDeleteView employeeDeleteView)
        { 
            _employeeDeleterService = Program.GetService<IEmployeeDeleterSevice>();
            _employeeDeleteView = employeeDeleteView;
        }

        public async Task DeleteEmployee(Guid employeeId)
        {
            await _employeeDeleterService.DeleteEmployee(employeeId);
        }
    }
}
