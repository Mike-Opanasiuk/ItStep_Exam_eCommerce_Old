using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration
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
