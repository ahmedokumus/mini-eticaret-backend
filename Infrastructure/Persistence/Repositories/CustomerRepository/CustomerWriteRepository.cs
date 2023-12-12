using Application.Repositories.CustomerRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.CustomerRepository;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ETicaretBackendDbContext dbContext) : base(dbContext)
    {
    }
}