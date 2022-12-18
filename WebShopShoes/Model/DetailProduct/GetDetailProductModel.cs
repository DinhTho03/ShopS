namespace WebShopShoes.Model.DetailProduct
{
    public class GetDetailProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public object ProductImage { get; set; }
        public int Price { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
    }
}
