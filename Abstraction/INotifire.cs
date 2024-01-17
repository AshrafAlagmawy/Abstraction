using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal interface INotifire
    {
        void Notify(string email, string subject, string body);
    }
}
