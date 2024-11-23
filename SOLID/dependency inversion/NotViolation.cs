using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internal;

namespace DependencyInversion
{
    public class IUserRepository
    {
        public void AddUser();
    }

    public class UserRepository : IUserRepository
    {
        public void AddUser()
        {
            Console.WriteLine("User addedd to database");
        }
    }

    public class UserService
    {
        private IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        void AddUser()
        {
            _repo.AddUser();
        }
    }
}