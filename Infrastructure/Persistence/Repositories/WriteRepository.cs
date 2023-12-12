using Application.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly ETicaretBackendDbContext _dbContext;
    public WriteRepository(ETicaretBackendDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public DbSet<T> Table
        => _dbContext.Set<T>();

    public async Task<bool> AddAsync(T? entity)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(entity!);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> entities)
    {
        await Table.AddRangeAsync(entities);
        return true;
    }

    public bool Delete(T? entity)
    {
        EntityEntry<T> entityEntry = Table.Remove(entity!);
        return entityEntry.State == EntityState.Deleted;
    }

    public bool DeletedRange(List<T> entities)
    {
        Table.RemoveRange(entities);
        return true;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        T entity = (await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id)))!;
        return Delete(entity);
    }

    public bool Update(T entity)
    {
        EntityEntry<T> entityEntry = Table.Update(entity);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<int> SaveAsync()
        => await _dbContext.SaveChangesAsync();
}