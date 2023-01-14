using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class PaymentModeConfiguration : IEntityTypeConfiguration<PaymentModeEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentModeEntity> builder)
        {
            builder.ToTable("payment_mode");

            builder.HasKey(payment => payment.Id);

            builder.Property(payment => payment.Active).HasDefaultValue(true);
        }
    }
}
