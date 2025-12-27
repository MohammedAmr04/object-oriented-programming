using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    // Interface defines a contract without implementation.
    // Used to decouple the notification mechanism from its usage.
    internal interface INotifier
    {
        void Notify(string subject,string message);
    }
}
