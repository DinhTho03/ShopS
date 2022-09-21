using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopShoes.Data.DetailPage_Description.DetailPage
{
    [Table("ProductSize")]
    public class ProductSize
    {
        [Key]
        public int ProductSizeId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("SizeId")]
        public int SizeId { get; set; }
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
