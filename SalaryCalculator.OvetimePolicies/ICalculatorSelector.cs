namespace SalaryCalculator.OvertimePolicies
{
    public interface ICalculatorSelector
    {
        public OverTimeCalculatorEnum OverTimeCalculatorEnum { get; protected set; }
        decimal MethodInvoke();
    }

}
