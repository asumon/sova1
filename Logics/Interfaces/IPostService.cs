using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPost();
    }
}
