using ShopShoes.Model;

namespace WebShopShoes.IService.IShop
{
    public interface IAllProduct
    {
        List<DetailProductModel> AllProduct(string search, double? from, double? to, string sortBy, int cateId, int page );
    }
}
