using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MiddlewareWebApp8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Produces("text/plain")]
        [HttpGet("demo1")]
        public async Task<IActionResult> Demo1()
        {
            try
            {
                var content = "Hello World";
                return Ok(content);
            }
            catch 
            {

                return BadRequest();
            }
        }

        [Produces("text/plain")]
        [HttpGet("demo2")]
        public async Task<IActionResult> Demo2()
        {
            try
            {
                var content = "<b><i><u>Hello World</u></i></b>";
                return new ContentResult
                {
                    Content = content,
                    ContentType = "text/html",
                    StatusCode = (int)HttpStatusCode.OK
                };
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
