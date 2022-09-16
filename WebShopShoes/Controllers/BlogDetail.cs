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
        public IActionResult GetProductBlog(string? search,int CategoryId = 6, string ProductName = "Nike")
        {
            var blogDetail = _blog.BlogDetail(search,CategoryId, ProductName);
            return Ok(blogDetail);
        }
        // GET api/<Blog>/5
        [HttpGet("RecentPost")]
        public IActionResult GetRecentPost(int CategoryId = 6)
        {
            var blogs = _blog.RecentPost(CategoryId);
            return Ok(blogs);
        }

        // GET api/<Blog>/5
        [HttpGet("PopularPost")]
        public IActionResult GetPopularPost(int CategoryId = 6)
        {
            var blogs = _blog.PopularPost(CategoryId);
            return Ok(blogs);
        }

        // GET api/<Blog>/5
        [HttpGet("PopularAuthor")]
        public IActionResult GetPopularAuthor(int CategoryId = 6)
        {
            var blogs = _blog.PopularAuthor(CategoryId);
            return Ok(blogs);
        }
    }
}
