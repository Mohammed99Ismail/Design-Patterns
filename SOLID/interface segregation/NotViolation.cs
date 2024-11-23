using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internal;

namespace InterfaceSegregation
{
    public interface IUserService
    {
        void AddUser();
    }

    public interface INotificationService
    {
        void SendNotification();
    }

    public class UserService : IUserService
    {
        void AddUser()
        {
            Console.WriteLine("User Added");
        }
    }
}