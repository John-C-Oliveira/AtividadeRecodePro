using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaSemStress.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anuncios",
                columns: table => new
                {
                    AnuncioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAnuncio = table.Column<bool>(type: "bit", nullable: false),
                    ValorAnuncio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NomeAnuncio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataRetorno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastroAnuncio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FKDestinoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncios", x => x.AnuncioID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CpfCliente = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    TelefoneCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IMGCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NascimentoCliente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastroCliente = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    DestinoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QtdadePessoa = table.Column<int>(type: "int", nullable: false),
                    IMGDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UFDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastroDestino = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.DestinoID);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ReservaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKDestinoID = table.Column<int>(type: "int", nullable: false),
                    FKClienteID = table.Column<int>(type: "int", nullable: false),
                    FKAnuncioID = table.Column<int>(type: "int", nullable: false),
                    DataCadastroReserva = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Destinos");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
