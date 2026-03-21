using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Thư viện mới cần thêm
using Microsoft.EntityFrameworkCore;

namespace Bai6_Tuan6_LTW.Models
{
    // Thay đổi kế thừa từ DbContext sang IdentityDbContext
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}