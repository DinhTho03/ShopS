using Microsoft.EntityFrameworkCore;
using ShopShoes.Data;
using ShopShoes.IService.DetailPage_Description;
using ShopShoes.Model;

namespace ShopShoes.Service.DetailPage_Description
{
    public class ProductResposity : IProduct
    {
        private readonly ShopDbContext _shopDbContext;

        public ProductResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public List<DetailProductModel> GetByLocal(string username)
        {
            var products = (from product in _shopDbContext.products
                            where product.ProductName == username
                            select new DetailProductModel
                            {
                                Description = product.Description,
                                Price = product.Price,
                                ProductImage = product.ProductImages.Select(x => new ProductImageModel
                                {
                                    FeatureImage = x.FeatureImage
                                }).Take(5).ToList(),
                                ProductName = product.ProductName,
                                Title = product.Title
                            }).Take(1);
            return products.ToList();
        }

        public List<DetailProductModel> GetRelatedProducts(int id)
        {
            var Products = (from product in _shopDbContext.products
                            where product.CateId == id
                            select new DetailProductModel
                            {
                                ProductImage = product.ProductImages.Select(x => new ProductImageModel
                                {
                                    FeatureImage = x.FeatureImage
                                }).Take(1).ToList(),
                                ProductName = product.ProductName,
                                Title = product.Title,
                                Price = product.Price
                            }).Take(4);
            return Products.ToList();
        }
    }
}
