
using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class Budget : NamedEntity
{
    public required decimal AmountOfMoney { get; set; }
    public required int UserId { get; set; }
    public required User User { get; set; }
    public required DateTime CreationDate { get; set; }
    public required int CurrencyId { get; set; }
    public required Currency Currency { get; set; }
    public ICollection<Income> Incomes { get; set; }
    public ICollection<Expense> Expences { get; set; }


}

