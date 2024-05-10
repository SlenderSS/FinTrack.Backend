namespace FinTrack.Models;

public class Income
{
    public Income(string title, decimal incomeVolume, DateTime incomeDate, IncomeCategory incomeCategory)
    {
        Title = title;
        IncomeVolume = incomeVolume;
        IncomeDate = incomeDate;
        IncomeCategory = incomeCategory;
    }

    public Guid Id { get; set; }
    public decimal IncomeVolume { get; set; }
    public string Title { get; set; }
    public DateTime IncomeDate { get; set; }

    public Guid IncomeCategoryId { get; set; }
    public IncomeCategory IncomeCategory { get; set; }

}
