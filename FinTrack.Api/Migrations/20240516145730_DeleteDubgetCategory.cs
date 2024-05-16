using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinTrack.Api.Migrations
{
    /// <inheritdoc />
    public partial class DeleteDubgetCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_BudgetCategories_BudgetCategoryId",
                table: "Budgets");

            migrationBuilder.DropTable(
                name: "BudgetCategories");

            migrationBuilder.DropIndex(
                name: "IX_Budgets_BudgetCategoryId",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BudgetCategoryId",
                table: "Budgets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BudgetCategoryId",
                table: "Budgets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BudgetCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetCategories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_BudgetCategoryId",
                table: "Budgets",
                column: "BudgetCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategories_UserId",
                table: "BudgetCategories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_BudgetCategories_BudgetCategoryId",
                table: "Budgets",
                column: "BudgetCategoryId",
                principalTable: "BudgetCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
