using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMediaCore.Entities;
using SocialMediaCore.Interfaces;
using SocialMediaInfrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet("GetPosts")]
        public async Task<IActionResult> GetPosts() {

            var post = await _postRepository.GetPosts();

            return Ok(post);
        }

        [HttpGet("GetPostByid/{id:int}")]

        public async Task<IActionResult> GetPostByid(int id) 
        {

            try
            {


                Post potsito = await _postRepository.GetPost(id);

                return Ok(potsito);

            }
            catch (Exception e) {


                return BadRequest(e.Message+"frito");
            
            }
        
        }


    }
}
