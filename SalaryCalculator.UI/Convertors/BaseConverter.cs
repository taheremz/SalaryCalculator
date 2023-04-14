using SalaryCalculator.Contract.Dtos;

namespace SalaryCalculator.UI.Convertors
{
    public abstract class BaseConverter
    {
        public abstract MonthlySalaryDto Convert(string value);
    }
}
