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
            var posts = context.Posts.Where(x => x.PosttypeId == 1).Include(x => x.User);

            return posts;
        }

        IQueryable<Post> IPostService.GetAllPostForUser(int userid)
        {
            var postForUsers = context.Posts.Where(x => x.UserId == userid);
            return postForUsers;
        }

        public IQueryable<Post> GetAllAnswerForPost(int postid)
        {
            var answersForPost = context.Posts.Where(x => x.PosttypeId == 2 && x.ParentId == postid)
               
                .Include(x=>x.Comments);
            return answersForPost;
        }

        public IEnumerable<Post> GetPostById(int id)
        {
            var post = context.Posts.Where(x =>x.Id == id).Include(x => x.User)
                .Include(x=>x.Comments).ThenInclude(u=> u.Users);
            return post;
        }


    }
}
