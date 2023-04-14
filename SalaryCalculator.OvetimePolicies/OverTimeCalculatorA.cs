namespace SalaryCalculator.OvertimePolicies
{
    public class OverTimeCalculatorA : ICalculatorSelector
    {
        public OverTimeCalculatorEnum OverTimeCalculatorEnum { get; set; } = OverTimeCalculatorEnum.OverTimeCalculatorA;

        public decimal MethodInvoke()
        {
            return Calculators.OverTimeCalculatorA();
        }


    }
}