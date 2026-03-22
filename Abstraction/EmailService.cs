using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();
            
        }

        private void Connect()
        {
            Console.WriteLine("Connecting to email service");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticate User");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting User");
        }
    }
}
