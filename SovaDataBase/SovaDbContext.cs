﻿using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovaDataBase
{
    public class SovaDbContext : DbContext
    {
        public SovaDbContext(DbContextOptions<SovaDbContext> options)
            : base(options)
        {

            

        }

        public DbSet<Posttype> PostType { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comments> Comments { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posttype>().ToTable("posttype");
            modelBuilder.Entity<Posttype>().Property(x => x.Id).HasColumnName("posttypeid");
            modelBuilder.Entity<Posttype>().Property(x => x.Name).HasColumnName("posttype");
           
            


            modelBuilder.Entity<Post>().ToTable("posts");
            modelBuilder.Entity<Post>().Property(x => x.CloseDate).HasColumnName("closedate");
            modelBuilder.Entity<Post>().Property(x => x.Id).HasColumnName("postid");
            modelBuilder.Entity<Post>().Property(x => x.ParentId).HasColumnName("parentid");
            modelBuilder.Entity<Post>().Property(x => x.AcceptedanswerId).HasColumnName("acceptedanswerid");
            modelBuilder.Entity<Post>().Property(x => x.PosttypeId).HasColumnName("post_type_id");
            modelBuilder.Entity<Post>().Property(x => x.UserId).HasColumnName("user_id");
            modelBuilder.Entity<Post>().HasOne(u => u.User).WithMany(p => p.Posts).HasForeignKey(u => u.UserId);

            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().Property(x => x.Id).HasColumnName("userid");
            modelBuilder.Entity<User>().Property(x => x.Location).HasColumnName("userlocation");
            modelBuilder.Entity<User>().Property(x => x.Name).HasColumnName("username");


            modelBuilder.Entity<Comments>().ToTable("comments");
            modelBuilder.Entity<Comments>().Property(x => x.Id).HasColumnName("commentid");
            modelBuilder.Entity<Comments>().Property(x => x.PostId).HasColumnName("postid");
            modelBuilder.Entity<Comments>().Property(x => x.Commentscore).HasColumnName("commentscore");
            modelBuilder.Entity<Comments>().Property(x => x.UserId).HasColumnName("userid");
            modelBuilder.Entity<Comments>().Property(x => x.CommentDate).HasColumnName("commentcreatedate");

           
            


            

        }
    }

    
}
