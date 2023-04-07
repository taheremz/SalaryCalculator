using Microsoft.EntityFrameworkCore;
using SalaryCalculator.Infrustructure.Models;

namespace SalaryCalculator.Infrustructure.Contexts
{
    public class SalaryDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public DbSet<SalaryDetails> SalaryDetails { get; set; }
    }
}
