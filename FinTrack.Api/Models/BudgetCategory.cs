using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class BudgetCategory : NamedEntity
{
    public int? UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Budget>? Budgets { get; set; }
}

