using Microsoft.EntityFrameworkCore;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.IService.DetailPage_Description;
using ShopShoes.Model;
using WebShopShoes.Model;
using WebShopShoes.Model.DetailProduct;

namespace ShopShoes.Service.DetailPage_Description
{
    public class ProductResposity : IProduct
    {
        private readonly ShopDbContext _shopDbContext;

        public ProductResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public List<GetDetailProductModel> GetByLocal(int productId)
        {
            var products = (from product in _shopDbContext.Products
                            where product.ProductDetails.FirstOrDefault().ProductId == productId
                            select new GetDetailProductModel
                            {
                                Id = product.ProductDetails.FirstOrDefault().Id,
                                ProductName = product.ProductDetails.FirstOrDefault().ProductName,
                                BrandName = product.ProductDetails.FirstOrDefault().BrandName,
                                ProductImage = product.ProductImages.FirstOrDefault().Url,
                                Description = product.ProductDetails.FirstOrDefault().Description,
                                Price = product.ProductDetails.FirstOrDefault().Price
                            }).Take(1);
            _shopDbContext.ProductDetails.FirstOrDefault(x => x.ProductId == productId).ViewCount += 1;
            _shopDbContext.SaveChanges();
            return products.ToList();
        }

        public List<ProductModel> GetRelatedProducts(int id)
        {
            var products = (from product in _shopDbContext.Products
                            where product.CateId == id
                            orderby product.CreateAt descending
                            select new ProductModel
                            {
                                Id = product.Id,
                                ProductDetails = new DetailProductModel
                                {
                                    Id = product.ProductDetails.FirstOrDefault().Id,
                                    ProductName = product.ProductDetails.FirstOrDefault().ProductName,
                                    BrandName = product.ProductDetails.FirstOrDefault().BrandName,
                                    Price = product.ProductDetails.FirstOrDefault().Price,
                                    ProductImage = product.ProductImages.FirstOrDefault().Url
                                }
                            }
                           ).Take(4).ToList();
            return products;
        }
    }
}
