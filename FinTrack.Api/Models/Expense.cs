using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class Expense : NamedEntity
{
    public required string Description { get; set; }
    public decimal ExpenseVolume { get; set; }
    public DateTime ExpenseDate { get; set; }
    public int BudgetId { get; set; }
    public required Budget Budget { get; set; }
    public int ExpenceCategoryId { get; set; }
    public required ExpenseCategory ExpenseCategory { get; set; }


}
