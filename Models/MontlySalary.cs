using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MontlySalary : Salary
    {
        public MontlySalary(double salary)
        {
            BasicSalary = salary;
        }

        public override double TotalSalary
        {
            get
            {
                return (BasicSalary * 12);
            }
        }
    }
}
