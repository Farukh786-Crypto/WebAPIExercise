using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryStringWeb4.Controllers
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
                string id1 = HttpContext.Request.Query["id1"].ToString();
                int id2 = int.Parse(HttpContext.Request.Query["id2"].ToString());
                return Ok("Id1: "+id1+",ID2: "+id2);
            }
            catch
            {
                return BadRequest();
               
            }
        }
        [Produces("text/plain")]
        [HttpGet("demo2")]
        public async Task<IActionResult> Demo2([FromQuery(Name ="id1")] string id1, [FromQuery(Name = "id2")] string id2)
        {
            try
            {
                return Ok("Id1 :"+id1+", Id2 :"+id2);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
