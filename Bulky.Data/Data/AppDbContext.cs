using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Category>? Categories { get; set; }

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
    }
}