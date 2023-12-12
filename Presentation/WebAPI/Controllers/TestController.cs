using Application.Repositories.CustomerRepository;
using Application.Repositories.OrderRepository;
using Application.Repositories.ProductRepository;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        
        public TestController(
            IProductReadRepository productReadRepository, 
            IProductWriteRepository productWriteRepository, 
            IOrderReadRepository orderReadRepository, 
            IOrderWriteRepository orderWriteRepository, 
            ICustomerReadRepository customerReadRepository, 
            ICustomerWriteRepository customerWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {

            //1
            //await _productWriteRepository.AddRangeAsync(new ()
            //{
            //    new () {Id = Guid.NewGuid(), ProductName = "Product 1", Price = 100, CreatedDate = DateTime.Now, Stock = 10},
            //    new () {Id = Guid.NewGuid(), ProductName = "Product 2", Price = 200, CreatedDate = DateTime.Now, Stock = 20},
            //    new () {Id = Guid.NewGuid(), ProductName = "Product 3", Price = 300, CreatedDate = DateTime.Now, Stock = 30}
            //});

            //2
            //Product product = await _productReadRepository.GetByIdAsync("326b07e6-1032-4a21-a5fe-157e1bda50ae", false);
            //product.ProductName = "Ahmet";
            //await _productWriteRepository.SaveAsync();

            //_productWriteRepository.AddAsync(new()
            //    { ProductName = "Tabet", Price = 2500, Stock = 5, CreatedDate = DateTime.Now, Id = Guid.NewGuid() });
            //_productWriteRepository.SaveAsync();

            //3
            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, CustomerName = "Mehmet" });

            //await _orderWriteRepository.AddAsync(new() { Description = "bla bla bla", Address = "Kütahya", CustomerId = customerId});
            //await _orderWriteRepository.AddAsync(new() { Description = "bla bla bla2", Address = "Bursa", CustomerId = customerId});
            //await _orderWriteRepository.SaveAsync();

            //4
            Order? order = await _orderReadRepository.GetByIdAsync("a3fe7f87-aaa2-481c-f769-08dbbb9dbb38");
            order!.Address = "İstanbul";
            await _orderWriteRepository.SaveAsync();
        }
    }
}
