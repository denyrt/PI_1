using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PI_1.Data.Migrations
{
    public partial class AddressUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarEntities",
                keyColumn: "Id",
                keyValue: new Guid("39a9c96a-fc78-433c-a337-e5e98e114ebc"));

            migrationBuilder.DeleteData(
                table: "CarEntities",
                keyColumn: "Id",
                keyValue: new Guid("3a884ef5-1643-4c40-8f80-e92e0dee96f6"));

            migrationBuilder.DeleteData(
                table: "CarEntities",
                keyColumn: "Id",
                keyValue: new Guid("4b0e945f-3d24-441d-9174-dd924f93b90a"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "OrderEntities",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "CarEntities",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("07c2b12a-44d5-4413-baf2-d379720bd96b"), "Tesla 1", 1000.0 });

            migrationBuilder.InsertData(
                table: "CarEntities",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("611750aa-da8b-458f-bef5-69ec194cc167"), "Tesla 2", 2000.0 });

            migrationBuilder.InsertData(
                table: "CarEntities",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("c5c1f5ea-e74a-41fc-96f3-040e58ab9a77"), "Tesla X", 5000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarEntities",
                keyColumn: "Id",
                keyValue: new Guid("07c2b12a-44d5-4413-baf2-d379720bd96b"));

            migrationBuilder.DeleteData(
                table: "CarEntities",
                keyColumn: "Id",
                keyValue: new Guid("611750aa-da8b-458f-bef5-69ec194cc167"));

            migrationBuilder.DeleteData(
                table: "CarEntities",
                keyColumn: "Id",
                keyValue: new Guid("c5c1f5ea-e74a-41fc-96f3-040e58ab9a77"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "OrderEntities");

            migrationBuilder.InsertData(
                table: "CarEntities",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("4b0e945f-3d24-441d-9174-dd924f93b90a"), "Tesla 1", 1000.0 });

            migrationBuilder.InsertData(
                table: "CarEntities",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("3a884ef5-1643-4c40-8f80-e92e0dee96f6"), "Tesla 2", 2000.0 });

            migrationBuilder.InsertData(
                table: "CarEntities",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("39a9c96a-fc78-433c-a337-e5e98e114ebc"), "Tesla X", 5000.0 });
        }
    }
}
