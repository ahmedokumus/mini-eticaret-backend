using Application.Repositories.ProductRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.ProductRepository;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(ETicaretBackendDbContext dbContext) : base(dbContext)
    {
    }
}