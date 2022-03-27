using Microsoft.EntityFrameworkCore;

namespace dotnetProjekt.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ):base(options) 
        {
            
        }

        public DbSet<Product> products {get; set;}
    }
}