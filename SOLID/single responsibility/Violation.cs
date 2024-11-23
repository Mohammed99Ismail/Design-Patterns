using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internal;

namespace SingleResponsibility_Violation
{
    public class UserManagement
    {
        public void AddUser()
        {
            Console.WriteLine("User Added");
        }

        public void SendNotification()
        {
            Console.WriteLine("Notification Sent");
        }
    }
}