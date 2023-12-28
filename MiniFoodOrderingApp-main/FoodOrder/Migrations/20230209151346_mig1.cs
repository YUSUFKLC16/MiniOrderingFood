using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodOrder.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    ımgId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    ımgId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kebabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    ımgId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kebabs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "price", "type", "ımgId" },
                values: new object[,]
                {
                    { 1, 20f, "burger", 1 },
                    { 2, 22f, "burger", 2 },
                    { 3, 23f, "burger", 3 },
                    { 4, 25f, "burger", 4 },
                    { 5, 24f, "burger", 5 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "price", "type", "ımgId" },
                values: new object[,]
                {
                    { 1, 25f, "drink", 1 },
                    { 2, 25f, "drink", 2 },
                    { 3, 25f, "drink", 3 }
                });

            migrationBuilder.InsertData(
                table: "Kebabs",
                columns: new[] { "Id", "price", "type", "ımgId" },
                values: new object[,]
                {
                    { 1, 25f, "kebab", 1 },
                    { 2, 27f, "kebab", 3 },
                    { 3, 28f, "kebab", 4 },
                    { 4, 29f, "kebab", 5 },
                    { 5, 30f, "kebab", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Kebabs");
        }
    }
}
