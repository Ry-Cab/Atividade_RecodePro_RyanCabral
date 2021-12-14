using Microsoft.EntityFrameworkCore.Migrations;

namespace Trip_Show_AgenciaDeViagens.Migrations
{
    public partial class Incial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_CLIENTE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    EMAIL_CLIENTE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CIDADE_CLIENTE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ESTADO_CLIENTE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DATA_IDA = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DATA_VOLTA = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DATA_NASC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID_CLIENTE);
                });

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    ID_DESTINO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIDADE_DESTINO = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ESTADO_DESTINO = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PAIS_DESTINO = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PRECO_DESTINO = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.ID_DESTINO);
                });

            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    ID_PASSAGEM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATA_COMPRA = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ClienteID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DestinoID_DESTINO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.ID_PASSAGEM);
                    table.ForeignKey(
                        name: "FK_Passagens_Clientes_ClienteID_CLIENTE",
                        column: x => x.ClienteID_CLIENTE,
                        principalTable: "Clientes",
                        principalColumn: "ID_CLIENTE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Passagens_Destinos_DestinoID_DESTINO",
                        column: x => x.DestinoID_DESTINO,
                        principalTable: "Destinos",
                        principalColumn: "ID_DESTINO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_ClienteID_CLIENTE",
                table: "Passagens",
                column: "ClienteID_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_DestinoID_DESTINO",
                table: "Passagens",
                column: "DestinoID_DESTINO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passagens");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
