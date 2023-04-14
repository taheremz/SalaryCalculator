using Newtonsoft.Json;
using SalaryCalculator.Contract.Dtos;

namespace SalaryCalculator.UI.Convertors
{
    public class JsonConverter : BaseConverter
    {
        public override MonthlySalaryDto Convert(string value)
        {
            return JsonConvert.DeserializeObject<MonthlySalaryDto>(value);
        }
    }
}
