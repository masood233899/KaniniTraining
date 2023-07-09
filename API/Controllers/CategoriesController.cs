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
    public class CategoriesController : ControllerBase
    {
        public ICategoryServices _category;

        public CategoriesController(ICategoryServices category)
        {
            _category = category;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var category = await _category.GetCategories();
            return Ok(category);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
          
            var category = await _category.GetCategoryById(id);
            if(category == null)
            {
                return NotFound("Car id not found");
            }
            return Ok(category);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            var upcar = await _category.PutCategory(id, category);
            if (upcar == null) 
            {
                return NotFound("car not found");

            }
            return Ok(upcar);
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            var newcategory = await _category.PostCategory(category);

            return Ok(newcategory);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            
            var deletecategory = await _category.DeleteCategory(id);
            if (deletecategory == null)
            {
                return NotFound();
            }


            return Ok(deletecategory);
        }

        
    }
}
