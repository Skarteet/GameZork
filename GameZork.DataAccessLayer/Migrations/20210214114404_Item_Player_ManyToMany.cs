using Microsoft.EntityFrameworkCore.Migrations;

namespace GameZork.DataAccessLayer.Migrations
{
    public partial class Item_Player_ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ObjectType_ObjectTypeId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Player_PlayerId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "ObjectType");

            migrationBuilder.DropIndex(
                name: "IX_Item_ObjectTypeId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_PlayerId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Item",
                newName: "HpRestoreValue");

            migrationBuilder.RenameColumn(
                name: "ObjectTypeId",
                table: "Item",
                newName: "DefenseBoost");

            migrationBuilder.AddColumn<int>(
                name: "AttackBoost",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemPlayer",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    PlayersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPlayer", x => new { x.ItemsId, x.PlayersId });
                    table.ForeignKey(
                        name: "FK_ItemPlayer_Item_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPlayer_Player_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPlayer_PlayersId",
                table: "ItemPlayer",
                column: "PlayersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPlayer");

            migrationBuilder.DropColumn(
                name: "AttackBoost",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "HpRestoreValue",
                table: "Item",
                newName: "PlayerId");

            migrationBuilder.RenameColumn(
                name: "DefenseBoost",
                table: "Item",
                newName: "ObjectTypeId");

            migrationBuilder.CreateTable(
                name: "ObjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttackBoost = table.Column<int>(type: "int", nullable: true),
                    DefenseBoost = table.Column<int>(type: "int", nullable: true),
                    HpRestoreValue = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ObjectTypeId",
                table: "Item",
                column: "ObjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PlayerId",
                table: "Item",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ObjectType_ObjectTypeId",
                table: "Item",
                column: "ObjectTypeId",
                principalTable: "ObjectType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Player_PlayerId",
                table: "Item",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
