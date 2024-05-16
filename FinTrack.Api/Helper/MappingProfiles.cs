using AutoMapper;
using FinTrack.Api.Contracts;
using FinTrack.Models;
namespace FinTrack.Api.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Currency, CurrencyDto>();
            CreateMap<CurrencyDto, Currency>();

            CreateMap<ExpenseCategory, ExpenseCategoryDto>();
            CreateMap<ExpenseCategoryDto, ExpenseCategory>();

            CreateMap<IncomeCategory, IncomeCategoryDto>();
            CreateMap<IncomeCategoryDto, IncomeCategory>();

            CreateMap<Expense, ExpenseDto>();
            CreateMap<ExpenseDto, Expense>();

            CreateMap<Income, IncomeDto>();
            CreateMap<IncomeDto, Income>();


        }
    }
}
