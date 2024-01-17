using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class PaySlipGenerator
    {
        private readonly INotifire _notifire;
        public PaySlipGenerator(INotifire notifire)
        {
            _notifire = notifire;
        }
        public void Generate(Employee employee)
        {
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FirstName} {employee.LastName}, ");
            message.AppendLine($"Please find below your payslip details : ");
            foreach (var payItem in payItems)
                message.AppendLine($"{payItem.Name}\t\t{payItem.Value}");

            _notifire.Notify(employee.Email, "PaySlip Generated !", message.ToString()); 
        }
    }
}
