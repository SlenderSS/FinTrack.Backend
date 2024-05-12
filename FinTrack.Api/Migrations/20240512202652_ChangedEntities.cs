using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinTrack.Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "IncomeCategories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ExpenseCategories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Currencies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Budgets",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "BudgetCategories",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "IncomeCategories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ExpenseCategories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Currencies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Budgets",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BudgetCategories",
                newName: "Title");
        }
    }
}
