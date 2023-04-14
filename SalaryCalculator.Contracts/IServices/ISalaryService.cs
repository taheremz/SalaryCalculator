using SalaryCalculator.Contract.Dtos;

namespace SalaryCalculator.Contract.IServices
{
    public interface ISalaryService
    {
        public bool Add(MonthlySalaryDto dto, decimal OverTime);
        public bool Delete(int id);
        public bool Update(MonthlySalaryDto dto); 
        List<MonthlySalaryDto> Get();
        List<MonthlySalaryDto> GetByDate(DateTime? fromDate, DateTime? toDate);
    }
}
