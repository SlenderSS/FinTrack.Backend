namespace FinTrack.Api.Repository.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> Items { get; }
        Task<IReadOnlyList<T>> GetListAsync();
        Task<T> GetItemAsync(int id);
        Task<bool> CreateAsync(T obj);
        Task<bool> UpdateAsync(T obj);
        Task<bool> DeleteAsync(T obj);
        Task<bool> IsItemExistsAsync(string name);
        Task<bool> IsItemExists(int id);
        Task<bool> SaveAsync();
        Task<IReadOnlyList<T>> GetListAsync(object obj);
    }
}
