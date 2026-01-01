using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    // PayslipGenerator uses abstraction to remain independent
    // from how notifications are actually sent.

    internal class PayslipGenerator
    {
        // Dependency Injection:
        // Depends on abstraction (INotifier), not concrete implementation.

        private readonly INotifier _notifier;
        public PayslipGenerator(INotifier notifier) {
        _notifier = notifier;
        }

        public void Generate(Employee employee)
        {
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FirstName} {employee.LastName}");
            foreach (var item in payItems) { 
                message.AppendLine($"{item.Name} => {item.Value}");
            }
            _notifier.Notify("Payslib Generated",message.ToString());
        }
    }
}
