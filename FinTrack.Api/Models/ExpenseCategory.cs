﻿namespace FinTrack.Models;

public class ExpenseCategory
{
    public ExpenseCategory(string title)
    {
        Title = title;
    }
    public int Id { get; set; }
    public string Title { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Expense>? Expenses{ get; set; }
}
