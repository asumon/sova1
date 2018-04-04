using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logics
{
    public interface IPostService
    {
        IQueryable<Post> GetAllPost();
        IQueryable<Post> GetAllPostForUser(int userid);
    }

    
}
