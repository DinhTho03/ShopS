using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.IService.IHomePage;

namespace ShopShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePage : ControllerBase
    {
        private readonly IHomePage _homePage;

        public HomePage(IHomePage homePage)
        {
            _homePage = homePage;
        }

        [HttpGet("Banner")]
        public IActionResult GetBanner(int productId = 2)
        {
            var products = _homePage.Banner(productId);
            return Ok(products);
        }
        [HttpGet("ProductCategory")]

        public IActionResult GetProductCategory(int id = 1)
        {
            var products = _homePage.ProductCategory(id);
            return Ok(products);
        }
        [HttpGet("Trending")]
        public IActionResult GetProductLatest()
        {
            var products = _homePage.Trending();
            return Ok(products);
        }
        //[HttpGet("ProductImage")]
        //public IActionResult GetProductImage(int id = 5)
        //{
        //    var products = _homePage.ProductImage(id);
        //    return Ok(products);
        //}
        [HttpGet("ListCategory")]
        public IActionResult GetListCategory(int id = 6)
        {
            var products = _homePage.ListCategory(id);
            return Ok(products);
        }
    }
}
