using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSolution.Data.Migrations
{
    public partial class updateImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c18cce85-c859-476f-b73f-f149887ec6a8"),
                column: "ConcurrencyStamp",
                value: "9676ba33-0e4b-4734-b1a3-4da7494d61c1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("348ebb33-349e-4d60-aae0-83ff6e31214e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ffeef84-6e9a-4e52-b2e2-fa61352b0793", "AQAAAAEAACcQAAAAEJN6dtQXWeeY33KstzBkiSmh6XIdCIWN+YQKaCArf2Sisv8oBocq2UcaJb4knuQ2OA==" });

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 10, 19, 19, 59, 288, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 0, 7, 43, 660, DateTimeKind.Local).AddTicks(5615));
        }
    }
}
