﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;
using Logics;
using Logics.Interfaces;

namespace SovaDataBase
{
    public class CommentService : ICommentsService

    {
        public SovaDbContext DbContext;

        public CommentService(SovaDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        //public IQueryable<Comments> GetAllCommentsForPost(int postId)
        //{
        //    return DbContext.Comments.Where(pid => pid.PostId==postId);

            
        // }



}
}
