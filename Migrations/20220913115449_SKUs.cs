using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class SKUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKU_SKU_Categories_Category_idId",
                table: "SKU");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKU",
                table: "SKU");

            migrationBuilder.RenameTable(
                name: "SKU",
                newName: "SKUs");

            migrationBuilder.RenameIndex(
                name: "IX_SKU_Category_idId",
                table: "SKUs",
                newName: "IX_SKUs_Category_idId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SKUs",
                table: "SKUs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SKUs_SKU_Categories_Category_idId",
                table: "SKUs",
                column: "Category_idId",
                principalTable: "SKU_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKUs_SKU_Categories_Category_idId",
                table: "SKUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKUs",
                table: "SKUs");

            migrationBuilder.RenameTable(
                name: "SKUs",
                newName: "SKU");

            migrationBuilder.RenameIndex(
                name: "IX_SKUs_Category_idId",
                table: "SKU",
                newName: "IX_SKU_Category_idId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SKU",
                table: "SKU",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SKU_SKU_Categories_Category_idId",
                table: "SKU",
                column: "Category_idId",
                principalTable: "SKU_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
