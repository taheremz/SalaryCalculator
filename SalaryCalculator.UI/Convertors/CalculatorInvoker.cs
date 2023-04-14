using SalaryCalculator.OvertimePolicies;

namespace SalaryCalculator.UI.Convertors
{
    public class CalculatorInvoker : ICalculatorInvoker
    {
        private readonly IEnumerable<ICalculatorSelector> calculatorSelector;

        public CalculatorInvoker(IEnumerable<ICalculatorSelector> calculatorSelector)
        {
            this.calculatorSelector = calculatorSelector;
        }

        public decimal SelectMethod(string selector)
        {
            if (!Enum.GetNames<OverTimeCalculatorEnum>().Contains(selector))
                return 0;

            int value = (int)Enum.Parse(typeof(OverTimeCalculatorEnum), selector);
            var OverTimeCalculatorName = calculatorSelector.FirstOrDefault(x => x.OverTimeCalculatorEnum == (OverTimeCalculatorEnum)value);
            decimal overTime = OverTimeCalculatorName.MethodInvoke();
            return overTime;

        }
    }
}
