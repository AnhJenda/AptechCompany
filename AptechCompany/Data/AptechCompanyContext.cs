using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AptechCompany.Models;

namespace AptechCompany.Data
{
    public class AptechCompanyContext : DbContext
    {
        public AptechCompanyContext (DbContextOptions<AptechCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<AptechCompany.Models.Employee> Employee { get; set; } = default!;
    }
}
