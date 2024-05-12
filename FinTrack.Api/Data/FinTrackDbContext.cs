using FinTrack.Api.Configuration;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Data
{
    public class FinTrackDbContext(DbContextOptions<FinTrackDbContext> options) : DbContext(options)
    {
        public DbSet<Budget> Budgets{ get; set; }
        public DbSet<BudgetCategory> BudgetCategories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<IncomeCategory> IncomeCategories { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserBudgetCategory> UserBudgetCategories { get; set; }
        //public DbSet<UserExpenseCategory> UserExpenseCategories { get; set; }
        //public DbSet<UserIncomeCategory> UserIncomeCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BudgetCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BudgetConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new IncomeCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new IncomeConfiguration());
            modelBuilder.ApplyConfiguration(new IncomeCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new UserBudgetCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new UserExpenseCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new UserIncomeCategoryConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
