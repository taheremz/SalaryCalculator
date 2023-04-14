using Newtonsoft.Json;
using SalaryCalculator.Contract.Dtos;
using System.Text;

namespace SalaryCalculator.UI.Convertors
{
    public class CustomConverter : BaseConverter
    {
        public override MonthlySalaryDto Convert(string value)
        {
            string[] s = value.Split("Line2:");
            string lineOne = s[0].Substring(6).Trim();
            string lineTwo = s[1].Trim();
            string[] fields = lineOne.Split("/");
            string[] values = lineTwo.Split("/");
            StringBuilder json = new StringBuilder("{");
            for (int i = 0; i < fields.Length; i++)
            {
                json.Append("\"");
                json.Append(fields[i]);
                json.Append("\" : \"");
                json.Append(values[i]);
                json.Append("\"");
                if (i < fields.Length - 1)
                    json.Append(",");
            }
            json.Append("}");

            return JsonConvert.DeserializeObject<MonthlySalaryDto>(json.ToString());
        }
    }
}
