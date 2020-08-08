using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Storing.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToppingModel_Pizzas_PizzaModelId",
                table: "ToppingModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToppingModel",
                table: "ToppingModel");

            migrationBuilder.RenameTable(
                name: "ToppingModel",
                newName: "Toppings");

            migrationBuilder.RenameIndex(
                name: "IX_ToppingModel_PizzaModelId",
                table: "Toppings",
                newName: "IX_Toppings_PizzaModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_PizzaModelId",
                table: "Toppings",
                column: "PizzaModelId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_PizzaModelId",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "ToppingModel");

            migrationBuilder.RenameIndex(
                name: "IX_Toppings_PizzaModelId",
                table: "ToppingModel",
                newName: "IX_ToppingModel_PizzaModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToppingModel",
                table: "ToppingModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingModel_Pizzas_PizzaModelId",
                table: "ToppingModel",
                column: "PizzaModelId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
