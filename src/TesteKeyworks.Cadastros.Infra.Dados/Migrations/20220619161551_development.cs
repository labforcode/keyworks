using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TesteKeyworks.Cadastros.Infra.Dados.Migrations
{
    public partial class development : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "clientes",
                schema: "public",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    razao_social = table.Column<string>(type: "varchar(140)", nullable: false),
                    ativo = table.Column<bool>(type: "boolean", nullable: false),
                    planta_id = table.Column<int>(type: "integer", nullable: false),
                    tipo_cliente = table.Column<int>(type: "integer", nullable: false),
                    codigo_material = table.Column<int>(type: "integer", nullable: false),
                    responsavel_nome = table.Column<string>(type: "varchar(140)", nullable: false),
                    responsavel_email = table.Column<string>(type: "varchar(80)", nullable: false),
                    ddi = table.Column<string>(type: "varchar(2)", nullable: false),
                    ddd = table.Column<string>(type: "varchar(3)", nullable: false),
                    telefone = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes",
                schema: "public");
        }
    }
}
