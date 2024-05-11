namespace FinTrack.Models;

public class Expense
{
    public Expense(
        string description,
        decimal expenseVolume,
        DateTime expenseDate,
        Budget budget, 
        ExpenseCategory expenseCategory)
    {
        Description = description;
        ExpenseVolume = expenseVolume;
        ExpenseDate = expenseDate;
        Budget = budget;
        ExpenseCategory = expenseCategory;
    }

    public int Id { get; set; }
    public string Description { get; set; }
    public decimal ExpenseVolume { get; set; }
    public DateTime ExpenseDate { get; set; }

    public int BudgetId { get; set; }
    public Budget Budget { get; set; }

    public int ExpenceCategoryId { get; set; }
    public ExpenseCategory ExpenseCategory { get; set; }


}
