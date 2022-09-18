

namespace ShopShoes.Model
{
    public class DetailProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Title { get; set; }
        public object ProductImage { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public DateTime Create { get; set; }
    }
}
