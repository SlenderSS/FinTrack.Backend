using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class ExpenseCategory : NamedEntity
{ 
    //public ExpenseCategory(string title) : base(title)
    //{
    //}

    public int? UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Expense>? Expenses{ get; set; }
}
