using FinTrack.Api.Data;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FinTrack.Api.Repository.Implementations
{
    public class BudgetRepository : DbRepository<Budget>
    {
        public override IQueryable<Budget> Items => 
            base.Items
            .Include(x => x.BudgetCategory)
            .Include(x => x.Currency)
            .Include(x => x.User)
            ;
        public BudgetRepository(FinTrackDbContext context) : base(context)
        {
        }

        public override async Task<ICollection<Budget>> GetListAsync(object obj)
        {
            if (!(obj is User user)) return new List<Budget>(); ;

            return await Items.Where(x => x.UserId == user.Id).ToListAsync();
        }
    }



}
