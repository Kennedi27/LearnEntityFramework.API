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


            builder.Property(customer => customer.Deleted).HasDefaultValue(false);



            builder.HasQueryFilter(customer => !customer.Deleted);

        }
    }
}
