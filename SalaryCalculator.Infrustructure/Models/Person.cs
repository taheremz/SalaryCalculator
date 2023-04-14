namespace SalaryCalculator.Infrustructure.Models
{
    public class Person
    {
        public Person()
        {
            SalaryDetails = new HashSet<SalaryDetails>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int NationalCode { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Transportation { get; set; }
        public ICollection<SalaryDetails> SalaryDetails { get; set; }
    }
}
