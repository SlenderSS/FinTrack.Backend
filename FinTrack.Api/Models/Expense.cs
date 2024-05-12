using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class Expense : Entity
{
    public string Description { get; set; }
    public decimal ExpenseVolume { get; set; }
    public DateTime ExpenseDate { get; set; }
    public int BudgetId { get; set; }
    public Budget Budget { get; set; }
    public int ExpenceCategoryId { get; set; }
    public ExpenseCategory ExpenseCategory { get; set; }


}
