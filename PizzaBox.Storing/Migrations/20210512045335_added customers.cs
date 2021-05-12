using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PizzaBox.Storing.Migrations
{
    public partial class addedcustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CustomersEntityId",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.EntityId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { 1L, "Mario Pardi" },
                    { 2L, "Mario Kart" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersEntityId",
                table: "Orders",
                column: "CustomersEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomersEntityId",
                table: "Orders",
                column: "CustomersEntityId",
                principalTable: "Customers",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomersEntityId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomersEntityId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomersEntityId",
                table: "Orders");
        }
    }
}
