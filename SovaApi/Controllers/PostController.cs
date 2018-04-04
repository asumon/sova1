using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess;
using DomainModels;
using Logics;
using Logics.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SovaApi.Controllers
{
    public class PostController : Controller
    {
        public IPostService postservice;
        public IMapper mapper { get; set; }
        public ICommentsService commentsService; 

        public PostController(IPostService service, IMapper mapper , ICommentsService commentsService)
        {
            this.postservice = service;
            this.mapper = mapper;
            this.commentsService = commentsService;
        }

        [HttpGet("/api/allposts")]
        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            var posts = await postservice.GetAllPost().ToListAsync();


            return mapper.Map<List<Post>>(posts); 
               
        }

        [HttpGet("/api/post/{id}")]
        public  async Task<IEnumerable<Comments>> GetCommentsForPost(int id){

            var comments = await commentsService.GetAllCommentsForPost(id).ToListAsync();
            return mapper.Map<List<Comments>>(comments);
            
        }

        [HttpGet("api/posts/{userid}")]
        public async Task<IEnumerable<Post>> GetAllPostForUser(int userid)
        {

            var postForUsers = await postservice.GetAllPostForUser(userid).ToListAsync();

            return mapper.Map<List<Post>>(postForUsers);

        }
        

       

        }
    }
