using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logics.Interfaces
{
    public interface IUserServices
    {
        IEnumerable<User> GetAllUser();
       
    }
}
