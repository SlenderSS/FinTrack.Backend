namespace FinTrack.Models;

public class BudgetCategory
{
    public BudgetCategory(string title)
    {
        Title = title;
    }

    public int Id { get; set; }
    public string Title { get; set; }

    public ICollection<Budget> Budgets { get; set; }
}

