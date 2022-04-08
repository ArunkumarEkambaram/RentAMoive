using Microsoft.EntityFrameworkCore;
using RentAMovie.API.Data.Models;

namespace RentAMovie.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Movie> Movies{ get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
