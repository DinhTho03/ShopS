
using WebShopShoes.Model;
using WebShopShoes.Model.DetailProduct;

namespace ShopShoes.IService.IHomePage
{
    public interface IHomePage
    {
        List<BannerModel> Banner(int productId);
        List<ProductModel> ProductCategory(int CateId);
        List<ProductModel> Trending(int cateId);
        //List<ProductImageModel> ProductImage(int id);
        List<ProductModel> ListCategory(int id);

    }
}
