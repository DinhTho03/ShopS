using Microsoft.EntityFrameworkCore;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ShopShoes.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
        public DbSet<ProductSize> productSizes { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<UserInfo> userInfos { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
