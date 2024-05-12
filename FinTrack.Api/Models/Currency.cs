using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class Currency : NamedEntity
{
    //public Currency(string title, char symbol) : base(title)
    //{
    //    Symbol = symbol;
    //}
    public char Symbol { get; set; }

    public ICollection<Budget>? Budgets { get; set; }
}
