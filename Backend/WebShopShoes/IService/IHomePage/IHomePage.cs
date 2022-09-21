using ShopShoes.Model;
using ShopShoes.Model.HomePage;

namespace ShopShoes.IService.IHomePage
{
    public interface IHomePage
    {
        List<DetailProductModel> Banner(int productId);
        List<DetailProductModel> ProductCategory(int id);
        List<DetailProductModel> Trending();
        //List<ProductImageModel> ProductImage(int id);
        List<ListCategory> ListCategory(int id);

    }
}
