using DepartmentalStores.Models;
using DepartmentalStores.Repository.ProductBillService;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentalStores.Controllers
{
    [Route("User Side")]
    [ApiController]
    //FEATURES --> DISPLAYING ALL PRODUCTS,
    //             BILL GENERATION,
    //             RETURNING THE PRODUCT ie. SUBTRACTING FROM TOTAL_PRICE

    public class ProductsBillController : ControllerBase
    {
        private readonly IProductBillServices _context;

        public ProductsBillController(IProductBillServices context)
        {
            _context = context;
        }

        // GET: api/ProductsBill
        [HttpGet("Displaying All Items")]
        public async Task<ActionResult<List<ProductsUpdated>>> GetDetails()
        {
            var obj = await _context.GetDetails();
            if (obj == null)
            {
                return NotFound("Cannot Display the List of Tables");
            }
            return Ok(obj);
        }

        // GET: api/ProductsBill/5
        [HttpGet("Bill Generation")]
        public async Task<ActionResult<decimal>> ProductBill([FromQuery(Name = "id")] int[] id, [FromQuery(Name = "quan")] decimal[] quan)
        {
            var result = await _context.ProductBill(id, quan);//id==>product_id,quan==>quantity_to_buy
            return Ok(result);
        }

        //Returning Values
        [HttpGet("Returning Bill")]
        public async Task<ActionResult<decimal>> ReturnBill(decimal TotalBill, [FromQuery(Name = "id")] int[] id, [FromQuery(Name = "quan")] decimal[] quan)
        {
            //TotalBill-->Bill value to be typed manually so that
            //the no of product prices can be subtracted from it.
            var result = await _context.ReturnBill(TotalBill, id, quan);
            return Ok(result);
        }
    }
}
