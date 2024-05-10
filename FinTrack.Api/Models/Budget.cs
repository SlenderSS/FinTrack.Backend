

namespace FinTrack.Models;

public class Budget
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }

    public decimal MyProperty { get; set; }


    public Guid BudgetCategoryId { get; set; }
    public BudgetCategory BudgetCategory { get; set; }

    public Guid CurrencyId { get; set; }
    public Currency Currency { get; set; }

}
