
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ShopShoes.Data.DetailPage_Description.DetailPage
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Style { get; set; }
        [Required]
        [Column(TypeName = "Text")]
        public string Description { get; set; }
        [ForeignKey("CateId")]
        public int CateId { get; set; }
        [ForeignKey("ProductId")]
        public List<ProductImage> ProductImages { get; set; }
        [ForeignKey("ProductId")]
        public List<ProductSize> ProductSizes { get; set; }
        [ForeignKey("Products")]
        public List<UserInfo> userInfos { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime UpdateAt { get; set; }
        [Required]
        public string CreateBy { get; set; }
        [Required]
        public string UpdateBy { get; set; }
    }
}
