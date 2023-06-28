using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Product.API.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id= 2,
                Name="Name2",
                Price = 59.90M,
                Description= "Description",
                CategoryName= "Category",
                ImageURL = null
            });

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 3,
                Name = "Name3",
                Price = 59.90M,
                Description = "Description",
                CategoryName = "Category",
                ImageURL = null
            });

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 4,
                Name = "Name4",
                Price = 59.90M,
                Description = "Description",
                CategoryName = "Category",
                ImageURL = null
            });

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 5,
                Name = "Name5",
                Price = 59.90M,
                Description = "Description",
                CategoryName = "Category",
                ImageURL = null
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 6,
                Name = "Name6",
                Price = 59.90M,
                Description = "Description",
                CategoryName = "Category",
                ImageURL = null
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 7,
                Name = "Name7",
                Price = 59.90M,
                Description = "Description",
                CategoryName = "Category",
                ImageURL = null
            });
        }
    }
}
