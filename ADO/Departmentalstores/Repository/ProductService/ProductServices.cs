using DepartmentalStores.Data;
using DepartmentalStores.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentalStores.Repository.ProductService
{
    public class ProductServices:IProductServices
    {
        private DepartmentalStoresContext _context;
        public ProductServices(DepartmentalStoresContext context)
        {
            _context = context;
        }

        public async Task<List<ProductsUpdated>> DisplayAllProducts()
        {
            var item = await _context.ProductsUpdateds.ToListAsync();
            if (item == null)
            {
                return null;
            }
            return item;
        }
        public async Task<List<ProductsUpdated>> PostProductsUpdated(ProductsUpdated productsUpdated)
        {
            await _context.ProductsUpdateds.AddAsync(productsUpdated);
            await _context.SaveChangesAsync();
            return await _context.ProductsUpdateds.ToListAsync();
        }
        public async Task<List<ProductsUpdated>> PutProductsUpdated(int id, ProductsUpdated productsUpdated)
        {
            var item = await _context.ProductsUpdateds.FindAsync(id);
            item.Product = productsUpdated.Product;
            item.ProductId = productsUpdated.ProductId;
            item.ProductSection = productsUpdated.ProductSection;
            item.AvailableQuantity = productsUpdated.AvailableQuantity;
            item.Price = productsUpdated.Price;
            await _context.SaveChangesAsync();
            return await _context.ProductsUpdateds.ToListAsync();
        }

        public async Task<List<ProductsUpdated>> DeleteValues(int id)
        {
            var obj = await _context.ProductsUpdateds.FindAsync(id);
            _context.ProductsUpdateds.Remove(obj);
            await _context.SaveChangesAsync();
            return await _context.ProductsUpdateds.ToListAsync();

        }

    }
}
