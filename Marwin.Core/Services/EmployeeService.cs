using Marwin.Core.Domain.Entities;
using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Services
{
    public class EmployeeService : IEmployeeGetterService, IEmployeeAdderService, IEmployeeUpdaterService, IEmployeeDeleterSevice
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<EmployeeResponse> AddEmployee(EmployeeAddRequest employeeAddRequest, Guid companyId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployee(EmployeeUpdateRequest employeeUpdateRequest)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeResponse> GetEmployeeById(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeResponse>> GetEmployeesByCompanyId(Guid companyId)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeResponse> UpdateEmployee(EmployeeResponse employeeResponse)
        {
            throw new NotImplementedException();
        }
    }
}
