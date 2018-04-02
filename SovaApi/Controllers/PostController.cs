using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DomainModels;
using Logics;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<Post> GetAllPosts()
        {
            var posts = postservice.GetAllPost();


            return mapper.Map<List<Post>>(posts);
        }
       

        }
    }
