
namespace FinTrack.Models;

public class Budget
{
    public Budget(string title, decimal amountOfMoney, User user, BudgetCategory budgetCategory, Currency currency)
    {
        Title = title;
        AmountOfMoney = amountOfMoney;
        User = user;
        BudgetCategory = budgetCategory;
        Currency = currency;
    }
    public int Id { get; set; } 
    public string Title { get; set; }

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

