using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class ProductUnitConfiguration : IEntityTypeConfiguration<ProductUnitEntity>
    {
        public void Configure(EntityTypeBuilder<ProductUnitEntity> builder)
        {
            builder.ToTable(nameof(ProductUnitEntity).ToLower());

            builder.HasKey(x => x.Id);
        }
    }
}
