using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using objecttojson5.Models;
namespace objecttojson5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Produces("application/json")]
        [HttpGet("find")]
        public async Task<IActionResult> Find()
        {
            try
            {
                var products = new List<Product>()
                { 
                    new Product(){ Id="p01",Name="name 1", Price=2  },
                    new Product(){ Id="p02",Name="name 2", Price=5  },
                    new Product(){ Id="p03",Name="name 3", Price=8  }
                };
                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
