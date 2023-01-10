using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearnEntityFramework.EFLibrary.Data
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
        {

        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductUnitEntity> ProductUnit { get; set; }
    }
}
