using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options){      
        }

        public DbSet<Category> Categories { get; set; }

    }
}
