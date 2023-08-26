using Marwin.Core.Domain.Entities;
using Marwin.Core.Domain.RepositoryContracts;
using Marwin.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Infrastructure.Repositories
{
    public class CompaniesRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompaniesRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Company> AddCompany(Company company)
        {
            _db.Companies.Add(company);
            await _db.SaveChangesAsync();
            return company;
        }

        public async Task<bool> DeleteCompany(Guid companyId)
        {
            Company companyToDelete = _db.Companies.FirstOrDefault(x => x.CompanyId == companyId);
            if (companyToDelete != null) 
            {
                _db.Companies.Remove(companyToDelete);
                await _db.SaveChangesAsync();
                return true;
            }
            else
              return false;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _db.Companies.ToListAsync();
        }

        public async Task<Company> GetCompanyById(Guid companyId)
        {
            return await _db.Companies.FirstOrDefaultAsync(c => c.CompanyId == companyId);
        }

        public async Task<Company> UpdateCompany(Company company)
        {
            Company companyToUpdate = await _db.Companies.FirstOrDefaultAsync(c => c.CompanyId == company.CompanyId);

            if (companyToUpdate == null)
                return companyToUpdate;

            companyToUpdate.CompanyName = company.CompanyName;
            companyToUpdate.BIN = company.BIN;
            companyToUpdate.Address = company.Address;
            companyToUpdate.Note = company.Note;
            await _db.SaveChangesAsync();

            return companyToUpdate;
        }
    }
}
