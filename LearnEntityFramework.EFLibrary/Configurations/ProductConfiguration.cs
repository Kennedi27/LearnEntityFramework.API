﻿using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne<ProductUnitEntity>()
                   .WithMany()
                   .HasForeignKey(@product => @product.UnitId)
                   .IsRequired();

            builder.HasOne<UserEntity>()
                   .WithMany()
                   .HasForeignKey(user => user.UserId)
                   .IsRequired();

        }
    }
}
