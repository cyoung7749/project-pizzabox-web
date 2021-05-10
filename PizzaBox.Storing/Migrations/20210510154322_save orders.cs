using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class saveorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Crusts_CrustEntityId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Orders_OrderEntityId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Sizes_SizeEntityId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzasEntityId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza");

            migrationBuilder.RenameTable(
                name: "Pizza",
                newName: "Pizzas");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_SizeEntityId",
                table: "Pizzas",
                newName: "IX_Pizzas_SizeEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_OrderEntityId",
                table: "Pizzas",
                newName: "IX_Pizzas_OrderEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_CrustEntityId",
                table: "Pizzas",
                newName: "IX_Pizzas_CrustEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityId",
                table: "Pizzas",
                column: "CrustEntityId",
                principalTable: "Crusts",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Orders_OrderEntityId",
                table: "Pizzas",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId",
                table: "Pizzas",
                column: "SizeEntityId",
                principalTable: "Sizes",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Pizzas_PizzasEntityId",
                table: "PizzaTopping",
                column: "PizzasEntityId",
                principalTable: "Pizzas",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Orders_OrderEntityId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Pizzas_PizzasEntityId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "Pizza");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_SizeEntityId",
                table: "Pizza",
                newName: "IX_Pizza_SizeEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_OrderEntityId",
                table: "Pizza",
                newName: "IX_Pizza_OrderEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_CrustEntityId",
                table: "Pizza",
                newName: "IX_Pizza_CrustEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Crusts_CrustEntityId",
                table: "Pizza",
                column: "CrustEntityId",
                principalTable: "Crusts",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Orders_OrderEntityId",
                table: "Pizza",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Sizes_SizeEntityId",
                table: "Pizza",
                column: "SizeEntityId",
                principalTable: "Sizes",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzasEntityId",
                table: "PizzaTopping",
                column: "PizzasEntityId",
                principalTable: "Pizza",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
