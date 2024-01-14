using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class SalariedEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal Housing { get; set; }
        public decimal Transportation { get; set; }
        public override decimal GetSalary()
        {
            //throw new NotImplementedException();
            Console.ForegroundColor = ConsoleColor.Green;
            return BasicSalary + Transportation + Housing;
        }
        public decimal GetSalary(int taxPercentage)
        {
            return GetSalary() - (BasicSalary * taxPercentage / 100);
        }
        public decimal GetSalary(int taxPercentage, decimal bonus)
        {
            //return GetSalary() - (BasicSalary * taxPercentage / 100) + bonus;
            return GetSalary(taxPercentage) + bonus;
        }
        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[]
            {
                new PayItem("Basic Salary : ",BasicSalary),
                new PayItem("Transportation : ",Transportation),
                new PayItem("Housing : ",Housing)
            };
        }
    }
}
