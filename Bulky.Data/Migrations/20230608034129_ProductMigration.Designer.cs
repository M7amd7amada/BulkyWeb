﻿// <auto-generated />
using Bulky.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyWeb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230608034129_ProductMigration")]
    partial class ProductMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            DisplayOrder = 1,
                            Name = "Books"
                        },
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 2,
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 3,
                            Name = "Clothing"
                        },
                        new
                        {
                            CategoryId = 4,
                            DisplayOrder = 4,
                            Name = "Home Decor"
                        },
                        new
                        {
                            CategoryId = 5,
                            DisplayOrder = 5,
                            Name = "Toys"
                        },
                        new
                        {
                            CategoryId = 6,
                            DisplayOrder = 6,
                            Name = "Sports Equipment"
                        },
                        new
                        {
                            CategoryId = 7,
                            DisplayOrder = 7,
                            Name = "Beauty Products"
                        },
                        new
                        {
                            CategoryId = 8,
                            DisplayOrder = 8,
                            Name = "Automotive"
                        },
                        new
                        {
                            CategoryId = 9,
                            DisplayOrder = 9,
                            Name = "Music Instruments"
                        },
                        new
                        {
                            CategoryId = 10,
                            DisplayOrder = 10,
                            Name = "Fitness Gear"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISPN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ListPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<decimal>("Price100")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<decimal>("Price50")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Author = "Author 1",
                            Description = "This is product 1",
                            ISPN = "ISPN-1",
                            ListPrice = 50.00m,
                            Price = 45.00m,
                            Price100 = 35.00m,
                            Price50 = 40.00m,
                            Title = "Product 1"
                        },
                        new
                        {
                            ProductId = 2,
                            Author = "Author 2",
                            Description = "This is product 2",
                            ISPN = "ISPN-2",
                            ListPrice = 30.00m,
                            Price = 25.00m,
                            Price100 = 15.00m,
                            Price50 = 20.00m,
                            Title = "Product 2"
                        },
                        new
                        {
                            ProductId = 3,
                            Author = "Author 3",
                            Description = "This is product 3",
                            ISPN = "ISPN-3",
                            ListPrice = 60.00m,
                            Price = 55.00m,
                            Price100 = 45.00m,
                            Price50 = 50.00m,
                            Title = "Product 3"
                        },
                        new
                        {
                            ProductId = 4,
                            Author = "Author 4",
                            Description = "This is product 4",
                            ISPN = "ISPN-4",
                            ListPrice = 20.00m,
                            Price = 15.00m,
                            Price100 = 5.00m,
                            Price50 = 10.00m,
                            Title = "Product 4"
                        },
                        new
                        {
                            ProductId = 5,
                            Author = "Author 5",
                            Description = "This is product 5",
                            ISPN = "ISPN-5",
                            ListPrice = 80.00m,
                            Price = 75.00m,
                            Price100 = 65.00m,
                            Price50 = 70.00m,
                            Title = "Product 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
