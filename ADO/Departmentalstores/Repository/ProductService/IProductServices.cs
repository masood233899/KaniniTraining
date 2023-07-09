using DepartmentalStores.Models;

namespace DepartmentalStores.Repository.ProductService
{
    public interface IProductServices
    {
        Task<List<ProductsUpdated>> DisplayAllProducts();
        Task<List<ProductsUpdated>> PostProductsUpdated(ProductsUpdated productsUpdated);
        Task<List<ProductsUpdated>> PutProductsUpdated(int id, ProductsUpdated productsUpdated);
        Task<List<ProductsUpdated>> DeleteValues(int id);
    }
}
