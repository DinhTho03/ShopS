using ShopShoes.Data;
using ShopShoes.IService.IHomePage;
using ShopShoes.Model;
using ShopShoes.Model.HomePage;

namespace ShopShoes.Service.HomePage
{
    public class HomePageResposity : IHomePage
    {
        private readonly ShopDbContext _shopDbContext;

        public HomePageResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        public List<DetailProductModel> Banner(int productId)
        {
            var products = (from product in _shopDbContext.products
                            where product.ProductId == productId
                            select new DetailProductModel
                            {
                                Title = product.Title,
                                ProductName = product.ProductName,
                                Description = product.Description,
                                Price = product.Price,
                                ProductImage = product.ProductImages.Select(x => new ProductImageModel
                                {
                                    FeatureImage = x.FeatureImage
                                }).ToList()
                            }).Take(5);
            return products.ToList();
        }

        public List<ListCategory> ListCategory(int id)
        {
            var cate = (from category in _shopDbContext.products
                        where category.CateId == id
                        select new ListCategory
                        {
                            Image = category.ProductImages.FirstOrDefault().FeatureImage,
                            Tilte = category.Title,
                            Description = category.Description,
                            User = category.userInfos.Select(x => new ListCategory_User
                            {
                                Avatar = x.Avatar,
                                OrderBy = x.CommentDate,
                                UserName = x.UserName
                            }).ToList()

                        }).Take(3);
            return cate.ToList();
        }
        public List<DetailProductModel> ProductCategory(int id)
        {
            var products = (from product in _shopDbContext.products
                            where product.CateId == id
                            select new DetailProductModel
                            {
                                BrandName = product.BrandName,
                                ProductName = product.ProductName,
                                Price = product.Price,
                                ProductImage = product.ProductImages.FirstOrDefault().FeatureImage
                            }
                           ).Take(4).ToList();
            return products;
        }

        //public List<ProductImageModel> ProductImage(int id)
        //{
        //    var productImage = (from product in _shopDbContext.products
        //                        where product.CateId == id
        //                        select new ProductImageModel
        //                        {
        //                            FeatureImage = product.ProductImages.Select(x => x.FeatureImage).Take(6).ToList()
        //                        }).ToList();
        //    return productImage;
        //}

        public List<DetailProductModel> Trending()
        {
            var products = (from product in _shopDbContext.products
                            orderby product.CreateAt descending
                            select new DetailProductModel
                            {
                                BrandName = product.BrandName,
                                ProductName = product.ProductName,
                                Price = product.Price,
                                ProductImage = product.ProductImages.FirstOrDefault().FeatureImage
                            }
                           ).Take(2).ToList();
            return products;
        }

    }
}
