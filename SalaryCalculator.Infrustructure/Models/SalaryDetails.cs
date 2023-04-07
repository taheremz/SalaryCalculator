using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Infrustructure.Models
{
    public class SalaryDetails
    {
        public int PersonId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }

    }
}
