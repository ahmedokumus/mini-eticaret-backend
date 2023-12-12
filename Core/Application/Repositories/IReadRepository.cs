using Domain.Entities.Common;
using System.Linq.Expressions;

namespace Application.Repositories;

public interface IReadRepository<T> : IRepositoryBase<T> where T : BaseEntity
{
    IQueryable<T?> GetAll(bool tracking = true);
    IQueryable<T?> GetWhere(Expression<Func<T?, bool>> filter, bool tracking = true);
    Task<T?> GetSingleAsync(Expression<Func<T?, bool>> filter, bool tracking = true);
    Task<T?> GetByIdAsync(string id, bool tracking = true);
}