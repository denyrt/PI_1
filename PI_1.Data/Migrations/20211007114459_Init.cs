using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PI_1.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderEntities_CarEntities_CarId",
                        column: x => x.CarId,
                        principalTable: "CarEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderEntities_CarId",
                table: "OrderEntities",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderEntities");

            migrationBuilder.DropTable(
                name: "CarEntities");
        }
    }
}
