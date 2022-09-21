using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopShoes.IService.IShop;

namespace WebShopShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Shop : ControllerBase
    {
        private readonly IAllProduct _allProduct;

        public Shop(IAllProduct allProduct)
        {
            _allProduct = allProduct;
        }

        [HttpGet]
        public IActionResult AllProduct(string? search, double? from, double? to, string? sortBy, int cateId = 1 ,int page = 1 )
        {
            var allProducts = _allProduct.AllProduct( search,  from, to, sortBy,cateId, page);
            return Ok(allProducts);
        }
    }
}
