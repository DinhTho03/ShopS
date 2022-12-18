using WebShopShoes.Data.Enum;

namespace WebShopShoes.Dto.Product_Admin
{
    public class UpdateProdduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public Status Status { get; set; }
        //public IFormFile ImageFile { get; set; }
        public string ProductImage { get; set; }
    }
}
