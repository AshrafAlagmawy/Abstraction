using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Notifire : INotifire
    {
        public string SmtpServer { get; }
        public int Port { get; }
        public string SenderAddress { get; }
        public string SenderPassword { get; }
        public Notifire(string smtpServer, int port, string senderAddress, string senderPassword)
        {
            SmtpServer = smtpServer;
            Port = port;
            SenderAddress = senderAddress;
            SenderPassword = senderPassword;
        }
        public void Notify(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You've a new email from `{SenderAddress}` with subject `{subject}`");
            Console.WriteLine(body);
            Console.WriteLine($"Message Sent Successfully to `{email}`");
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
