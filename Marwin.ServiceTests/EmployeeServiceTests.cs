using AutoFixture;
using FluentAssertions;
using Marwin.Core.Domain.Entities;
using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using Marwin.Core.ServiceContracts.EmployeeServiceContracts;
using Marwin.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.ServiceTests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        //Интерфейсы сервисов
        private readonly IEmployeeGetterService _employeeGetterService;
        private readonly IEmployeeAdderService _employeeAdderService;
        private readonly IEmployeeUpdaterService _employeeUpdaterService;
        private readonly IEmployeeDeleterSevice _employeeDeleterService;


        //Репозитории компаний и мок репозиториев
        private readonly ICompanyRepository _companyRepository;
        private readonly Mock<ICompanyRepository> _companyRepositoryMock;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly Mock<IEmployeeRepository> _employeeRepositoryMock;

        private readonly IFixture _fixture;

        public EmployeeServiceTests() 
        {
            _fixture = new Fixture();

            //Имплементация тестового репозитория
            _companyRepositoryMock = new Mock<ICompanyRepository>();
            _companyRepository = _companyRepositoryMock.Object;
            _employeeRepositoryMock = new Mock<IEmployeeRepository>();
            _employeeRepository = _employeeRepositoryMock.Object;

            //Имплементация тестового сервиса
            _employeeGetterService = new EmployeeService(_employeeRepository, _companyRepository);
            _employeeAdderService = new EmployeeService(_employeeRepository, _companyRepository);
            _employeeUpdaterService = new EmployeeService(_employeeRepository, _companyRepository);
            _employeeDeleterService = new EmployeeService(_employeeRepository, _companyRepository);
        }

        #region AddEmployee

        [TestMethod]
        public async Task AddEmployee_CompanyAddRequestIsNull_ThrowArgumentNullException()
        {
            //Arrange
            EmployeeAddRequest employeeAddRequest = null;

            //Act
            Func<Task> action = async () => await _employeeAdderService.AddEmployee(employeeAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [TestMethod]
        public async Task AddEmployee_FirstNameIsEmpty_ThrowArgumentException()
        {
            //Arrange
            EmployeeAddRequest employeeAddRequest = _fixture.Build<EmployeeAddRequest>()
                .With(c => c.FirstName, String.Empty).Create();
            Employee employee = employeeAddRequest.ToEmployee();

            _employeeRepositoryMock.Setup(s => s.AddEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);

            //Act
            Func<Task> action = async () => await _employeeAdderService.AddEmployee(employeeAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task AddEmployee_LastNameIsEmpty_ThrowArgumentException()
        {
            //Arrange
            EmployeeAddRequest employeeAddRequest = _fixture.Build<EmployeeAddRequest>()
                .With(c => c.LastName, String.Empty).Create();
            Employee employee = employeeAddRequest.ToEmployee();

            _employeeRepositoryMock.Setup(s => s.AddEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);

            //Act
            Func<Task> action = async () => await _employeeAdderService.AddEmployee(employeeAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task AddEmployee_TINIsEmpty_ThrowArgumentException()
        {
            //Arrange
            EmployeeAddRequest employeeAddRequest = _fixture.Build<EmployeeAddRequest>()
                .With(c => c.TIN, String.Empty).Create();
            Employee employee = employeeAddRequest.ToEmployee();

            _employeeRepositoryMock.Setup(s => s.AddEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);

            //Act
            Func<Task> action = async () => await _employeeAdderService.AddEmployee(employeeAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task AddEmployee_ValidData_ToBeSuccessful()
        {
            //Arrange
            EmployeeAddRequest employeeAddRequest = _fixture.Create<EmployeeAddRequest>();
            Employee employee = employeeAddRequest.ToEmployee();
            EmployeeResponse employeeResponseExpected = employee.ToEmployeeResponse();

            _employeeRepositoryMock.Setup(s => s.AddEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);

            //Act
            EmployeeResponse employeeResponseFromAdd = await _employeeAdderService.AddEmployee(employeeAddRequest);
            employeeResponseExpected.EmployeeId = employeeResponseFromAdd.EmployeeId;

            //Assert
            employeeResponseFromAdd.EmployeeId.Should().NotBe(Guid.Empty);
            employeeResponseFromAdd.Should().Be(employeeResponseExpected);
        }

        #endregion

        #region DeleteEmployee

        [TestMethod]
        public async Task DeleteEmployee_InvalidEmployeeId_ShouldReturnFalse()
        {
            //Act
            bool isDeleted = await _employeeDeleterService.DeleteEmployee(Guid.Empty);

            //Assert
            isDeleted.Should().BeFalse();
        }

        [TestMethod]
        public async Task DeleteEmployee_ValidEmployeeId_ToBeSuccessful()
        {
            //Arrange
            Employee employee = _fixture.Build<Employee>().With(e => e.Company, null as Company).Create();

            _employeeRepositoryMock.Setup(c => c.GetEmployeeById(It.IsAny<Guid>())).ReturnsAsync(employee);
            _employeeRepositoryMock.Setup(c => c.DeleteEmployee(It.IsAny<Guid>())).ReturnsAsync(true);

            //Act
            bool isDeleted = await _employeeDeleterService.DeleteEmployee(employee.EmployeeId);

            //Assert
            isDeleted.Should().BeTrue();
        }

        #endregion

        #region GetEmployeeById

        [TestMethod]
        public async Task GetEmployeeById_EmployeeIsNull_ReturnNull()
        {
            //Arrange
            Employee employee = null;

            _employeeRepositoryMock.Setup(c => c.GetEmployeeById(It.IsAny<Guid>())).ReturnsAsync(employee);

            //Act
            EmployeeResponse employeeResponseActual = await _employeeGetterService.GetEmployeeById(Guid.NewGuid());

            //Assert
            employeeResponseActual.Should().BeNull();
        }

        [TestMethod]
        public async Task GetEmployeeById_ValidData_ToBeSuccessfull()
        {
            //Arrange
            Employee employee = _fixture.Build<Employee>().With(c => c.Company, null as Company).Create();
            EmployeeResponse employeeResponseExpected = employee.ToEmployeeResponse();

            _employeeRepositoryMock.Setup(c => c.GetEmployeeById(It.IsAny<Guid>())).ReturnsAsync(employee);

            //Act
            EmployeeResponse employeeResponseActual = await _employeeGetterService.GetEmployeeById(Guid.NewGuid());

            //Assert
            employeeResponseActual.Should().Be(employeeResponseExpected);
        }

        #endregion

        #region GetEmployeesByCompanyId

        [TestMethod]
        public async Task GetEmployeesByCompanyId_CompanyIsNull_ArgumentException()
        { 
            //Arrange
            Company company = null;

            _companyRepositoryMock.Setup(c => c.GetCompanyById(It.IsAny<Guid>())).ReturnsAsync(company);

            //Act
            Guid guid = Guid.NewGuid();
            Func<Task> action = async () => await _employeeGetterService.GetEmployeesByCompanyId(guid);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task GetEmployeesByCompanyId_EmptyEmployeeList_ReturnEmptyList()
        {
            //Arrange
            Company company = _fixture.Build<Company>().With(c => c.Employees, null as ICollection<Employee>).Create();
            List<Employee> employees = new List<Employee>();
            List<EmployeeResponse> employeeResponsesExpected = employees.Select(e => e.ToEmployeeResponse()).ToList();

            _companyRepositoryMock.Setup(c => c.GetCompanyById(It.IsAny<Guid>())).ReturnsAsync(company);
            _employeeRepositoryMock.Setup(e => e.GetEmployeesByCompanyId(It.IsAny<Guid>())).ReturnsAsync(employees);

            //Act
            List<EmployeeResponse> employeeResponsesActual = await _employeeGetterService.GetEmployeesByCompanyId(company.CompanyId);

            //Assert
            employeeResponsesActual.Should().BeEquivalentTo(employeeResponsesExpected);
            employeeResponsesActual.Should().BeEmpty();
        }

        [TestMethod]
        public async Task GetEmployeesByCompanyId_ValidData_ToBeSuccessful()
        {
            //Arrange
            Company company = _fixture.Build<Company>().With(c => c.Employees, null as ICollection<Employee>).Create();
            List<Employee> employees = _fixture.Build<Employee>().With(e => e.Company, null as Company).CreateMany().ToList();
            List<EmployeeResponse> employeeResponsesExpected = employees.Select(e => e.ToEmployeeResponse()).ToList();

            _companyRepositoryMock.Setup(c => c.GetCompanyById(It.IsAny<Guid>())).ReturnsAsync(company);
            _employeeRepositoryMock.Setup(e => e.GetEmployeesByCompanyId(It.IsAny<Guid>())).ReturnsAsync(employees);

            //Act
            List<EmployeeResponse> employeeResponsesActual = await _employeeGetterService.GetEmployeesByCompanyId(company.CompanyId);

            //Assert
            employeeResponsesActual.Should().BeEquivalentTo(employeeResponsesExpected);
        }

        #endregion

        #region UpdateEmployee

        [TestMethod]
        public async Task UpdateEmployee_CompanyAddRequestIsNull_ThrowArgumentNullException()
        {
            //Arrange
            EmployeeUpdateRequest employeeUpdateRequest = null;

            //Act
            Func<Task> action = async () => await _employeeUpdaterService.UpdateEmployee(employeeUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [TestMethod]
        public async Task UpdateEmployee_FirstNameIsEmpty_ThrowArgumentException()
        {
            //Arrange
            EmployeeUpdateRequest employeeUpdateRequest = _fixture.Build<EmployeeUpdateRequest>()
                .With(c => c.FirstName, String.Empty).Create();
            Employee employee = employeeUpdateRequest.ToEmployee();

            _employeeRepositoryMock.Setup(s => s.UpdateEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);

            //Act
            Func<Task> action = async () => await _employeeUpdaterService.UpdateEmployee(employeeUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task UpdateEmployee_LastNameIsEmpty_ThrowArgumentException()
        {
            //Arrange
            EmployeeUpdateRequest employeeUpdateRequest = _fixture.Build<EmployeeUpdateRequest>()
                .With(c => c.LastName, String.Empty).Create();
            Employee employee = employeeUpdateRequest.ToEmployee();

            _employeeRepositoryMock.Setup(s => s.UpdateEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);

            //Act
            Func<Task> action = async () => await _employeeUpdaterService.UpdateEmployee(employeeUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task UpdateEmployee_TINIsEmpty_ThrowArgumentException()
        {
            //Arrange
            EmployeeUpdateRequest employeeUpdateRequest = _fixture.Build<EmployeeUpdateRequest>()
                .With(c => c.TIN, String.Empty).Create();
            Employee employee = employeeUpdateRequest.ToEmployee();

            _employeeRepositoryMock.Setup(s => s.UpdateEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);

            //Act
            Func<Task> action = async () => await _employeeUpdaterService.UpdateEmployee(employeeUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task UpdateEmployee_MatchingEmployeeNotFound_ThrowArgumentException()
        {
            //Arrange
            EmployeeUpdateRequest employeeUpdateRequest = _fixture.Create<EmployeeUpdateRequest>();
            Employee employee = employeeUpdateRequest.ToEmployee();
            EmployeeResponse employeeResponseExpected = employee.ToEmployeeResponse();

            _employeeRepositoryMock.Setup(s => s.UpdateEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);
            _employeeRepositoryMock.Setup(s => s.GetEmployeeById(It.IsAny<Guid>())).ReturnsAsync(null as Employee);

            //Act
            Func<Task> action = async () => await _employeeUpdaterService.UpdateEmployee(employeeUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task UpdateEmployee_ValidData_ToBeSuccessful()
        {
            //Arrange
            EmployeeUpdateRequest employeeUpdateRequest = _fixture.Create<EmployeeUpdateRequest>();
            Employee employee = employeeUpdateRequest.ToEmployee();
            EmployeeResponse employeeResponseExpected = employee.ToEmployeeResponse();

            _employeeRepositoryMock.Setup(s => s.UpdateEmployee(It.IsAny<Employee>())).ReturnsAsync(employee);
            _employeeRepositoryMock.Setup(s => s.GetEmployeeById(It.IsAny<Guid>())).ReturnsAsync(employee);

            //Act
            EmployeeResponse employeeResponseFromUpdate = await _employeeUpdaterService.UpdateEmployee(employeeUpdateRequest);

            //Assert
            employeeResponseFromUpdate.Should().Be(employeeResponseExpected);
        }

        #endregion
    }
}
