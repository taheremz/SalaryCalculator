namespace SalaryCalculator.OvertimePolicies
{
    public class OverTimeCalculatorC :ICalculatorSelector
    {
        public OverTimeCalculatorEnum OverTimeCalculatorEnum { get; set; } = OverTimeCalculatorEnum.OverTimeCalculatorC;

        public decimal MethodInvoke()
        {
            return Calculators.OverTimeCalculatorC();
        }
    }
}