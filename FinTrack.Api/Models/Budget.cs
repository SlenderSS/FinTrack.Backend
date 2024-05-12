
using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class Budget : NamedEntity
{
    public decimal AmountOfMoney { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime CreationDate { get; set; }
    public int BudgetCategoryId { get; set; }
    public BudgetCategory BudgetCategory { get; set; }
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
    public ICollection<Income>? Incomes { get; set; }
    public ICollection<Expense>? Expences { get; set; }


}

