﻿using CsvHelper.Configuration;
using CsvHelper;
using Marwin.Core.Domain.Entities;
using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Core.DTO;
using Marwin.Core.Helpers;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Services
{
    public class EmployeeService : IEmployeeGetterService, IEmployeeAdderService, IEmployeeUpdaterService, IEmployeeDeleterSevice, ICsvService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICompanyRepository _companyRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, ICompanyRepository companyRepository)
        {
            _employeeRepository = employeeRepository;
            _companyRepository = companyRepository;
        }

        public async Task<EmployeeResponse> AddEmployee(EmployeeAddRequest employeeAddRequest)
        {
            if(employeeAddRequest == null)
                throw new ArgumentNullException(nameof(employeeAddRequest));

            //Валидация объекта
            ValidationHelper.ModelValidation(employeeAddRequest);

            //Добавление сотрудника в БД
            Employee employeeToAdd = employeeAddRequest.ToEmployee();
            employeeToAdd.EmployeeId = Guid.NewGuid();
            await _employeeRepository.AddEmployee(employeeToAdd);

            return employeeToAdd.ToEmployeeResponse();
        }

        public async Task<bool> DeleteEmployee(Guid employeeId)
        {
            if (employeeId == null)
                throw new ArgumentNullException(nameof(employeeId));

            Employee employeeToDelete = await _employeeRepository.GetEmployeeById(employeeId);
            if (employeeToDelete == null)
                return false;

            await _employeeRepository.DeleteEmployee(employeeId);
            return true;
        }

        public async Task<MemoryStream> ExportEmployeesCSV(Guid companyId)
        {
            MemoryStream memoryStream = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(memoryStream);
            CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture);
            CsvWriter csvWriter = new CsvWriter(streamWriter, csvConfiguration);

            csvWriter.WriteField(nameof(EmployeeResponse.FirstName));
            csvWriter.WriteField(nameof(EmployeeResponse.LastName));
            csvWriter.WriteField(nameof(EmployeeResponse.ThirdName));
            csvWriter.WriteField(nameof(EmployeeResponse.TIN));
            csvWriter.WriteField(nameof(Company.CompanyName));
            csvWriter.NextRecord();

            List<EmployeeResponse> employees = await GetEmployeesByCompanyId(companyId);
            foreach (var employee in employees)
            {
                csvWriter.WriteField(employee.FirstName);
                csvWriter.WriteField(employee.LastName);
                csvWriter.WriteField(employee.ThirdName);
                csvWriter.WriteField(employee.TIN);

                Company company = await _companyRepository.GetCompanyById(companyId);
                csvWriter.WriteField(company.CompanyName);
                csvWriter.NextRecord();
                csvWriter.Flush();
            }

            memoryStream.Position = 0;
            return memoryStream;
        }

        public async Task<EmployeeResponse> GetEmployeeById(Guid employeeId)
        {
            if (employeeId == null)
                throw new ArgumentNullException(nameof(employeeId));

            Employee employee = await _employeeRepository.GetEmployeeById(employeeId);
            if (employee == null)
                return null;

            return employee.ToEmployeeResponse();
        }

        public async Task<List<EmployeeResponse>> GetEmployeesByCompanyId(Guid companyId)
        {
            //Получить искомую компанию
            if (companyId == null)
                throw new ArgumentNullException(nameof(companyId));

            Company company = await _companyRepository.GetCompanyById(companyId);
            if (company == null)
                throw new ArgumentException($"Company with id: {companyId} doesn't exist");

            List<Employee> employees = await _employeeRepository.GetEmployeesByCompanyId(companyId);
            return employees.Select(e => e.ToEmployeeResponse()).ToList();
        }

        public async Task<List<EmployeeResponse>> ImportEmployeesCSV(FileStream fileStream, Guid companyId)
        {
            List<EmployeeAddRequest> employeeAddRequests = new List<EmployeeAddRequest>();
            using (var reader = new StreamReader(fileStream))
            {
                CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture);
                csvConfiguration.HeaderValidated = null;
                csvConfiguration.MissingFieldFound = null;
                using (var csv = new CsvReader(reader, csvConfiguration))
                {
                    employeeAddRequests = csv.GetRecords<EmployeeAddRequest>().ToList();
                }
            }

            List<EmployeeResponse> employeeResponses = new List<EmployeeResponse>();
            foreach (var employeeAddRequest in employeeAddRequests)
            {
                employeeAddRequest.CompanyId = companyId;
                EmployeeResponse response = await AddEmployee(employeeAddRequest);
                employeeResponses.Add(response);
            }

            return employeeResponses;
        }

        public async Task<EmployeeResponse> UpdateEmployee(EmployeeUpdateRequest employeeUpdateRequest)
        {
            if (employeeUpdateRequest == null)
                throw new ArgumentNullException(nameof(employeeUpdateRequest));

            //Валидация объекта
            ValidationHelper.ModelValidation(employeeUpdateRequest);

            Employee matchngEmployee = await _employeeRepository.GetEmployeeById(employeeUpdateRequest.EmployeeId);
            if (matchngEmployee == null)
                throw new ArgumentException($"Employee with id: {employeeUpdateRequest.EmployeeId} doesn't exist");

            //Обновление сотрудника
            matchngEmployee.FirstName = employeeUpdateRequest.FirstName;
            matchngEmployee.LastName = employeeUpdateRequest.LastName;
            matchngEmployee.ThirdName = employeeUpdateRequest.ThirdName;
            matchngEmployee.TIN = employeeUpdateRequest.TIN;
            matchngEmployee.CompanyId = employeeUpdateRequest.CompanyId;
            await _employeeRepository.UpdateEmployee(matchngEmployee);

            return matchngEmployee.ToEmployeeResponse();
        }
    }
}
