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
        public bool Delete(int id)
        {
            int result = 0;
            SalaryDetails? salaryDetails = salaryDbContext.SalaryDetails.FirstOrDefault(s => s.Id == id);
            if (salaryDetails != null)
            {
                salaryDbContext.Remove(salaryDetails);
                result = salaryDbContext.SaveChanges();

            }
            return result > 0;
        }
        public int Update(SalaryDetails salaryDetails)
        {
            salaryDbContext.SalaryDetails.Update(salaryDetails);
            return salaryDbContext.SaveChanges();
        }

    }
}
