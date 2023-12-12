using Application.Repositories.CustomerRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.CustomerRepository;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ETicaretBackendDbContext dbContext) : base(dbContext)
    {
    }
}