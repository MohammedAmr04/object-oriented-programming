using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    internal class SalariedEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public int Housing { get; set; }
        public int Transportation { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] 
            {
                new PayItem("Basic Salary",BasicSalary),
                new PayItem("Transportation",Transportation),
                new PayItem("Housing",Housing),
            };
        }

        public override decimal GetSalary()
        {
            return BasicSalary + Transportation + Housing;
        }
        public decimal GetSalary(int bonus) 
        {
            return GetSalary() + bonus; 
        }

    }
}
