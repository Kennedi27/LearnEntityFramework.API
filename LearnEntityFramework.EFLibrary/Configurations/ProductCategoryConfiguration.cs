using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryEntity> builder)
        {
            builder.ToTable(nameof(ProductCategoryEntity).ToLower());

            builder.HasKey(x => x.Id);
        }
    }
}
