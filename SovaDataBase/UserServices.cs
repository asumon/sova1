using DomainModels;
using Logics.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovaDataBase
{
    public class UserServices : IUserServices
    {
        public SovaDbContext context;

        public UserServices(SovaDbContext dbContext)
        {
            this.context = dbContext;
        }
        public IEnumerable<User> GetAllUser()
        {
            var users = context.Users;

            return users;
        }
    }
}
