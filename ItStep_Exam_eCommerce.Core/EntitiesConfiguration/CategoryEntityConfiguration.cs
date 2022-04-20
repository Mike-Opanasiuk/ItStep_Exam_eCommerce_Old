using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Core.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.EntitiesConfiguration
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
