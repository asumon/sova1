using AutoMapper;
using DataAccess;
using DomainModels;
using Logics.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IEnumerable<User> GetAllUsers()
        {
            var users = UserServices.GetAllUser();
            return mapper.Map<List<User>>(users);
        }
    }
}
