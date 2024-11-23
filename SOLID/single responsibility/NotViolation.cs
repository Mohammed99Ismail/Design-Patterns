using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internal;

namespace SingleResponsibility
{
    public class NotificationManagement
    {
        public void SendNotification()
        {
            Console.WriteLine("Notification Sent");
        }
    }

    public class UserManagement
    {
        public void AddUser()
        {
            Console.WriteLine("User Added");
        }
    }
}