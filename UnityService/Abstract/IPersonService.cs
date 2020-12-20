using System;
using System.Collections.Generic;
using System.Text;

namespace UnityService.Abstract
{
   public interface IPersonService
    {
        IEnumerable<Person> GetAll();
    }
}
