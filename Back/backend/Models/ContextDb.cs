using backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class ContextDb : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public ContextDb(DbContextOptions<ContextDb> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
/*            modelBuilder.Entity<User>().Property(x => x.Password).HasConversion(dbValue => dbValue.Concat("text").ToString(), myValue => myValue.ToLower());
*/        }
    }
}
