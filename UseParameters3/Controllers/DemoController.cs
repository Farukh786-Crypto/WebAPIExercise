using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UseParameters3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase    
    {
        [Produces("text/plain")]
        [HttpGet("demo1/{id}")]
        public async Task<IActionResult> Demo1(string id)
        {
            try
            {
                return Ok("ID: "+id);
            }
            catch 
            {

                return BadRequest();
            }
        }
        [Produces("text/plain")]
        [HttpGet("demo2/{id1}/{id2}")]
        public async Task<IActionResult> Demo2(string id1,string id2)
        {
            try
            {
                return Ok("Id1 :" + id1 + "Id2 :" + id2);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}













