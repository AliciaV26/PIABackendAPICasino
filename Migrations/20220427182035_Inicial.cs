using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPICasino.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rifas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero33 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero36 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero37 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero38 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero39 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero40 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero41 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero42 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero43 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero44 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero45 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero46 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero47 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero48 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero49 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero50 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero51 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero52 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero53 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero54 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rifas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Rifas");
        }
    }
}
