using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteKeyworks.Cadastros.Infra.Dados.Migrations
{
    public partial class development : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ddd",
                schema: "public",
                table: "clientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ddd",
                schema: "public",
                table: "clientes",
                type: "varchar(3)",
                nullable: false,
                defaultValue: "");
        }
    }
}
