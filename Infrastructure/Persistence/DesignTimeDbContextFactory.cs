using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Persistence.Contexts;

namespace Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretBackendDbContext>
{
    public ETicaretBackendDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ETicaretBackendDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
        return new(dbContextOptionsBuilder.Options);
    }
}