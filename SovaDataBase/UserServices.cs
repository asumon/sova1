using DomainModels;
using Logics.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SovaDataBase
{
    public class UserServices : IUserServices
    {
        public SovaDbContext context;

        public UserServices(SovaDbContext dbContext)
        {
            this.context = dbContext;
        }
        public IQueryable<User> GetAllUser()
        {
            var users = context.Users;

            return users;
        }

        public IEnumerable<User> GetUserById(int id)
        {
            var userById = context.Users.Where(x => x.Id == id);
            return userById;
        }
    }
}
