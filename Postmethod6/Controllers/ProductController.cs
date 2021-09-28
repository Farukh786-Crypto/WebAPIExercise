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
        /*[Consumes("application/json")]
        [Produces("application/json")]*/
        [HttpPost("create")]
        public async Task<IActionResult> Create(Product products)
        {
            try
            {
                Console.WriteLine("New Product Information");
                Console.WriteLine("ID:"+products.Id);
                Console.WriteLine("Name:" + products.Name);
                Console.WriteLine("Price:" + products.Price);
                return Ok(products);

            }
            catch 
            {

                return BadRequest();
            }
        }
    }
}
