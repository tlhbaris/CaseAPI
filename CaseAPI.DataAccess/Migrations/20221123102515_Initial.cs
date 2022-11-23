using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseAPI.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WithSail = table.Column<bool>(type: "bit", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Headlights = table.Column<bool>(type: "bit", nullable: false),
                    Wheels = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Headlights = table.Column<bool>(type: "bit", nullable: false),
                    Wheels = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Color", "Length", "WithSail" },
                values: new object[,]
                {
                    { 1, "orange", 3.7m, true },
                    { 2, "pink", 12.6m, true },
                    { 3, "brown", 7.6m, false },
                    { 4, "black", 1.2m, false }
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Capacity", "Color", "Headlights", "Wheels" },
                values: new object[,]
                {
                    { 1, 27, "blue", true, 6 },
                    { 2, 9700, "yellow", false, 8 },
                    { 3, 16, "indigo", true, 4 },
                    { 4, 27, "blue", false, 6 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Headlights", "Wheels" },
                values: new object[,]
                {
                    { 1, "black", true, 4 },
                    { 2, "yellow", false, 4 },
                    { 3, "blue", true, 4 },
                    { 4, "yellow", false, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boats_Id",
                table: "Boats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Buses_Id",
                table: "Buses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_Id",
                table: "Cars",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
