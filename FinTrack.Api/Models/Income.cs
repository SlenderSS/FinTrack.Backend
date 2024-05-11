namespace FinTrack.Models;

public class Income
{
    public Income(string description,
        decimal incomeVolume,
        DateTime incomeDate)
    {
        Description = description;
        IncomeVolume = incomeVolume;
        IncomeDate = incomeDate;
    }
    public Income(
        string description, 
        decimal incomeVolume, 
        DateTime incomeDate,
        Budget budget, 
        IncomeCategory incomeCategory) : this(description, incomeVolume, incomeDate)
    {
        Budget = budget;
        IncomeCategory = incomeCategory;
    }

    public int Id { get; set; }
    public string Description { get; set; }
    public decimal IncomeVolume { get; set; }
    public DateTime IncomeDate { get; set; }

    public int IncomeCategoryId { get; set; }
    public IncomeCategory IncomeCategory { get; set; }

    public int BudgetId { get; set; }
    public Budget Budget{ get; set; }

}
