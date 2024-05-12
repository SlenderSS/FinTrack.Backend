using FinTrack.Api.Models.Base;

namespace FinTrack.Models;
public class Income : NamedEntity
{
    public required string Description { get; set; }
    public required decimal IncomeVolume { get; set; }
    public required DateTime IncomeDate { get; set; }
    public required int IncomeCategoryId { get; set; }
    public required IncomeCategory IncomeCategory { get; set; }
    public required int BudgetId { get; set; }
    public required Budget Budget{ get; set; }

}
