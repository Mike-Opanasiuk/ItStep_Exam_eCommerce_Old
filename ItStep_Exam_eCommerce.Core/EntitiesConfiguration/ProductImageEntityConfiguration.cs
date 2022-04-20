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
    internal class ProductImageEntityConfiguration : BaseEntityConfiguration<ProductImageEntity>
    {
        public override void Configure(EntityTypeBuilder<ProductImageEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.Product).WithMany(p => p.ProductImages);
        }
    }
}
