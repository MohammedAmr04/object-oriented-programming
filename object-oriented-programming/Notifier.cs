using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    internal class Notifier: INotifier
    {
        public void Notify(string subject, string message)
        {
            Console.WriteLine(subject);
            Console.WriteLine(message);
        }

    }
}
