using Microsoft.EntityFrameworkCore.Migrations;

namespace debase.Migrations
{
    public partial class alphaa1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "defilms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rated = table.Column<int>(type: "int", nullable: false),
                    categorie = table.Column<int>(type: "int", nullable: false),
                    cijfer = table.Column<int>(type: "int", nullable: false),
                    naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uitkomst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    krtomschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lengte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_defilms", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "defilms");
        }
    }
}
