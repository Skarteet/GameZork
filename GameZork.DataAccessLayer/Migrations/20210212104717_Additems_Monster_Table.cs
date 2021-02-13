using Microsoft.EntityFrameworkCore.Migrations;

namespace GameZork.DataAccessLayer.Migrations
{
    public partial class Additems_Monster_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IDCell",
                table: "Player",
                newName: "Power");

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MissRate = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    MaxHP = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HpRestoreValue = table.Column<int>(type: "int", nullable: true),
                    AttackBoost = table.Column<int>(type: "int", nullable: true),
                    DefenseBoost = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemId",
                table: "Item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PlayerId",
                table: "Item",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Monster");

            migrationBuilder.DropTable(
                name: "ObjectType");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "Power",
                table: "Player",
                newName: "IDCell");
        }
    }
}
