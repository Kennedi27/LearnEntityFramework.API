using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrderEntity>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderEntity> builder)
        {
            builder.ToTable("purchase_order");

            builder.HasKey(purchase => purchase.Id);

            builder.HasOne<UserEntity>().WithMany()
                .HasForeignKey(purchase => purchase.CreatedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(purchase => purchase.CreatedOnUtc).HasDefaultValue(DateTime.UtcNow);

            builder.Property(purchase => purchase.ModifiedBy);

            builder.Property(purchase => purchase.ModifiedOnUtc);
        }
    }
}
