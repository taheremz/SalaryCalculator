using SalaryCalculator.UI.Enums;
using System.ComponentModel;

namespace SalaryCalculator.UI.Convertors
{
    public class ConvertFactory
    {
        public BaseConverter GetConvertorInstance(InputDataType inputDataType)
        {
            if (inputDataType == InputDataType.Json)
                return new JsonConverter();

            if (inputDataType == InputDataType.Xml)
                return new XmlConverter();

            if (inputDataType == InputDataType.Custom)
                return new CustomConverter();

            throw new InvalidEnumArgumentException(nameof(inputDataType));
        }
    }
}
