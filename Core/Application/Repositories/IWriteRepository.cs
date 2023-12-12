using Domain.Entities.Common;

namespace Application.Repositories;

public interface IWriteRepository<T> : IRepositoryBase<T> where T : BaseEntity
{
    Task<bool> AddAsync(T? entity);
    Task<bool> AddRangeAsync(List<T> entities);

    bool Delete(T? entity);
    bool DeletedRange(List<T> entities);
    Task<bool> DeleteAsync(string id);
    
    bool Update(T entity);

    Task<int> SaveAsync();
}