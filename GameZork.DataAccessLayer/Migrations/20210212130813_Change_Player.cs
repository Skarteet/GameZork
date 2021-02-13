using Microsoft.EntityFrameworkCore.Migrations;

namespace GameZork.DataAccessLayer.Migrations
{
    public partial class Change_Player : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_ItemId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Item",
                newName: "ObjectTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ItemId",
                table: "Item",
                newName: "IX_Item_ObjectTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ObjectType_ObjectTypeId",
                table: "Item",
                column: "ObjectTypeId",
                principalTable: "ObjectType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ObjectType_ObjectTypeId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "ObjectTypeId",
                table: "Item",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ObjectTypeId",
                table: "Item",
                newName: "IX_Item_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_ItemId",
                table: "Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
