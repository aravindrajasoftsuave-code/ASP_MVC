using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class insertdatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Display_Order",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_ID", "Category_Name", "Display_Order" },
                values: new object[,]
                {
                    { 1, "IPhone", 2 },
                    { 2, "RedMi", 1 },
                    { 3, "OPPO", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_ID",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Display_Order",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
