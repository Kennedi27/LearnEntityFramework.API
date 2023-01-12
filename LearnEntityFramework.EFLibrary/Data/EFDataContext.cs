using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LearnEntityFramework.EFLibrary.Data
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductUnitEntity> ProductUnit { get; set; }
        public DbSet<UserEntity> Users { get; set; }

    }
}
