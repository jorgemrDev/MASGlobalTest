using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class HourSalary : Salary
    {
        public HourSalary(double salary)
        {
            BasicSalary = salary;
        }
        public override double TotalSalary
        {
            get
            {
                return (120 * BasicSalary * 12);
            }
        }
    }
}