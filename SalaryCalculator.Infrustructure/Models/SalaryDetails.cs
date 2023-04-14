namespace SalaryCalculator.Infrustructure.Models
{
    public class SalaryDetails
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public decimal MonthlySalary { get; set; }
        public int Date { get; set; }

    }
}
