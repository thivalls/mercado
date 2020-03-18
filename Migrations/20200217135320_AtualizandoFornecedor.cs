using Microsoft.EntityFrameworkCore.Migrations;

namespace mercado.Migrations
{
    public partial class AtualizandoFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Fornecedores",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Fornecedores");
        }
    }
}
