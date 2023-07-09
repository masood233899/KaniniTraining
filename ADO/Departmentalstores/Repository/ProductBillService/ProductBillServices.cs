using DepartmentalStores.Data;
using DepartmentalStores.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentalStores.Repository.ProductBillService
{
    public class ProductBillServices:IProductBillServices
    {
        private DepartmentalStoresContext _context;
        public ProductBillServices(DepartmentalStoresContext context)
        {
            _context = context;
        }
        public async Task<List<ProductsUpdated>> GetDetails()
        {
            var item = await _context.ProductsUpdateds.ToListAsync();
            if (item == null)
            {
                return null;
            }
            return item;
        }
        public async Task<decimal> ProductBill(int[] id, decimal[] quans)
        {
            decimal price = 0;
            int total = id.Length;
            for (int i = 0; i < total; i++)
            {
                int item = id[i];
                var obj = await _context.ProductsUpdateds.FindAsync(item);
                price += ((decimal)obj.Price * quans[i]);
            }

            return price;
        }
        public async Task<decimal> ReturnBill(decimal price, int[] id, decimal[] quans)
        {
            int total = id.Length;
            for (int i = 0; i < total; i++)
            {
                var item = id[i];
                var obj = await _context.ProductsUpdateds.FindAsync(item);
                price -= ((decimal)obj.Price * quans[i]);
            }
            return price;
        }

    }
}
