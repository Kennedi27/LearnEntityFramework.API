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

            builder.Property(customer => customer.Id)
                   .IsRequired()
                   .HasColumnName("id");

            builder.Property(customer => customer.FirstName)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasColumnName("first_name");

            builder.Property(customer => customer.LastName)
                   .HasColumnType("varchar(50)")
                   .HasMaxLength(50)
                   .IsFixedLength()
                   .HasColumnName("last_name");


        }
    }
}
