using ShopShoes.Model;

namespace ShopShoes.IService.DetailPage_Description
{
    public interface IProduct
    {
        List<DetailProductModel> GetByLocal(string productName);
        List<DetailProductModel> GetRelatedProducts(int id);
    }
}
