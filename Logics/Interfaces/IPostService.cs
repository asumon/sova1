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
        IEnumerable<Post> GetAllPostForUser(int userid);
        IQueryable<Post> GetAllAnswerForPost(int postid);
        IEnumerable<Post> GetPostById(int postid);
    }

    
}
