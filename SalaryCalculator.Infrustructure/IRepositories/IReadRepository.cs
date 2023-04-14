using SalaryCalculator.Infrustructure.Models;

namespace SalaryCalculator.Infrustructure.IRepositories
{
    public interface IReadRepository
    {
        IEnumerable<SalaryDetails> GetAll();
        IEnumerable<SalaryDetails> GetByDate(DateTime? fromDate, DateTime? toDate);

    }
}
