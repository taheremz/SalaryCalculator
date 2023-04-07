using SalaryCalculator.Infrustructure.Contexts;
using SalaryCalculator.Infrustructure.IRepositories;
using SalaryCalculator.Infrustructure.Models;

namespace SalaryCalculator.Infrustructure.Repositories
{
    public class WriteRepository : IWriteRepository
    {
        private readonly SalaryDbContext salaryDbContext;

        public WriteRepository(SalaryDbContext salaryDbContext)
        {
            this.salaryDbContext = salaryDbContext;
        }
        public int Add(SalaryDetails salaryDetails)
        {
            salaryDbContext.SalaryDetails.Add(salaryDetails);
            return salaryDbContext.SaveChanges();
        }

    }
}
