using DomainModels;
using Logics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovaDataBase
{
     public class PostService : IPostService
    {
        public SovaDbContext context { get; set; }

        public PostService(SovaDbContext context)
        {
            this.context = context;
        }

        IEnumerable<Post> IPostService.GetAllPost()
        {
            var posts = context.Posts;
            return posts;
        }
    }
}
