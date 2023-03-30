using Microsoft.AspNetCore.Mvc;
using GrocerooAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GrocerooAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DbContext _dbContext;

        public ProductController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> GetProducts()
        {
            Product prod1 = new Product(123, "Hamburger", "Lekker stukje vlees", 10.95);
            Product prod2 = new Product(124, "Biefstuk", "Lekker stukje vlees", 16.95);

            return new List<Product> { prod1, prod2 };
        }
    }
}
