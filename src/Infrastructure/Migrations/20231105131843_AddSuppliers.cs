using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEH.Infrastructure.Migrations
{
    public partial class AddSuppliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEnglish = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    NameSinhala = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    NameTamil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    ContactNumber1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ContactNumber2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Suppliers_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Suppliers_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    NameEnglish = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    NameSinhala = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    NameTamil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    ProductSubCategoryId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    SupplyQuantity = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    OtherDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "NameEnglish", "NameSinhala", "NameTamil" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4088), new TimeSpan(0, 0, 0, 0, 0)), "Tea", "", "" },
                    { 2, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4093), new TimeSpan(0, 0, 0, 0, 0)), "Rubber", "", "" },
                    { 3, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4097), new TimeSpan(0, 0, 0, 0, 0)), "Spices", "", "" },
                    { 4, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), "Food, Feed & Beverage", "", "" },
                    { 5, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4102), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 0, 0, 0, 0)), "Electrical & Electronic", "", "" },
                    { 6, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 0, 0, 0, 0)), "Apparel & Textile", "", "" },
                    { 7, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4108), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, 0, 0, 0, 0)), "Gem & Jewellery", "", "" },
                    { 8, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4111), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 138, DateTimeKind.Unspecified).AddTicks(4112), new TimeSpan(0, 0, 0, 0, 0)), "Other", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "NameEnglish", "NameSinhala", "NameTamil", "ProductCategoryId" },
                values: new object[] { 1, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 142, DateTimeKind.Unspecified).AddTicks(6725), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 142, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, 0, 0, 0, 0)), "Tea bags", "", "", 1 });

            migrationBuilder.InsertData(
                table: "ProductSubCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "NameEnglish", "NameSinhala", "NameTamil", "ProductCategoryId" },
                values: new object[] { 2, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 142, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, 0, 0, 0, 0)), "", false, null, new DateTimeOffset(new DateTime(2023, 11, 5, 13, 18, 43, 142, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, 0, 0, 0, 0)), "Green tea", "", "", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Products",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CityId",
                table: "Suppliers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_DistrictId",
                table: "Suppliers",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_ProvinceId",
                table: "Suppliers",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "ProductSubCategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
