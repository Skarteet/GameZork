using Microsoft.EntityFrameworkCore.Migrations;

namespace GameZork.DataAccessLayer.Migrations
{
    public partial class AddPlayer_Cell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Damage",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Damage",
                table: "Weapons");
        }
    }
}
