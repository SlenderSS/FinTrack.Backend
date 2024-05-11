namespace FinTrack.Models;

public class Currency
{
    public Currency(string title, char symbol)
    {
        Title = title;
        Symbol = symbol;
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public char Symbol { get; set; }

    public ICollection<Budget>? Budgets { get; set; }
}
