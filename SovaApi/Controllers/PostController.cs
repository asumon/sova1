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
using SovaApi.Models;

namespace SovaApi.Controllers
{
    [Route("api/posts")]
    public class PostController : Controller
    {
        public IPostService postservice;
        public IMapper mapper { get; set; }
        public ICommentsService commentsService;

        public PostController(IPostService service, IMapper mapper, ICommentsService commentsService)
        {
            this.postservice = service;
            this.mapper = mapper;
            this.commentsService = commentsService;
        }

        [HttpGet]
        public IActionResult GetAllPosts()
        {
            var posts = postservice.GetAllPost().ToList();

            //var z = mapper.Map<List<Post>>(posts);

            var result = posts.Select(
                x => {
                var postListModel = new PostListModel { Title = x.Title };
               
                    postListModel.Url = Url.Link(nameof(GetPostById), new { x.Id });

                    return postListModel;
                });
                 
                  
            return Ok(result);

        }
       
        [HttpGet("{id}", Name = nameof(GetPostById))]
        public IActionResult GetPostById(int id)
        {
            var post = postservice.GetPostById(id).Select(
                x =>
                {
                    var postModel = new PostModel
                    {
                        Title = x.Title,
                        Score = x.Score,
                        Body = x.Body,
                        CreationDate = x.CreationDate,
                        CloseDate = x.CloseDate,

                        UserName = x.User.Name,
                        Comments = x.Comments

                    };
                    return postModel;
                    
                });
            return Ok(post);
        }

        

        //[HttpGet("{id}", Name =nameof(GetCommentsForPost))]
        //public  async Task<IEnumerable<Comments>> GetCommentsForPost(int id){

        //    var comments = await commentsService.GetAllCommentsForPost(id).ToListAsync();
        //    return mapper.Map<List<Comments>>(comments);
            
        //}

        //[HttpGet("/{userid}")]
        //public async Task<IEnumerable<Post>> GetAllPostForUser(int userid)
        //{

        //    var postForUsers = await postservice.GetAllPostForUser(userid).ToListAsync();

        //    return mapper.Map<List<Post>>(postForUsers);

        //}
        

       

        }
    }
