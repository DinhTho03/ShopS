using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using WebShopShoes.Dto.Product_Admin;
using WebShopShoes.Dto.ProductImage;
using WebShopShoes.IService.Admin.IShop;
using WebShopShoes.IService.IShop;

namespace WebShopShoes.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_Admin : ControllerBase
    {
        private readonly IShop _shop;

        public Category_Admin (IShop shop)
        {
            _shop = shop;
        }

        [HttpGet, Authorize(Roles = "True")]
        public IActionResult AllProduct(string? search, double? from, double? to, string? sortBy, int page = 1)
        {
            int cateId = 1;
            var allProducts = _shop.GetAllProduct(search, from, to, sortBy, cateId, page).DistinctBy(x => x.ProductId);
            return Ok(allProducts);
        }

        [HttpGet("{productId}"), Authorize(Roles = "True")]
        public IActionResult GetProductById(int productId)
        {
            var allProducts = _shop.GetById(productId);
            return Ok(allProducts);
        }

        [HttpPut, Authorize(Roles = "True")]
        public IActionResult Update( [FromBody] UpdateProdduct product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            UpdateProdduct Update = new UpdateProdduct();
            Update.ProductId = product.ProductId;
            Update.ProductName = product.ProductName;
            Update.BrandName = product.BrandName;
            Update.ProductImage = product.ProductImage;
            Update.Status = product.Status;
            Update.Description = product.Description;
            Update.Price = product.Price;
            Update.Stock = product.Stock;
            Update.Type = product.Type;
            var putProduct = _shop.UpdateProduct(Update);
            return Ok(putProduct);
        }

        [HttpPost("AddProduct") ,Authorize(Roles = "True")]
        public async Task<IActionResult> AddProduct([FromBody] AddProduct product )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            AddProduct addOrUpdate = new AddProduct();
            addOrUpdate.ProductName = product.ProductName;
            addOrUpdate.BrandName = product.BrandName;
            addOrUpdate.ProductImage = product.ProductImage;
            addOrUpdate.Status = product.Status;
            addOrUpdate.Description = product.Description;
            addOrUpdate.Price = product.Price;
            addOrUpdate.Stock = product.Stock;
            addOrUpdate.Type = product.Type;
            var addProduct = _shop.AddProduct(addOrUpdate);
            return Ok(addProduct);
        }

        [HttpDelete ("{productId}"), Authorize(Roles = "True")]
        public IActionResult DeleteProduct(int productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var deleteProduct = _shop.DeleteProduct(productId);
            return Ok(deleteProduct);
        }
    }
}
