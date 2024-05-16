using CSharpFunctionalExtensions;
using FinTrack.Api.Contracts;
using FinTrack.Models;

namespace FinTrack.Api.Services.Interfaces
{
    public interface IBudgetService
    {
        Task<Result<IReadOnlyList<Budget>>> GetBudgetsAsync(int userId);

        Task<Result> CreateBudgetAsync(Budget budget);
        Task<Result<Budget>> GetBudgetAsync(int budgetId);
    }
}
