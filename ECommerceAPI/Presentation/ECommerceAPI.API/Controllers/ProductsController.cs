using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id=Guid.NewGuid(), Name="Product1", Stock=100, Price=10, CreatedDate=DateTime.UtcNow},
                new() {Id=Guid.NewGuid(), Name="Product4", Stock=100, Price=10, CreatedDate=DateTime.UtcNow},
                new() {Id=Guid.NewGuid(), Name="Product5", Stock=100, Price=10, CreatedDate=DateTime.UtcNow},
            });

            await _productWriteRepository.SaveAsync();

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
            }
        }
}
