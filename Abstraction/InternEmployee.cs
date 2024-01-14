using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class InternEmployee : Employee
    {
        public override decimal GetSalary()
        {
            //throw new NotImplementedException();
            Console.ForegroundColor = ConsoleColor.Blue;
            return 2000;
        }
        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Basic Salary : ", 2000) };
        }
    }
}
