using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSolution.Data.Migrations
{
    public partial class updateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c18cce85-c859-476f-b73f-f149887ec6a8"),
                column: "ConcurrencyStamp",
                value: "6f841a6f-aef5-4696-a33b-ffbc12c9d723");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("348ebb33-349e-4d60-aae0-83ff6e31214e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16f10d9d-cd22-4d88-9b33-75e9c2bb0688", "AQAAAAEAACcQAAAAEDBxFdSOrallb3uQngAtGHXyhNxxFRhVYe3y1SUiCWjsOFRC/nkN6WidKp/bPumJKw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nam", "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Men Shirt", "men-shirt", "The shirt products for men", "The shirt products for men" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nữ", "ao-nu", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang women" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Women Shirt", "women-shirt", "The shirt products for women", "The shirt products for women" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "ao-so-mi-nam-trang-viet-tien", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "viet-tien-men-t-shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { new DateTime(2021, 9, 9, 0, 7, 43, 660, DateTimeKind.Local).AddTicks(5615), 100000m, 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c18cce85-c859-476f-b73f-f149887ec6a8"),
                column: "ConcurrencyStamp",
                value: "c1d8d264-1d4c-4d4e-b8b0-16dcf9c6f674");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("348ebb33-349e-4d60-aae0-83ff6e31214e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad680bfa-b22d-4a1a-81cb-36324b6f0b66", "AQAAAAEAACcQAAAAEAyYVm1JMc+RiaSgJWc+k1Gsvqmc7zM6vBrIlTmApgc0rn4qNrv8sMvkDDJPKTOaAQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Trái Cây", "trai-cay", "Sản phẩm trái cây", "Sản phẩm trái cây" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Fruit", "fruit", "The fruit products", "The fruit products" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Rau Củ Quả", "rau-cu-qua", "Rau Củ Quả", "Rau Củ Quả" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Vegetable", "vegetable", "Vegetable", "Vegetable" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Táo", "Táo", "Táo", "tao", "tao", "tao" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Apple", "Apple", "Apple", "apple", "apple", "apple" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { new DateTime(2021, 9, 8, 23, 26, 53, 860, DateTimeKind.Local).AddTicks(3057), 10m, 20m });
        }
    }
}
