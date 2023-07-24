using DepartmentalStores.Models;

namespace DepartmentalStores.Repository.ProductBillService
{
    public interface IProductBillServices
    {
        Task<List<ProductsUpdated>> GetDetails();
        Task<decimal> ProductBill(int[] id, decimal[] quans);
        Task<decimal> ReturnBill(decimal price, int[] id, decimal[] quans);
    }
}
