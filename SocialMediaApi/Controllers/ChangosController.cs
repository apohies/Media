using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMediaApi.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangosController : ControllerBase
    {

        [HttpGet]
        [TypeFilter(typeof(PermisoFilter))]
        public IActionResult Index() {


            return Ok("fail");
        }
    }
}
