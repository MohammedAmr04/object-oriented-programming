using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    internal class HourlyEmployee : Employee
    {
        public int HourRate { get; set; } 
        public int TotalWorkingHours { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Total Hours", GetSalary()) };
        }

        public override decimal GetSalary()
        {
            return HourRate * TotalWorkingHours;
        }
    }
}
