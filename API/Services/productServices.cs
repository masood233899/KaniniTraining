using grocery_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace grocery_api.Services
{
    public class productServices: IProductServices
    {
        public GroceryStoreContext _context;
        
        public productServices(GroceryStoreContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Product?> GetProductsById(int id)
        {
            
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return null;
            }

            return product;
        }

        public async Task<List<Product>> PostProducts(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return await _context.Products.ToListAsync();
        }


        public async Task<List<Product>?> PutProducts(int id, Product product)
        {
            var upproduct = await _context.Products.FindAsync(id);
            if(upproduct == null)
            {
                return null;
            }
            upproduct.Price = product.Price;
            upproduct.ProdName = product.ProdName;
            upproduct.Cat = product.Cat;
            await _context.SaveChangesAsync();
            return await _context.Products.ToListAsync();

        }
        public async Task<List<Product>?> DeleteProducts(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return null;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return await _context.Products.ToListAsync(); ;
        }

    }
}
