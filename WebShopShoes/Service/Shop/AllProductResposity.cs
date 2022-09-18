using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.Model;
using ShopShoes.Model.Paging;
using WebShopShoes.IService.IShop;

namespace WebShopShoes.Service.Shop
{
    public class AllProductResposity : IAllProduct
    {
        private readonly ShopDbContext _shopDbContext;

        public AllProductResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public static int page_size { get; set; } = 9;
        public List<DetailProductModel> AllProduct(string search, double? from, double? to, string sortBy , int cateId , int page )
        {
            // Paging
            var products = _shopDbContext.products.Where(x => x.CateId == cateId )
                .Select( x => new DetailProductModel
                {
                    ProductId = x.ProductId,
                    BrandName = x.BrandName,
                    ProductName = x.ProductName,
                    ProductImage = x.ProductImages.FirstOrDefault().FeatureImage,
                    Price = x.Price,
                    Create = x.CreateAt
                    
                });


            // Filtering
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.ProductName.Contains(search));
            }
            if (from.HasValue)
            {
                products = products.Where(p => p.Price >= from);
            }
            if (to.HasValue)
            {
                products = products.Where(p => p.Price <= to);
            }

            // Sort
            if(!string.IsNullOrEmpty(search))
            {
                switch (sortBy)
                {
                    case "Price High - Low": products = products.OrderByDescending(p => p.Price);
                        break;
                    case "Price Low - High": products = products.OrderBy(p => p.Price);
                        break;
                    case "Newest":
                        products = products.OrderByDescending(p => p.Create);
                        break;
                    case "Featured":
                        products = products.OrderBy(p => p.Create);
                        break;
                }
            }    
            var allProduct = PaginatedList<DetailProductModel>.Create(products, page, page_size);
            return allProduct;
        }
    }
}
