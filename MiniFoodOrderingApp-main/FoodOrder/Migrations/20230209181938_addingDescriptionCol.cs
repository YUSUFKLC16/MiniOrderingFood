using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrder.Migrations
{
    /// <inheritdoc />
    public partial class addingDescriptionCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "descriptions",
                table: "Kebabs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descriptions",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descriptions",
                table: "Burgers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 1,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 2,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 3,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 4,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 5,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kebabs",
                keyColumn: "Id",
                keyValue: 1,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kebabs",
                keyColumn: "Id",
                keyValue: 2,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kebabs",
                keyColumn: "Id",
                keyValue: 3,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kebabs",
                keyColumn: "Id",
                keyValue: 4,
                column: "descriptions",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kebabs",
                keyColumn: "Id",
                keyValue: 5,
                column: "descriptions",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descriptions",
                table: "Kebabs");

            migrationBuilder.DropColumn(
                name: "descriptions",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "descriptions",
                table: "Burgers");
        }
    }
}
