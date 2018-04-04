using DomainModels;
using Logics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SovaDataBase
{
    //implementation for IPostService
    public class PostService : IPostService
    {
        public SovaDbContext context { get; set; }

        public PostService(SovaDbContext context)
        {
            this.context = context;
        }

        IQueryable<Post> IPostService.GetAllPost()
        {
            var posts = context.Posts.Take(10).Include(x => x.User);

            return posts;
        }

        IQueryable<Post> IPostService.GetAllPostForUser(int userid)
        {
            var postForUsers = context.Posts.Where(x => x.UserId == userid);
            return postForUsers;
        }


    }
}
