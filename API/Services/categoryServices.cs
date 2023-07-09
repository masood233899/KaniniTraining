using grocery_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace grocery_api.Services
{
    public class categoryServices : ICategoryServices
    {
        public GroceryStoreContext _context;

        public categoryServices(GroceryStoreContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategories()
        {
            var category =  await _context.Categories.ToListAsync();
            return category;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var Category = await _context.Categories.FindAsync(id);
            if (Category== null)
            {
                return null;
            }
            return Category;
        }

        public async Task<List<Category>> PostCategory(Category Category)
        {

            
            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Category>?> PutCategory(int id, Category category)
        {
            var upcar = await _context.Categories.FindAsync(id);
            if (upcar == null)
            {
                return null;
            }

            upcar.CatId = category.CatId;
            upcar.CatName = category.CatName;
            await _context.SaveChangesAsync();
            return await _context.Categories.ToListAsync();

            
        }
        public async Task<List<Category>?> DeleteCategory(int id)
        {
            
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null;
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return await _context.Categories.ToListAsync();
        }
    }
}
