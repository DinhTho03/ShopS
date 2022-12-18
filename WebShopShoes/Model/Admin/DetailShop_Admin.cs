using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebShopShoes.Data.Enum;

namespace WebShopShoes.Model.Admin
{
    public class DetailShop_Admin
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public int ViewCount { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }
        public string ProductImage { get; set; }
        public int Id { get; set; }
        public string? Style { get; set; }
        public DateTime UpdateAt { get; set; }
        [Required]
        public string CreateBy { get; set; }
        [Required]
        public string UpdateBy { get; set; }
    }
}
