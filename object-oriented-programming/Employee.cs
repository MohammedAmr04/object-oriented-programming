using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    internal abstract class Employee:Person
    {

        public int TaxPercentage { get; set; }
        public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();

    }
}
