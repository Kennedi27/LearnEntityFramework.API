using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class CustomerConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.ToTable("customer");

            builder.HasKey(customer => customer.Id);

            builder.HasOne<UserEntity>().WithMany()
                   .HasForeignKey(customer => customer.CreatedBy)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);


            builder.Property(customer => customer.CreatedOnUtc).HasDefaultValue(DateTime.UtcNow);

            builder.Property(customer => customer.ModifiedBy);

            builder.Property(customer => customer.ModifiedOnUtc);

            builder.Property(customer => customer.Deleted).HasDefaultValue(false);

            builder.Property(customer => customer.DeleteTimeUtc);

            builder.HasQueryFilter(customer => !customer.Deleted);

        }
    }
}
