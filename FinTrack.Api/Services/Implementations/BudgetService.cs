using CSharpFunctionalExtensions;
using CSharpFunctionalExtensions.ValueTasks;
using FinTrack.Api.Repository.Interfaces;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Services.Implementations
{
    public class BudgetService : IBudgetService
    {
        private readonly IRepository<Budget> _budgetRepository;

        public BudgetService(IRepository<Budget> budgetRepository)
        {
            this._budgetRepository = budgetRepository;
        }
        public async Task<Result> CreateBudgetAsync(Budget budgetCreate)
        {
            if(budgetCreate == null) return Result.Failure("Null reference object");

            var budget = _budgetRepository
                .Items
                .FirstOrDefault(
                x => x.UserId == budgetCreate.UserId && 
                x.Name.Trim().ToUpper() == budgetCreate.Name.Trim().ToUpper());

            if(budget != null)
            {
                return Result.Failure("A budget with the same name is already exists");
            }

            if(!(await _budgetRepository.CreateAsync(budgetCreate))) 
            {
                return Result.Failure("Something went wrong while saving");
            }

            return Result.Success();
        }

        public async Task<Result<IReadOnlyList<Budget>>> GetBudgetsAsync(int userId)
        {
            var budgets = await _budgetRepository.Items.AsNoTracking()
                                                    .Where(x => x.UserId == userId)
                                                    .ToListAsync();
            if (budgets != null)
            { 
                return Result.Failure<IReadOnlyList<Budget>>("There are no budgets in your account yet"); 
            }

            return Result.Success<IReadOnlyList<Budget>>(budgets);
        }

        public async Task<Result<Budget>> GetBudgetAsync(int budgetId)
        {
            if (!await _budgetRepository.IsItemExists(budgetId)) 
                return Result.Failure<Budget>("Budget does not exists");

            var budget = await _budgetRepository.GetItemAsync(budgetId);
                
            return Result.Success(budget);
        }
    }
}
