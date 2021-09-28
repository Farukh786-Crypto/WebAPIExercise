using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Postmethod6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Postmethod6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                Console.WriteLine("New Product Information");
                Console.WriteLine("ID:"+product.Id);
                Console.WriteLine("Name:" + product.Name);
                Console.WriteLine("Price:" + product.Price);
                return Ok(product);

            }
            catch 
            {

                return BadRequest();
            }
        }
        [Consumes("application/jsoon")]
        [Produces("application/json")]
        [HttpPut("update")]
        public async Task<IActionResult> Update(Product product)
        {
            try
            {

                Console.WriteLine("Update Product Information");
                Console.WriteLine("ID:" + product.Id);
                Console.WriteLine("Name:" + product.Name);
                Console.WriteLine("Price:" + product.Price);
                return Ok(product);
            }
            catch 
            {
                return BadRequest();
            }
        }


    }
}
