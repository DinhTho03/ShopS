using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopShoes.Data.DetailPage_Description.DetailPage
{
    [Table("Size")]
    public class Size
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Value { get; set; }
        [ForeignKey("SizeId")]
        public List<ProductSize> ProductSizes { get; set; }
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
