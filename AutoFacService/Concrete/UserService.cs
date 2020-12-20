using AutoFacService.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFacService.Concrete
{
    public class UserService : IUserService
    {
        public IEnumerable<User> GetAll()
        {
            List<User> users = new List<User>();
            users.Add(new User { Name = "Gökhan", Surname = "Alkan" });
            users.Add(new User { Name = "Sedat", Surname = "Alkan" });

            return users;
        }
    }
}
