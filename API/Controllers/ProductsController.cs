using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using grocery_api.Models;
using grocery_api.Services;

namespace grocery_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IProductServices _services;

        public ProductsController(IProductServices services)
        {
            _services = services;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
          var allproduct =await _services.GetProducts();
          return Ok(allproduct);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
          
            var product = await _services.GetProductsById(id);

            if (product == null)
            {
                return NotFound("id not found");
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts(int id, Product product)
        {
            var upprod = await _services.PutProducts(id, product);
            if (upprod == null)
            {
                return NotFound("id not found");
            }
            return Ok(upprod);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProducts(Product product)
        {

            var addprod = await _services.PostProducts(product);

            return Ok(addprod);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {

            var product = await _services.DeleteProducts(id);
            if (product == null)
            {
                return NotFound("product of that id does not exist");
            }

            

            return Ok(product);
        }
    }
}
