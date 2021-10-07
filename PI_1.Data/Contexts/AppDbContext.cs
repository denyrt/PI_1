using Microsoft.EntityFrameworkCore;
using PI_1.Data.Models;
using System.Reflection;

namespace PI_1.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<CarEntity> CarEntities { get; set; }
        public DbSet<OrderEntity> OrderEntities { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
