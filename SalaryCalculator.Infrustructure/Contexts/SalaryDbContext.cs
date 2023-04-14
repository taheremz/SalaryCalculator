using Microsoft.EntityFrameworkCore;
using SalaryCalculator.Infrustructure.Models;

namespace SalaryCalculator.Infrustructure.Contexts
{
    public class SalaryDbContext : DbContext
    {
        public SalaryDbContext(DbContextOptions<SalaryDbContext> options) : base(options) { }
        
        public DbSet<Person> Person { get; set; }
        public DbSet<SalaryDetails> SalaryDetails { get; set; }
    }
}
