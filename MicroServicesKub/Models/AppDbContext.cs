using Microsoft.EntityFrameworkCore;

namespace MicroServicesKub.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pasajero> Pasajero { get; set; }
    }
}
