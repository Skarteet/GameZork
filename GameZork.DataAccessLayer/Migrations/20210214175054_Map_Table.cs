using Microsoft.EntityFrameworkCore.Migrations;

namespace GameZork.DataAccessLayer.Migrations
{
    public partial class Map_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Player_PlayerId",
                table: "Cell");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Cell",
                newName: "MapId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_PlayerId",
                table: "Cell",
                newName: "IX_Cell_MapId");

            migrationBuilder.AddColumn<int>(
                name: "MapId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_MapId",
                table: "Player",
                column: "MapId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Map_MapId",
                table: "Cell",
                column: "MapId",
                principalTable: "Map",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Map_MapId",
                table: "Player",
                column: "MapId",
                principalTable: "Map",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Map_MapId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Map_MapId",
                table: "Player");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropIndex(
                name: "IX_Player_MapId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "MapId",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "MapId",
                table: "Cell",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_MapId",
                table: "Cell",
                newName: "IX_Cell_PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Player_PlayerId",
                table: "Cell",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
