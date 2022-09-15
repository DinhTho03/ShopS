using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.IService.IBlog;
using ShopShoes.Model.HomePage;

namespace ShopShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogDetail : ControllerBase
    {
        private readonly IBlog _blog;

        public BlogDetail(IBlog blog)
        {
            _blog = blog;
        }
        [HttpGet("ProductBlog")]
        public IActionResult GetProductBlog(int CategoryId = 6, string ProductName = "Nike")
        {
            var blogDetail = _blog.BlogDetail(CategoryId, ProductName);
            return Ok(blogDetail);
        }
    }
}
