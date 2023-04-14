using SalaryCalculator.Contract.Dtos;
using System.Xml.Serialization;

namespace SalaryCalculator.UI.Convertors
{
    public class XmlConverter : BaseConverter
    {
        public override MonthlySalaryDto Convert(string value)
        {
            MonthlySalaryDto salaryDto;
            TextReader reader = new StreamReader(value);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MonthlySalaryDto));
            salaryDto = (MonthlySalaryDto)xmlSerializer.Deserialize(reader);
            return salaryDto;
        }
    }
}
