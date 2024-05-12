using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class IncomeCategory : NamedEntity
{
    public int? UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Income>? Incomes { get; set; }
}
