using Application.Repositories.OrderRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.OrderRepository;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ETicaretBackendDbContext dbContext) : base(dbContext)
    {
    }
}