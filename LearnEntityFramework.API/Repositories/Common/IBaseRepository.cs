namespace LearnEntityFramework.API.Repositories.Common
{
    /// <summary>
    /// Basic Operation CRUD
    /// </summary>
    /// <typeparam name="T">Model or Data transfer object (DTO)</typeparam>
    /// <typeparam name="TID">Key or Id Entity</typeparam>
    public interface IBaseRepository<T, TID>
    {
        Task<List<T>> GetAllAsync();

        Task<T?> GetByIdAsync(TID key);

        Task<List<T>> GetActiveAsync();

        Task<List<T>> GetInActiveAsync();

        Task<bool> CreateAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<bool> SoftDeleteAsync(T entity);
    }
}
