using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Salary
    {
        public abstract double TotalSalary { get; }
        public double BasicSalary { get; set; }
    }
}
