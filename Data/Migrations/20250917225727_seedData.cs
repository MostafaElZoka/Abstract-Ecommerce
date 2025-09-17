using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Code", "Category", "Discount", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { "P001", "Electronics", 0.10m, "https://cdn.mos.cms.futurecdn.net/FUi2wwNdyFSwShZZ7LaqWf.jpg", "Laptop", 999.99m, 10 },
                    { "P002", "Electronics", 0.05m, "https://m.media-amazon.com/images/I/61fh21u3DJL.jpg", "Smartphone", 499.99m, 20 },
                    { "P003", "Accessories", 0.15m, "https://m.media-amazon.com/images/I/61kcjN3yo+L._UF894,1000_QL80_.jpg", "Headphones", 79.99m, 50 },
                    { "P004", "Home Appliances", 0.20m, "https://i5.walmartimages.com/seo/Mr-Coffee-5-Cup-Programmable-Coffee-Maker-25-oz-Mini-Brew-Brew-Now-or-Later-Black_972164db-9b9b-42e2-9463-80f40fb360e3.2423b7d6d6d77ec31ed140a0cece9662.jpeg", "Coffee Maker", 39.99m, 15 },
                    { "P005", "Electronics", 0.10m, "https://i5.walmartimages.com/asr/78ecb78a-f45e-40c9-98c2-e059bc4e93b6.781d30e03254cb41d2297474de4d50c0.jpeg", "Gaming Console", 299.99m, 5 },
                    { "P006", "Home Appliances", 0.25m, "https://cdn.mafrservices.com/pim-content/EGY/media/product/647543/1737017022/647543_main.jpg", "Electric Kettle", 24.99m, 30 },
                    { "P007", "Electronics", 0.10m, "https://m.media-amazon.com/images/I/71pbEc1KO3L._AC_SL1500_.jpg", "Smartwatch", 199.99m, 12 },
                    { "P008", "Accessories", 0.15m, "https://m.media-amazon.com/images/I/81oRzXfs2zL._UF894,1000_QL80_.jpg", "Bluetooth Speaker", 49.99m, 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P001");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P003");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P004");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P005");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P006");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P007");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: "P008");

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
