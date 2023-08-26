using Marwin.Core.Domain.Entities;
using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Infrastructure.Repositories
{
    public class EmployeesRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeesRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
            await _db.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteEmployee(Guid employeeId)
        {
            Employee employeeToDelete = _db.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employeeToDelete != null)
            {
                _db.Employees.Remove(employeeToDelete);
                await _db.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<Employee> GetEmployeeById(Guid employeeId)
        {
            return await _db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<List<Employee>> GetEmployeesByCompanyId(Guid companyId)
        {
            return await _db.Employees.Where(e => e.CompanyId == companyId).ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            Employee employeeToUpdate = await _db.Employees.FirstOrDefaultAsync(c => c.EmployeeId == employee.EmployeeId);

            if (employeeToUpdate == null)
                return employeeToUpdate;

            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.ThirdName = employee.ThirdName;
            employeeToUpdate.TIN = employee.TIN;
            employeeToUpdate.CompanyId = employee.CompanyId;
            await _db.SaveChangesAsync();

            return employeeToUpdate;
        }
    }
}
