using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class User : NamedEntity
{
    public required string Login { get; set; }
    public required string Password { get; set; }
    public ICollection<Budget>? Budgets { get; set; }
    public ICollection<BudgetCategory>? UserBudgetCategories { get; set; }
    public ICollection<ExpenseCategory>? UserExpenseCategories { get; set; }
    public ICollection<IncomeCategory>? UserIncomeCategories { get; set; }
}
