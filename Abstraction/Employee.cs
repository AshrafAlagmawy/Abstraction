using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Employee
    {
        public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();
    }
}
