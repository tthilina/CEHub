using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEH.Infrastructure.Migrations
{
    public partial class Add_Months : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplyMonths",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "Apr",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aug",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Dec",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Feb",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Jan",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Jul",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Jun",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Mar",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "May",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Nov",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Oct",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sep",
                table: "Products",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apr",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Aug",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Dec",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Feb",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Jan",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Jul",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Jun",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Mar",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "May",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Nov",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Oct",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Sep",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "SupplyMonths",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
