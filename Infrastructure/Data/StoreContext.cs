using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; private set; }
    }
}