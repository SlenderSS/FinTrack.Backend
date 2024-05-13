using FinTrack.Api.Data;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Repository.Implementations
{
    public class ExpenseCategoriesRepository : DbRepository<ExpenseCategory>
    {
        public override IQueryable<ExpenseCategory> Items =>
            base.Items
            .Include(x => x.Expenses)
            ;
        public ExpenseCategoriesRepository(FinTrackDbContext context) : base(context)
        {
        }

        public override async Task<ICollection<ExpenseCategory>> GetListAsync(object obj)
        {
            if (!(obj is User user)) return new List<ExpenseCategory>();

            return await Items.Where(x => x.User.Id == user.Id).ToListAsync();
        }
    }
}
