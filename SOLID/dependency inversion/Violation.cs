using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internal;

namespace DependencyInversion_Violation
{
    public class UserRepository
    {
        public void AddUser()
        {
            Console.WriteLine("User addedd to database");
        }
    }

    public class UserService
    {
        private UserRepository _repo;

        public UserService(UserRepository repo)
        {
            _repo = repo;
        }

        void AddUser()
        {
            _repo.AddUser();
        }
    }
}