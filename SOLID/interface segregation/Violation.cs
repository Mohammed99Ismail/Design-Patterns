using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregation_Violation
{
    public interface IUserService
    {
        void AddUser();
        void SendNotification();
    }

    public class UserService : IUserService
    {
        void AddUser()
        {
            Console.WriteLine("User Added");
        }

        void SendNotification()
        {
        }
    }
}