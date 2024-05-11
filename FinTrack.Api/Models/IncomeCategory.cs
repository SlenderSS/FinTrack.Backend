namespace FinTrack.Models;

public class IncomeCategory
{
    public IncomeCategory(string title)
    {
        Title = title;
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Income>? Incomes { get; set; }
}
