using Microsoft.EntityFrameworkCore;
using vertical_slice_architecture.Domain;

namespace vertical_slice_architecture.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Television> Televisions { get; set; }
    }
}
