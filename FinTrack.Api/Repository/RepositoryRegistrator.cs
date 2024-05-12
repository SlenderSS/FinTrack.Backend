using FinTrack.Api.Repository.Implementations;
using FinTrack.Api.Repository.Interfaces;
using FinTrack.Models;

namespace FinTrack.Api.Repository
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDb(this IServiceCollection services) => services
            .AddTransient<IRepository<Budget>, DbRepository<Budget>>()
            .AddTransient<IRepository<BudgetCategory>, DbRepository<BudgetCategory>>()
            .AddTransient<IRepository<Currency>, DbRepository<Currency>>()
            .AddTransient<IRepository<Expense>, DbRepository<Expense>>()
            .AddTransient<IRepository<ExpenseCategory>, DbRepository<ExpenseCategory>>()
            .AddTransient<IRepository<Income>, DbRepository<Income>>()
            .AddTransient<IRepository<IncomeCategory>, DbRepository<IncomeCategory>>()
            .AddTransient<IRepository<User>, DbRepository<User>>();
    }
}
