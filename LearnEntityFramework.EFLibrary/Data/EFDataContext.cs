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
        public DbSet<InvoiceEntity> Invoices { get; set; }
        public DbSet<PaymentModeEntity> PaymentModes { get; set; }
        public DbSet<ProductEntity> Products { get; set; } 
        public DbSet<ProductUnitEntity> ProductUnits { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
        public DbSet<PurchaseOrderEntity> PurchaseOrders { get; set; }
        public DbSet<ReceiveProductEntity> ReceiveProducts { get; set; }
        public DbSet<SalesEntity> Sales { get; set; }
        public DbSet<SupplierEntity> Suppliers { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserLoginEntity> UsersLogin { get; set; }
        public DbSet<UserRoleEntity> UserRoles { get; set; }

    }
}
