using AutoMapper;
using FinTrack.Api.Contracts.Budget;
using FinTrack.Api.Contracts.Expense;
using FinTrack.Api.Contracts.ExpenseCategory;
using FinTrack.Api.Contracts.Income;
using FinTrack.Api.Contracts.IncomeCategory;
using FinTrack.Api.Contracts.Сurrency;
using FinTrack.Models;
namespace FinTrack.Api.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Currency, ReadCurrencyDto>();
            CreateMap<ReadCurrencyDto, Currency>();

            CreateMap<Budget, ReadBudgetDto>();
            CreateMap<ReadBudgetDto, Budget>();

            CreateMap<ExpenseCategory, ReadExpenseCategoryDto>();
            CreateMap<ReadExpenseCategoryDto, ExpenseCategory>();

            CreateMap<IncomeCategory, ReadIncomeCategoryDto>();
            CreateMap<ReadIncomeCategoryDto, IncomeCategory>();

            CreateMap<Expense, ReadExpenseDto>();
            CreateMap<ReadExpenseDto, Expense>();

            CreateMap<Income, ReadIncomeDto>();
            CreateMap<ReadIncomeDto, Income>();


        }
    }
}
