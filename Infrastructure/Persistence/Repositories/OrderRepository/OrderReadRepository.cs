using Application.Repositories.OrderRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.OrderRepository;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(ETicaretBackendDbContext dbContext) : base(dbContext)
    {
    }
}