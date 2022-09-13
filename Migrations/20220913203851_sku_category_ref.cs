using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class sku_category_ref : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_SKUs_Orders_order_idId",
                table: "Order_SKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_SKUs_SKUs_SKU_IdId",
                table: "Order_SKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_Customer_IdId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUs_SKU_Categories_Category_idId",
                table: "SKUs");

            migrationBuilder.DropIndex(
                name: "IX_SKUs_Category_idId",
                table: "SKUs");

            migrationBuilder.DropIndex(
                name: "IX_Order_SKUs_SKU_IdId",
                table: "Order_SKUs");

            migrationBuilder.DropColumn(
                name: "SKU_IdId",
                table: "Order_SKUs");

            migrationBuilder.RenameColumn(
                name: "Category_idId",
                table: "SKUs",
                newName: "CategotyId");

            migrationBuilder.RenameColumn(
                name: "Customer_IdId",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Customer_IdId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameColumn(
                name: "order_idId",
                table: "Order_SKUs",
                newName: "order_refId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_SKUs_order_idId",
                table: "Order_SKUs",
                newName: "IX_Order_SKUs_order_refId");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "SKUs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "skuId",
                table: "Order_SKUs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SKUs_CategoryId",
                table: "SKUs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SKUs_skuId",
                table: "Order_SKUs",
                column: "skuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_SKUs_Orders_order_refId",
                table: "Order_SKUs",
                column: "order_refId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_SKUs_SKUs_skuId",
                table: "Order_SKUs",
                column: "skuId",
                principalTable: "SKUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUs_SKU_Categories_CategoryId",
                table: "SKUs",
                column: "CategoryId",
                principalTable: "SKU_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_SKUs_Orders_order_refId",
                table: "Order_SKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_SKUs_SKUs_skuId",
                table: "Order_SKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUs_SKU_Categories_CategoryId",
                table: "SKUs");

            migrationBuilder.DropIndex(
                name: "IX_SKUs_CategoryId",
                table: "SKUs");

            migrationBuilder.DropIndex(
                name: "IX_Order_SKUs_skuId",
                table: "Order_SKUs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SKUs");

            migrationBuilder.DropColumn(
                name: "skuId",
                table: "Order_SKUs");

            migrationBuilder.RenameColumn(
                name: "CategotyId",
                table: "SKUs",
                newName: "Category_idId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "Customer_IdId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                newName: "IX_Orders_Customer_IdId");

            migrationBuilder.RenameColumn(
                name: "order_refId",
                table: "Order_SKUs",
                newName: "order_idId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_SKUs_order_refId",
                table: "Order_SKUs",
                newName: "IX_Order_SKUs_order_idId");

            migrationBuilder.AddColumn<string>(
                name: "SKU_IdId",
                table: "Order_SKUs",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SKUs_Category_idId",
                table: "SKUs",
                column: "Category_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SKUs_SKU_IdId",
                table: "Order_SKUs",
                column: "SKU_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_SKUs_Orders_order_idId",
                table: "Order_SKUs",
                column: "order_idId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_SKUs_SKUs_SKU_IdId",
                table: "Order_SKUs",
                column: "SKU_IdId",
                principalTable: "SKUs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_Customer_IdId",
                table: "Orders",
                column: "Customer_IdId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUs_SKU_Categories_Category_idId",
                table: "SKUs",
                column: "Category_idId",
                principalTable: "SKU_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
