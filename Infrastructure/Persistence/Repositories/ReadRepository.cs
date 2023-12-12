using System.Linq.Expressions;
using Application.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly ETicaretBackendDbContext _dbContext;
    public ReadRepository(ETicaretBackendDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public DbSet<T> Table => _dbContext.Set<T>();

    public IQueryable<T?> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking) query = query.AsNoTracking();

        return query;
    }

    public IQueryable<T?> GetWhere(Expression<Func<T?, bool>> filter, bool tracking = true)
    {
        var query = Table.Where(filter);
        if (!tracking)
            query = query.AsNoTracking();

        return query;
    }

    public async Task<T?> GetSingleAsync(Expression<Func<T?, bool>> filter, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = Table.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(filter);
    }

    public async Task<T?> GetByIdAsync(string id, bool tracking = true)
    //=> await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse((id))); //Marker Pattern : T nin sadece Base Entity alması
    //=> await Table.FindAsync(Guid.Parse(id));
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = Table.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }
}