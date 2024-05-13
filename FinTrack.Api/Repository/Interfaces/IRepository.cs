namespace FinTrack.Api.Repository.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> Items { get; }
        Task<ICollection<T>> GetListAsync();
        Task<T> GetItemAsync(int id);
        Task<bool> CreateAsync(T obj);
        Task<bool> UpdateAsync(T obj);
        Task<bool> DeleteAsync(T obj);
        Task<bool> IsItemExists(string name);
        Task<bool> SaveAsync();
        Task<ICollection<T>> GetListAsync(object obj);
    }
}
