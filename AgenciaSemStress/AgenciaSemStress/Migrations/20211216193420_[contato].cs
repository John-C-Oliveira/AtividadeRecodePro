using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaSemStress.Migrations
{
    public partial class contato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FKDestinoID",
                table: "Anuncios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FKDestinoID",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
