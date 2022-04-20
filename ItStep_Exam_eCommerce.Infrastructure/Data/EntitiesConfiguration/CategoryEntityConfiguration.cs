﻿using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration
{
    internal class CategoryEntityConfiguration : BaseEntityConfiguration<CategoryEntity>
    {
        public override void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Title).HasMaxLength(128);

            builder.HasMany(c => c.Products).WithOne(p => p.Category).IsRequired();
            builder.HasMany(c => c.Children).WithOne(c => c.Parent);
        }
    }
}
