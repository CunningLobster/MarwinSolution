using Marwin.Core.Domain.Entities;
using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Core.DTO;
using Marwin.Core.Helpers;
using Marwin.Core.ServiceContracts.CompanyServiceContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.Services
{
    public class CompanyService : ICompanyGetterService, ICompanyUpdaterService, ICompanyAdderService, ICompanyDeleterService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository) 
        {
            _companyRepository = companyRepository;
        }

        public async Task<CompanyResponse> AddCompany(CompanyAddRequest companyAddRequest)
        {
            if(companyAddRequest == null)
                throw new ArgumentNullException(nameof(companyAddRequest));

            //Валидация объекта
            ValidationHelper.ModelValidation(companyAddRequest);

            //Сохранение компании в БД
            Company company = companyAddRequest.ToCompany();
            company.CompanyId = Guid.NewGuid();
            await _companyRepository.AddCompany(company);

            return company.ToCompanyResponse();
        }

        public async Task<bool> DeleteCompany(Guid companyId)
        {
            if(companyId == null)
                throw new ArgumentNullException(nameof(companyId));

            Company companyToDelete = await _companyRepository.GetCompanyById(companyId);
            if(companyToDelete == null)
                return false;

            await _companyRepository.DeleteCompany(companyId);
            return true;
        }

        public async Task<List<CompanyResponse>> GetCompanies()
        {
            List<Company> companies = await _companyRepository.GetCompanies();
            return companies.Select(c => c.ToCompanyResponse()).ToList();
        }

        public async Task<CompanyResponse> GetCompanyById(Guid companyId)
        {
            if (companyId == null)
                throw new ArgumentNullException(nameof(companyId));

            Company company = await _companyRepository.GetCompanyById(companyId);
            if(company == null)
                return null;

            return company.ToCompanyResponse();
        }

        public async Task<CompanyResponse> UpdateCompany(CompanyUpdateRequest companyUpdateRequest)
        {

            if (companyUpdateRequest == null)
                throw new ArgumentNullException(nameof(companyUpdateRequest));

            //Валидация объекта
            ValidationHelper.ModelValidation(companyUpdateRequest);

            Company matchingCompany = await _companyRepository.GetCompanyById(companyUpdateRequest.CompanyId);

            if (matchingCompany == null)
                throw new ArgumentException($"Company with id: {companyUpdateRequest.CompanyId} doesn't exist");

            //Обновление компании
            matchingCompany.CompanyName = companyUpdateRequest.CompanyName;
            matchingCompany.BIN = companyUpdateRequest.BIN;
            matchingCompany.Address = companyUpdateRequest.Address;
            matchingCompany.Note = companyUpdateRequest.Note;
            await _companyRepository.UpdateCompany(matchingCompany);

            return matchingCompany.ToCompanyResponse();
        }
    }
}
