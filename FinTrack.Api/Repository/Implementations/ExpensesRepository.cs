using FinTrack.Api.Data;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Repository.Implementations
{
    public class ExpensesRepository : DbRepository<Expense>
    {
        public override IQueryable<Expense> Items =>
            base.Items
            .Include(x => x.ExpenseCategory)
            ;
        public ExpensesRepository(FinTrackDbContext context) : base(context)
        {
        }

        public override async Task<ICollection<Expense>> GetListAsync(object obj)
        {
            if (!(obj is Budget budget)) return new List<Expense>();

            return await Items.Where(x => x.BudgetId == budget.Id).ToListAsync();
        }
    }
}
