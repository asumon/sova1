using DomainModels;
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

        public DbSet<Posttype> posttypes { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posttype>().ToTable("posttype");
            modelBuilder.Entity<Posttype>().Property(x => x.Id).HasColumnName("posttypeid");
            modelBuilder.Entity<Posttype>().Property(x => x.Name).HasColumnName("posttype");


            modelBuilder.Entity<Post>().ToTable("posts");
            

        }
    }

    
}
