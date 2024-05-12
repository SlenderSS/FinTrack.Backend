﻿using FinTrack.Api.Models.Base;

namespace FinTrack.Models;

public class User : NamedEntity
{
    //public User(string userName, string login, string password) : base(userName)
    //{
    //    Login = login;
    //    Password = password;
    //}
    public string Login { get; set; }
    public string Password { get; set; }
    public ICollection<Budget>? Budgets { get; set; }
    public ICollection<BudgetCategory>? UserBudgetCategories { get; set; }
    public ICollection<ExpenseCategory>? UserExpenseCategories { get; set; }
    public ICollection<IncomeCategory>? UserIncomeCategories { get; set; }


}