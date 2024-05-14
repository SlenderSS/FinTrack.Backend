using CSharpFunctionalExtensions;
using CSharpFunctionalExtensions.ValueTasks;
using FinTrack.Api.Repository.Interfaces;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;

namespace FinTrack.Api.Services.Implementations
{
    public class ExpenseService : IExpenseService
    {
        private readonly IRepository<Expense> _expensesRepository;
        private readonly IRepository<Budget> _budgetRepository;

        public ExpenseService(IRepository<Expense> expensesRepository, IRepository<Budget> budgetRepository)
        {
            this._expensesRepository = expensesRepository;
            this._budgetRepository = budgetRepository;
        }
        public async Task<Result> CreateExpenseAsync(Expense expenseCreate)
        {
            if(expenseCreate == null) 
            { 
                return Result.Failure("Null reference object"); 
            }

            if(!await _expensesRepository.CreateAsync(expenseCreate))
                return Result.Failure("Something went wrong while saving");

            return Result.Success();
        }

        public async Task<Result<IReadOnlyList<Expense>>> GetExpensesAsync(int budgetId)
        {
            if (!await _budgetRepository.IsItemExists(budgetId))
                return Result.Failure<IReadOnlyList<Expense>>("Incorrect budget Id");

            var expenses = await _expensesRepository.GetListAsync(budgetId);

            if (expenses == null)
                return Result.Failure<IReadOnlyList<Expense>>("There are no expenses in this budget");

            return Result.Success(expenses);
        }
    }
}
