using CSharpFunctionalExtensions;
using FinTrack.Api.Repository.Interfaces;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;

namespace FinTrack.Api.Services.Implementations
{
    public class IncomeService : IIncomeService
    {
        private readonly IRepository<Income> _incomesRepository;
        private readonly IRepository<Budget> _budgetRepository;

        public IncomeService(IRepository<Income> incomesRepository, IRepository<Budget> budgetRepository)
        {
            this._incomesRepository = incomesRepository;
            this._budgetRepository = budgetRepository;
        }
        public async Task<Result> CreateIncomeAsync(Income incomeCreate)
        {
            if (incomeCreate == null)
            {
                return Result.Failure("Null reference object");
            }

            if (!await _incomesRepository.CreateAsync(incomeCreate))
                return Result.Failure("Something went wrong while saving");

            return Result.Success();
        }

        public async Task<Result<IReadOnlyList<Income>>> GetIncomesAsync(int budgetId)
        {
            if (!await _budgetRepository.IsItemExists(budgetId))
                return Result.Failure<IReadOnlyList<Income>>("Incorrect budget Id");

            var incomes = await _incomesRepository.GetListAsync(budgetId);

            if (incomes == null)
                return Result.Failure<IReadOnlyList<Income>>("There are no incomes in this budget");

            return Result.Success(incomes);
        }
    }
}
