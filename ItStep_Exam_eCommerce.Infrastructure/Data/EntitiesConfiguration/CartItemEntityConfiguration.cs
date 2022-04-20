using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration
{
    internal class CartItemEntityConfiguration : BaseEntityConfiguration<CartItemEntity>
    {
        public override void Configure(EntityTypeBuilder<CartItemEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(c => c.Product).WithMany(p => p.CartItems);
            builder.HasOne(c => c.Cart).WithMany(p => p.CartItems);
        }
    }
}
