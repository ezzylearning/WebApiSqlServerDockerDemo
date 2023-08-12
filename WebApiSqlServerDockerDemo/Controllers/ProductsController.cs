using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApiSqlServerDockerDemo.Data;
using WebApiSqlServerDockerDemo.Models;

namespace WebApiSqlServerDockerDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly OnlineShopDbContext _context;

        public ProductsController(OnlineShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.ToListAsync();
        }
    }
}