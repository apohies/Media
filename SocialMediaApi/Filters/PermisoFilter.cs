using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using SocialMediaInfrastructure.Data;
using System;

using System.Linq;
using System.Net;
using System.Net.Http;

namespace SocialMediaApi.Filters
{
    public class PermisoFilter : IActionFilter
    {

        private readonly SocialMediaContext _context;

        public PermisoFilter(SocialMediaContext context)
        {
            _context = context;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            bool chato = false;

            StringValues tuchel;
            context.HttpContext.Request.Headers.TryGetValue("nachariel", out tuchel);

            if (tuchel.Count == 0) 
            {

                JsonResult jsonResult;

                jsonResult = new JsonResult("error")
                {

                    StatusCode = 200,
                    Value = "no api no party"
                };
                context.Result = jsonResult;

                return;

            }

            if (chato)
            {
                JsonResult jsonResult;

                jsonResult = new JsonResult("error")
                {

                    StatusCode = 200,
                    Value = "si problema"
                };
                context.Result = jsonResult;

                return;


            }

            return;

        }


    }

}

