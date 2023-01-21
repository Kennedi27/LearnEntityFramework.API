using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class SupplierConfiguration : IEntityTypeConfiguration<SupplierEntity>
    {
        public void Configure(EntityTypeBuilder<SupplierEntity> builder)
        {
            builder.ToTable("supplier");

            builder.HasKey(supplier => supplier.Id);

            builder.HasOne<UserEntity>()
                .WithMany()
                .HasForeignKey(supplier => supplier.CreatedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);


            builder.Property(supplier => supplier.CreatedOnUtc).HasDefaultValue(DateTime.UtcNow);

            builder.Property(supplier => supplier.ModifiedBy);

            builder.Property(supplier => supplier.ModifiedOnUtc);

            builder.Property(supplier => supplier.Deleted).HasDefaultValue(false);

            builder.Property(supplier => supplier.DeleteTimeUtc);

            builder.HasQueryFilter(supplier => !supplier.Deleted);

        }
    }
}
