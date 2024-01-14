using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class PayItem
    {
        public decimal Value { get; }
        public string Name { get; }
        public PayItem(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
    }
}
