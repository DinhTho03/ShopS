using ShopShoes.Model;
using WebShopShoes.Model;
using WebShopShoes.Model.DetailProduct;

namespace ShopShoes.IService.DetailPage_Description
{
    public interface IProduct
    {
        List<GetDetailProductModel> GetByLocal(int productId);
        // cateId
        List<ProductModel> GetRelatedProducts(int id);
    }
}
