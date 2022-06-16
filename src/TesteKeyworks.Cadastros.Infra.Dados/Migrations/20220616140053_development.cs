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
                    responsavel_nome = table.Column<string>(type: "varchar(140)", nullable: false),
                    responsavel_email = table.Column<string>(type: "varchar(80)", nullable: false),
                    telefone_ddi = table.Column<string>(type: "varchar(2)", nullable: false),
                    telefone_ddd = table.Column<string>(type: "varchar(3)", nullable: false),
                    telefone_numero = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "materiais",
                schema: "public",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(120)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materiais", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "clientes_materiais",
                schema: "public",
                columns: table => new
                {
                    ClientesCodigo = table.Column<int>(type: "integer", nullable: false),
                    MateriaisCodigo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes_materiais", x => new { x.ClientesCodigo, x.MateriaisCodigo });
                    table.ForeignKey(
                        name: "FK_clientes_materiais_clientes_ClientesCodigo",
                        column: x => x.ClientesCodigo,
                        principalSchema: "public",
                        principalTable: "clientes",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clientes_materiais_materiais_MateriaisCodigo",
                        column: x => x.MateriaisCodigo,
                        principalSchema: "public",
                        principalTable: "materiais",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_materiais_MateriaisCodigo",
                schema: "public",
                table: "clientes_materiais",
                column: "MateriaisCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes_materiais",
                schema: "public");

            migrationBuilder.DropTable(
                name: "clientes",
                schema: "public");

            migrationBuilder.DropTable(
                name: "materiais",
                schema: "public");
        }
    }
}
