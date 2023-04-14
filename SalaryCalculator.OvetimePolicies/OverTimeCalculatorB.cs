namespace SalaryCalculator.OvertimePolicies
{
    public class OverTimeCalculatorB : ICalculatorSelector
    {
        public OverTimeCalculatorEnum OverTimeCalculatorEnum { get; set; } = OverTimeCalculatorEnum.OverTimeCalculatorB;

        public decimal MethodInvoke()
        {
            return Calculators.OverTimeCalculatorB();
        }

    }
}