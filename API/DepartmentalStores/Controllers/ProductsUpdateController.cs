﻿using DepartmentalStores.Models;
using DepartmentalStores.Repository.ProductService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentalStores.Controllers
{
    [Route("Admin Side")]
    [ApiController]
    [Authorize]
    //Only can be access by the token generated by Auth 
    public class ProductsUpdateController : ControllerBase
    {
        private readonly IProductServices _context;

        public ProductsUpdateController(IProductServices context)
        {
            _context = context;
        }

        // GET: api/ProductsUpdateds
        [HttpGet("Displaying all Items")]
        public async Task<ActionResult<List<ProductsUpdated>>> DisplayAllProducts()
        {
            var listi = await _context.DisplayAllProducts();
            if (listi == null)
            {
                return NotFound("There are No Products Found... Try Again!!!");
            }
            return Ok(listi);
        }

        // Update Values
        [HttpPut("{id}")]
        public async Task<ActionResult<List<ProductsUpdated>>> PutProductsUpdated(int id, ProductsUpdated productsUpdated)
        {
            var obj = await _context.PutProductsUpdated(id, productsUpdated);
            return Ok(obj);
        }

        // Adding new Rows
        [HttpPost("Updating the Values")]
        public async Task<ActionResult<List<ProductsUpdated>>> PostProductsUpdated(ProductsUpdated productsUpdated)
        {
            var total = await _context.PostProductsUpdated(productsUpdated);
            return Ok(total);
        }

        // Deleting Existing
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ProductsUpdated>>> DeleteValues(int id)
        {
            var obj = await _context.DeleteValues(id);
            return Ok(obj);
        }
    }
}
