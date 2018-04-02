using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess;
using DomainModels;
using Logics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SovaApi.Controllers
{
    public class PostController : Controller
    {
        public IPostService postservice;
        public IMapper mapper { get; set; }

        public PostController(IPostService service, IMapper mapper)
        {
            this.postservice = service;
            this.mapper = mapper;
        }

        [HttpGet("/api/allposts")]
        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            var posts = await postservice.GetAllPost().ToListAsync();


            return mapper.Map<List<Post>>(posts); 
               
        }
       

        }
    }
