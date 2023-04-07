using SalaryCalculator.UI.Dtos;

namespace SalaryCalculator.Contract.IServices
{
    public interface ISalaryService
    {
        public void Add();
        public void Delete();
        public void Update(); 
        List<MonthlySalaryDto> Get();
        MonthlySalaryDto GetById(int id);
    }
}
