using Application.Repositories.ProductRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.ProductRepository;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(ETicaretBackendDbContext dbContext) : base(dbContext)
    {
    }
}