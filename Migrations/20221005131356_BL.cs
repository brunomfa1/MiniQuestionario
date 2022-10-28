using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteInsereAutoConclusao.Migrations
{
    public partial class BL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoConcluAssiFoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocoloN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Assinatura = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoConcluAssiFoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoConcluEdifica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocoloN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipoUnidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Material = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RevestimentoExterno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RevestimentoInterno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Esquadria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Estrutura = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cobertura = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InstalacaoSanitaria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Forro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InstalacaoEletrica = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Piso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Limitacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoConcluEdifica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoConcluHabita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocoloN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoConclu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProjetoN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Requerente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Quadra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Lote = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataLicenca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConclusaoObra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoConcluHabita", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoConcluInfra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocoloN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Esgoto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AguaRede = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FossaSepticaSumidouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnergiaEletrica = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Iluminacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GuiasSarjetas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GaleriaPluvial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pavimentacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Calcamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Arborizacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LimpezaPublica = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ColetaLixo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TransporteColetivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoConcluInfra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoConcluMensoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocoloN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaTerreno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaConstruida = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QtdPecasInternas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QtdPecasExternas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NPavimentos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NUnidadeResidenciais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUnidadeComerciais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaTotalEdificacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RecuoFrontal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaxaOcupacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoConcluMensoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoConcluAssiFoto");

            migrationBuilder.DropTable(
                name: "AutoConcluEdifica");

            migrationBuilder.DropTable(
                name: "AutoConcluHabita");

            migrationBuilder.DropTable(
                name: "AutoConcluInfra");

            migrationBuilder.DropTable(
                name: "AutoConcluMensoes");
        }
    }
}
