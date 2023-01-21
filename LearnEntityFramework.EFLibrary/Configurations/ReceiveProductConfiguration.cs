using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class ReceiveProductConfiguration : IEntityTypeConfiguration<ReceiveProductEntity>
    {
        public void Configure(EntityTypeBuilder<ReceiveProductEntity> builder)
        {
            builder.ToTable("receive_product");

            builder.HasKey(receive => receive.Id);

            builder.HasOne<ProductEntity>()
                .WithMany()
                .HasForeignKey(receive => receive.ProductId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<SupplierEntity>()
                .WithMany()
                .HasForeignKey(receive => receive.SupplierId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<UserEntity>()
                .WithMany()
                .HasForeignKey(receive => receive.CreatedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(receive => receive.CreatedBy);

            builder.Property(receive => receive.CreatedOnUtc).HasDefaultValue(DateTime.UtcNow);

            builder.Property(receive => receive.ModifiedBy);

            builder.Property(receive => receive.ModifiedOnUtc);

            builder.Property(receive => receive.Deleted).HasDefaultValue(false);

            builder.Property(receive => receive.DeleteTimeUtc);

            builder.HasQueryFilter(receive => !receive.Deleted);
        }
    }
}
