using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternTask2.Migrations
{
    public partial class AddCardItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 101, 1, "Comfortable and stylish for everyday wear.", "/images/card-item1.jpg", "Sports men shoes", 79.99m },
                    { 102, 1, "Perfect for gym and casual outings.", "/images/card-item2.jpg", "Sports men shoes", 99.99m },
                    { 103, 1, "Ideal for formal occasions and office wear.", "/images/card-item3.jpg", "Sports men shoes", 59.99m },
                    { 104, 1, "Durable and sleek, designed for city life", "/images/card-item4.jpg", "Sports men shoes", 89.99m },
                    { 105, 1, "Perfect for running and staying cool on the move.", "/images/card-item5.jpg", "Sports men shoes", 109.99m },
                    { 106, 1, "Supportive grip and ankle protection on the court.", "/images/card-item6.jpg", "Sports men shoes", 49.99m },
                    { 107, 1, "Beautiful design for a chic everyday look.", "/images/card-item7.jpg", "Sports men shoes", 79.99m },
                    { 108, 1, "Perfect heels for parties and events.", "/images/card-item8.jpg", "Sports men shoes", 49.99m },
                    { 109, 1, "Great for casual wear and summer outings.", "/images/card-item9.jpg", "Sports men shoes", 89.99m },
                    { 110, 1, "Chic and comfortable for all-day wear.", "/images/card-item10.jpg", "Sports men shoes", 129.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);
        }
    }
}
