using Microsoft.EntityFrameworkCore.Migrations;

namespace VacunaApp.Migrations
{
    public partial class quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "vacunaRecibidaDos",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vacunaRecibidaDos",
                table: "Personas");
        }
    }
}
