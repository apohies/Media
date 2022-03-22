using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMediaCore.DTOs;
using SocialMediaCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedureController : ControllerBase
    {

        private readonly ISimply simply;

        public ProcedureController(ISimply simply) {

            this.simply = simply;
        }

        [HttpGet("Bripeca")]

        public async Task<ActionResult<List<Simply>>> Bripeca(int id)
        {

            var post = await simply.Bripeca();

            return Ok(post);
        }
    }
}
