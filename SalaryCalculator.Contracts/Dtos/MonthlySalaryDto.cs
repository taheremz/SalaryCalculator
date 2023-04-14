using System;

namespace SalaryCalculator.Contract.Dtos
{
    public class MonthlySalaryDto

    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Transportation { get; set; }
        public decimal MonthlySalary { get; set; }
        public DateTime Date { get; set; }
    }
}
