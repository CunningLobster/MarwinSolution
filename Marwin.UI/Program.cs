using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using Marwin.Core.Services;
using Marwin.Infrastructure.Data;
using Marwin.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marwin.UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            //Добавление сервисов в IoC контейнер
            services.AddSingleton<ApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<ICompanyRepository, CompaniesRepository>();
            services.AddScoped<IEmployeeRepository, EmployeesRepository>();

            services.AddScoped<IEmployeeGetterService, EmployeeService>();
            services.AddScoped<IEmployeeAdderService, EmployeeService>();
            services.AddScoped<IEmployeeUpdaterService, EmployeeService>();
            services.AddScoped<IEmployeeDeleterSevice, EmployeeService>();

            services.AddScoped<ICompanyGetterService, CompanyService>();
            services.AddScoped<ICompanyAdderService, CompanyService>();
            services.AddScoped<ICompanyUpdaterService, CompanyService>();
            services.AddScoped<ICompanyDeleterService, CompanyService>();

            services.AddScoped<ICsvService, EmployeeService>();

            ServiceProvider = services.BuildServiceProvider();
        }

        public static T GetService<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new HomeView());
        }
    }
}
