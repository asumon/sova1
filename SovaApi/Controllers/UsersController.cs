using AutoMapper;
using DataAccess;
using DomainModels;
using Logics.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SovaApi.Controllers
{
    public class UsersController : Controller
    {
        public IUserServices UserServices;
        public IMapper mapper;


        public UsersController(IUserServices UserServices, IMapper mapper)
        {
            this.UserServices = UserServices;
            this.mapper = mapper;
        }

        [HttpGet("/api/allusers")]
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var users = await UserServices.GetAllUser().ToListAsync();
            return  mapper.Map<List<User>>(users);
        }


    }
}
