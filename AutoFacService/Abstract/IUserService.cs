using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFacService.Abstract
{
   public interface IUserService
    {
        IEnumerable<User> GetAll();
    }
}
