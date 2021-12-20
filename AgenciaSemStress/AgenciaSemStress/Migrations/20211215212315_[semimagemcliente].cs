using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaSemStress.Migrations
{
    public partial class semimagemcliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMGCliente",
                table: "Clientes");

            migrationBuilder.AddColumn<bool>(
                name: "IsReserva",
                table: "Reservas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserva",
                table: "Reservas");

            migrationBuilder.AddColumn<string>(
                name: "IMGCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
