using SalaryCalculator.Infrustructure.Models;

namespace SalaryCalculator.Infrustructure.IRepositories
{
    public interface IWriteRepository
    {
        int Add(SalaryDetails salaryDetails);
        int Update(SalaryDetails salaryDetails);
        bool Delete(int id);
    }
}
