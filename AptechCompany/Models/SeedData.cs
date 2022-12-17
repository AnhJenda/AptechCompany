using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AptechCompany.Data;
using System;
using System.Linq;
using NuGet.Versioning;
namespace AptechCompany.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AptechCompanyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AptechCompanyContext>>()))
            {
                
                if (context.Employee.Any())
                {
                    /*return; */  // DB has been seeded
                }
                var Employees = new Employee[]
                {
                    new Employee { Id = "Em001", Name = "Jonh Carter", Department = "HR", Salary = 3000},
                    new Employee { Id = "Em002", Name = "Michael Bean", Department = "SC", Salary = 1300},
                    new Employee { Id = "Em003", Name = "Jimmy Floy", Department = "MD", Salary = 2000},
                    new Employee { Id = "Em004", Name = "Mary Brown", Department = "MD", Salary = 2000}
                };
                foreach (Employee e in Employees)
                {
                    context.Employee.Add(e);
                }
                context.SaveChanges();
            }
        }
    }
}
