using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Marwin.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public ApplicationDbContext() : base("name=DefaultConnectionString")
        {
            Database.SetInitializer(new MarwinDBInitializer());
        } 
    }
}
