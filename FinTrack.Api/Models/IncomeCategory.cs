namespace FinTrack.Models;

public class IncomeCategory
{
    public IncomeCategory(string title)
    {
        Title = title;
    }
    public Guid Id { get; set; }
    public string Title { get; set; }
}
