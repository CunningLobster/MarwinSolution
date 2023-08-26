using AutoFixture;
using FluentAssertions;
using Marwin.Core.Domain.Entities;
using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Core.DTO;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
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
    public class CompanyServiceTests
    {
        //Интерфейсы сервисов
        private readonly ICompanyGetterService _companyGetterService;
        private readonly ICompanyAdderService _companyAdderService;
        private readonly ICompanyUpdaterService _companyUpdaterService;
        private readonly ICompanyDeleterService _companyDeleterService;

        //Репозиторий компаний и мок репозитория
        private readonly ICompanyRepository _companyRepository;
        private readonly Mock<ICompanyRepository> _companyRepositoryMock;

        private readonly IFixture _fixture;

        public CompanyServiceTests()
        {
            _fixture = new Fixture();

            //Имплементация тестового репозитория
            _companyRepositoryMock = new Mock<ICompanyRepository>();
            _companyRepository = _companyRepositoryMock.Object;

            //Имплементация тестового сервиса
            _companyGetterService = new CompanyService(_companyRepository);
            _companyAdderService = new CompanyService(_companyRepository);
            _companyUpdaterService = new CompanyService(_companyRepository);
            _companyDeleterService = new CompanyService(_companyRepository);
        }

        #region AddCompany

        [TestMethod]
        public async Task AddCompany_CompanyAddRequestIsNull_ThrowArgumentNullException()
        {
            //Arrange
            CompanyAddRequest companyAddRequest = null;

            //Act
            Func<Task> action = async () => await _companyAdderService.AddCompany(companyAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [TestMethod]
        public async Task AddCompany_CompanyNameIsEmpty_ThrowArgumentException()
        {
            //Arrange
            CompanyAddRequest companyAddRequest = _fixture.Build<CompanyAddRequest>()
                .With(c => c.CompanyName, String.Empty).Create();
            Company company = companyAddRequest.ToCompany();

            _companyRepositoryMock.Setup(s => s.AddCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            Func<Task> action = async () => await _companyAdderService.AddCompany(companyAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task AddCompany_BINIsEmpty_ThrowArgumentException()
        {
            //Arrange
            CompanyAddRequest companyAddRequest = _fixture.Build<CompanyAddRequest>()
                .With(c => c.BIN, String.Empty).Create();
            Company company = companyAddRequest.ToCompany();

            _companyRepositoryMock.Setup(s => s.AddCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            Func<Task> action = async () => await _companyAdderService.AddCompany(companyAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task AddCompany_AddressIsEmpty_ThrowArgumentException()
        {
            //Arrange
            CompanyAddRequest companyAddRequest = _fixture.Build<CompanyAddRequest>()
                .With(c => c.Address, String.Empty).Create();
            Company company = companyAddRequest.ToCompany();

            _companyRepositoryMock.Setup(s => s.AddCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            Func<Task> action = async () => await _companyAdderService.AddCompany(companyAddRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task AddCompany_ValidData_ToBeSuccessful()
        {
            //Arrange
            CompanyAddRequest companyAddRequest = _fixture.Create<CompanyAddRequest>();
            Company company = companyAddRequest.ToCompany();
            CompanyResponse companyResponseExpected = company.ToCompanyResponse();

            _companyRepositoryMock.Setup(s => s.AddCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            CompanyResponse companyResponseFromAdd = await _companyAdderService.AddCompany(companyAddRequest);
            companyResponseExpected.CompanyId = companyResponseFromAdd.CompanyId;

            //Assert
            companyResponseFromAdd.CompanyId.Should().NotBe(Guid.Empty);
            companyResponseFromAdd.Should().Be(companyResponseExpected);
        }

        #endregion

        #region DeleteCompany

        [TestMethod]
        public async Task DeleteCompany_InvalidCompanyId_ShouldReturnFalse()
        {
            //Act
            bool isDeleted = await _companyDeleterService.DeleteCompany(Guid.Empty);

            //Assert
            isDeleted.Should().BeFalse();
        }

        [TestMethod]
        public async Task DeleteCompany_ValidCompanyId_ToBeSuccessful()
        {
            //Arrange
            Company company = _fixture.Build<Company>().With(c => c.Employees, null as ICollection<Employee>).Create();

            _companyRepositoryMock.Setup(c => c.GetCompanyById(It.IsAny<Guid>())).ReturnsAsync(company);
            _companyRepositoryMock.Setup(c => c.DeleteCompany(It.IsAny<Guid>())).ReturnsAsync(true);

            //Act
            bool isDeleted = await _companyDeleterService.DeleteCompany(company.CompanyId);

            //Assert
            isDeleted.Should().BeTrue();
        }

        #endregion

        #region GetCompanies

        [TestMethod]
        public async Task GetCompanies_EmptyList()
        {
            //Arrange
            List<Company> companies = new List<Company>();

            _companyRepositoryMock.Setup(c => c.GetCompanies()).ReturnsAsync(companies);

            //Act
            List<CompanyResponse> companiesResponsesActual = await _companyGetterService.GetCompanies();

            //Assert
            companiesResponsesActual.Should().BeEmpty();
        }

        [TestMethod]
        public async Task GetCompanies_ToBeSuccessful()
        { 
            //Arrange
            List<Company> companies = _fixture.Build<Company>().With(c => c.Employees, null as ICollection<Employee>).CreateMany().ToList();
            List<CompanyResponse> companyResponsesExpected = companies.Select(c => c.ToCompanyResponse()).ToList();

            _companyRepositoryMock.Setup(c => c.GetCompanies()).ReturnsAsync(companies);

            //Act
            List<CompanyResponse> companiesResponsesActual = await _companyGetterService.GetCompanies();

            //Assert
            companiesResponsesActual.Should().BeEquivalentTo(companyResponsesExpected);
        }

        #endregion

        #region GetCompanyById

        [TestMethod]
        public async Task GetCompanyById_CompanyIsNull_ReturnNull()
        {
            //Arrange
            Company company = null;

            _companyRepositoryMock.Setup(c => c.GetCompanyById(It.IsAny<Guid>())).ReturnsAsync(company);

            //Act
            CompanyResponse companyResponseActual = await _companyGetterService.GetCompanyById(Guid.NewGuid());

            //Assert
            companyResponseActual.Should().BeNull();
        }

        [TestMethod]
        public async Task GetCompanyById_ValidData_ToBeSuccessfull()
        {
            //Arrange
            Company company = _fixture.Build<Company>().With(c => c.Employees, null as ICollection<Employee>).Create();
            CompanyResponse companyResponseExpected = company.ToCompanyResponse();

            _companyRepositoryMock.Setup(c => c.GetCompanyById(It.IsAny<Guid>())).ReturnsAsync(company);

            //Act
            CompanyResponse companyResponseActual = await _companyGetterService.GetCompanyById(Guid.NewGuid());

            //Assert
            companyResponseActual.Should().Be(companyResponseExpected);
        }

        #endregion

        #region UpdateCompany

        [TestMethod]
        public async Task UpdateCompany_CompanyUpdateRequestIsNull_ThrowArgumentNullException()
        {
            //Arrange
            CompanyUpdateRequest companyUpdateRequest = null;

            //Act
            Func<Task> action = async () => await _companyUpdaterService.UpdateCompany(companyUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [TestMethod]
        public async Task Update_CompanyNameIsEmpty_ThrowArgumentException()
        {
            //Arrange
            CompanyUpdateRequest companyUpdateRequest = _fixture.Build<CompanyUpdateRequest>()
                .With(c => c.CompanyName, String.Empty).Create();
            Company company = companyUpdateRequest.ToCompany();

            _companyRepositoryMock.Setup(s => s.AddCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            Func<Task> action = async () => await _companyUpdaterService.UpdateCompany(companyUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task UpdateCompany_BINIsEmpty_ThrowArgumentException()
        {
            //Arrange
            CompanyUpdateRequest companyUpdateRequest = _fixture.Build<CompanyUpdateRequest>()
                .With(c => c.BIN, String.Empty).Create();
            Company company = companyUpdateRequest.ToCompany();

            _companyRepositoryMock.Setup(s => s.AddCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            Func<Task> action = async () => await _companyUpdaterService.UpdateCompany(companyUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task Update_AddressIsEmpty_ThrowArgumentException()
        {
            //Arrange
            CompanyUpdateRequest companyUpdateRequest = _fixture.Build<CompanyUpdateRequest>()
                .With(c => c.Address, String.Empty).Create();
            Company company = companyUpdateRequest.ToCompany();

            _companyRepositoryMock.Setup(s => s.AddCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            Func<Task> action = async () => await _companyUpdaterService.UpdateCompany(companyUpdateRequest);

            //Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [TestMethod]
        public async Task UpdateCompany_ValidData_ToBeSuccessful()
        {
            //Arrange
            CompanyUpdateRequest companyUpdateRequest = _fixture.Create<CompanyUpdateRequest>();
            Company company = companyUpdateRequest.ToCompany();
            CompanyResponse companyResponseExpected = company.ToCompanyResponse();

            _companyRepositoryMock.Setup(c => c.GetCompanyById(It.IsAny<Guid>())).ReturnsAsync(company);
            _companyRepositoryMock.Setup(s => s.UpdateCompany(It.IsAny<Company>())).ReturnsAsync(company);

            //Act
            CompanyResponse companyResponseFromAdd = await _companyUpdaterService.UpdateCompany(companyUpdateRequest);
            companyResponseExpected.CompanyId = companyResponseFromAdd.CompanyId;

            //Assert
            companyResponseFromAdd.CompanyId.Should().NotBe(Guid.Empty);
            companyResponseFromAdd.Should().Be(companyResponseExpected);
        }


        #endregion
    }
}
