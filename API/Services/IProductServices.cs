using grocery_api.Models;

namespace grocery_api.Services
{
    public interface IProductServices
    {
        Task<List<Product>> GetProducts();

        Task<Product?> GetProductsById(int id);

        Task<List<Product>> PostProducts(Product product);

        Task<List<Product>?> PutProducts(int id, Product product);

        Task<List<Product>?> DeleteProducts(int id);
    }
}
