using Microsoft.EntityFrameworkCore;    

namespace GrocerooAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { 

        }

        public DbSet<Product> Products { get; set; }
    }
}
