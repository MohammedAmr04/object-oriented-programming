using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    internal class InternEmployee :Employee
    {
        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Basic Salary", GetSalary())};
        }

        public override decimal GetSalary()
        {
            return 2000;
        }
    }
}
