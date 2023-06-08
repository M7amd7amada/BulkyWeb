using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Books", DisplayOrder = 1 },
            new Category { CategoryId = 2, Name = "Electronics", DisplayOrder = 2 },
            new Category { CategoryId = 3, Name = "Clothing", DisplayOrder = 3 },
            new Category { CategoryId = 4, Name = "Home Decor", DisplayOrder = 4 },
            new Category { CategoryId = 5, Name = "Toys", DisplayOrder = 5 },
            new Category { CategoryId = 6, Name = "Sports Equipment", DisplayOrder = 6 },
            new Category { CategoryId = 7, Name = "Beauty Products", DisplayOrder = 7 },
            new Category { CategoryId = 8, Name = "Automotive", DisplayOrder = 8 },
            new Category { CategoryId = 9, Name = "Music Instruments", DisplayOrder = 9 },
            new Category { CategoryId = 10, Name = "Fitness Gear", DisplayOrder = 10 }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Title = "Product 1",
                Description = "This is product 1",
                ISPN = "ISPN-1",
                Author = "Author 1",
                ListPrice = 50.00m,
                Price = 45.00m,
                Price50 = 40.00m,
                Price100 = 35.00m
            },
            new Product
            {
                ProductId = 2,
                Title = "Product 2",
                Description = "This is product 2",
                ISPN = "ISPN-2",
                Author = "Author 2",
                ListPrice = 30.00m,
                Price = 25.00m,
                Price50 = 20.00m,
                Price100 = 15.00m
            },
            new Product
            {
                ProductId = 3,
                Title = "Product 3",
                Description = "This is product 3",
                ISPN = "ISPN-3",
                Author = "Author 3",
                ListPrice = 60.00m,
                Price = 55.00m,
                Price50 = 50.00m,
                Price100 = 45.00m
            },
            new Product
            {
                ProductId = 4,
                Title = "Product 4",
                Description = "This is product 4",
                ISPN = "ISPN-4",
                Author = "Author 4",
                ListPrice = 20.00m,
                Price = 15.00m,
                Price50 = 10.00m,
                Price100 = 5.00m
            },
            new Product
            {
                ProductId = 5,
                Title = "Product 5",
                Description = "This is product 5",
                ISPN = "ISPN-5",
                Author = "Author 5",
                ListPrice = 80.00m,
                Price = 75.00m,
                Price50 = 70.00m,
                Price100 = 65.00m
            }
        );
    }
}