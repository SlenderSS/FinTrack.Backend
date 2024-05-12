using FinTrack.Api.Data;
using FinTrack.Api.Models.Base;
using FinTrack.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Repository.Implementations
{
    public class DbRepository<T> : IRepository<T> where T : NamedEntity
    {
        protected readonly FinTrackDbContext _context;
        private readonly DbSet<T> _set;

        public IQueryable<T> Items => _set;
        public DbRepository(FinTrackDbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }
        public async Task<bool> CreateAsync(T obj)
        {
            await _context.AddAsync(obj);
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(T obj)
        {
            _context.Remove(obj);
            return await SaveAsync();
        }

        public async Task<T> GetItemAsync(int id)
        {
            return await Items.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<ICollection<T>> GetListAsync()
        {
            return await Items.ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0 ? true : false;
        }

        public async Task<bool> UpdateAsync(T obj)
        {
            _context.Update(obj);
            return await SaveAsync();
        }

        public async Task<bool> IsItemExists(string name)
        {
            return await Items.AnyAsync(x => x.Name == name);
        }
    }
}
