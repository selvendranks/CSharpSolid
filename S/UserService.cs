using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    public class UserService
    {
        public void Register(User user)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email);
        }
    }
}
