using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using Marwin.UI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.UI.Presenters
{
    public class HomePresenter
    {
        private readonly HomeView _homeView;

        private readonly ICompanyGetterService _companyGetterService;
        private readonly IEmployeeGetterService _employeeGetterService;
        private readonly ICsvService _csvService;

        public HomePresenter(HomeView homeView)
        {
            _homeView = homeView;
            _companyGetterService = Program.GetService<ICompanyGetterService>();
            _employeeGetterService = Program.GetService<IEmployeeGetterService>();
            _csvService = Program.GetService<ICsvService>();
        }

        public async Task<List<CompanyModel>> GetCompanies()
        { 
            //Получить ДТО объекты с помощью сервиса
            List<CompanyResponse> companies = await _companyGetterService.GetCompanies();

            //Привязать данные к модели для отображения на экране
            List<CompanyModel> companyModels = new List<CompanyModel>();
            foreach (var company in companies) 
            {
                companyModels.Add(new CompanyModel { 
                    CompanyId = company.CompanyId,
                    CompanyName = company.CompanyName,
                    Address = company.Address,
                    BIN = company.BIN,
                    Note = company.Note
                });
            }

            return companyModels;
        }

        public async Task<List<EmployeeModel>> GetEmployeesByCompanyId(Guid companyId)
        {
            //Получить ДТО объекты с помощью сервиса
            List<EmployeeResponse> employees = await _employeeGetterService.GetEmployeesByCompanyId(companyId);

            //Привязать данные к модели для отображения на экране
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            foreach (var employee in employees) 
            {
                employeeModels.Add(new EmployeeModel
                {
                    EmployeeId = employee.EmployeeId,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    ThirdName = employee.ThirdName,
                    TIN = employee.TIN
                });
            }

            return employeeModels;
        }

        public async Task<MemoryStream> ExportEmployeesCSV(Guid companyId)
        {
            return await _csvService.ExportEmployeesCSV(companyId);
        }

        public async Task ImportEmployeesCSV(FileStream stream, Guid companyId)
        {
            await _csvService.ImportEmployeesCSV(stream, companyId);
        }
    }
}
