using FinTrack.Api.Data;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Repository.Implementations
{
    public class BudgetsCategoryRepository : DbRepository<BudgetCategory>
    {
        public override IQueryable<BudgetCategory> Items =>
            base.Items
            .Include(x => x.User)
            ;
        public BudgetsCategoryRepository(FinTrackDbContext context) : base(context)
        {
        }

        public override async Task<ICollection<BudgetCategory>> GetListAsync(object obj)
        {
            if (!(obj is User user)) return new List<BudgetCategory>();

            return await Items.Where(x => x.UserId == user.Id).ToListAsync();
        }
    }
}
