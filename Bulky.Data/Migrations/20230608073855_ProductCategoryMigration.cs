using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductCategoryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISPN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Price50 = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Price100 = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Books" },
                    { 2, 2, "Electronics" },
                    { 3, 3, "Clothing" },
                    { 4, 4, "Home Decor" },
                    { 5, 5, "Toys" },
                    { 6, 6, "Sports Equipment" },
                    { 7, 7, "Beauty Products" },
                    { 8, 8, "Automotive" },
                    { 9, 9, "Music Instruments" },
                    { 10, 10, "Fitness Gear" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Author", "CategoryId", "Description", "ISPN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", 1, "This is product 1", "ISPN-1", 50.00m, 45.00m, 35.00m, 40.00m, "Product 1" },
                    { 2, "Author 2", 2, "This is product 2", "ISPN-2", 30.00m, 25.00m, 15.00m, 20.00m, "Product 2" },
                    { 3, "Author 3", 3, "This is product 3", "ISPN-3", 60.00m, 55.00m, 45.00m, 50.00m, "Product 3" },
                    { 4, "Author 4", 3, "This is product 4", "ISPN-4", 20.00m, 15.00m, 5.00m, 10.00m, "Product 4" },
                    { 5, "Author 5", 5, "This is product 5", "ISPN-5", 80.00m, 75.00m, 65.00m, 70.00m, "Product 5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
