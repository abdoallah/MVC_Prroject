using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Project.EF.Migrations
{
    public partial class Abdallahseconone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gusts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gusts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    menusId = table.Column<int>(type: "int", nullable: true),
                    menueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menus_menus_menusId",
                        column: x => x.menusId,
                        principalTable: "menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_menus_menusId",
                table: "menus",
                column: "menusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gusts");

            migrationBuilder.DropTable(
                name: "menus");
        }
    }
}
