using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class InvoiceConfiguration : IEntityTypeConfiguration<InvoiceEntity>
    {
        public void Configure(EntityTypeBuilder<InvoiceEntity> builder)
        {
            builder.ToTable("invoice");

            builder.HasKey(invoice => invoice.Id);

            builder.HasOne<UserEntity>()
                   .WithMany()
                   .HasForeignKey(invoice => invoice.CreatedBy)
                   .IsRequired();

            builder.Property(invoice => invoice.TotalAmount).HasDefaultValue(0);

            builder.Property(invoice => invoice.Discount).HasDefaultValue(0);

            builder.Property(invoice => invoice.CreatedOnUtc).HasDefaultValue(DateTime.UtcNow);

            builder.Property(invoice => invoice.ModifiedOnUtc);

            builder.Property(invoice => invoice.Deleted).HasDefaultValue(false);

            builder.Property(invoice => invoice.DeleteTimeUtc);

            builder.HasQueryFilter(invoice => !invoice.Deleted);

        }
    }
}
