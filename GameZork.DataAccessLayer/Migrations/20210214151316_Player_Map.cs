using Microsoft.EntityFrameworkCore.Migrations;

namespace GameZork.DataAccessLayer.Migrations
{
    public partial class Player_Map : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Cell",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cell_PlayerId",
                table: "Cell",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Player_PlayerId",
                table: "Cell",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Player_PlayerId",
                table: "Cell");

            migrationBuilder.DropIndex(
                name: "IX_Cell_PlayerId",
                table: "Cell");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Cell");
        }
    }
}
