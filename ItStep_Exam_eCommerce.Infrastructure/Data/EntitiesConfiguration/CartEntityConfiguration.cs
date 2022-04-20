using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration
{
    internal class CartEntityConfiguration : BaseEntityConfiguration<CartEntity>
    {
        public override void Configure(EntityTypeBuilder<CartEntity> builder)
        {
            base.Configure(builder);

            builder.HasMany(c => c.CartItems).WithOne(c => c.Cart).IsRequired();
            builder.HasOne(c => c.Buyer).WithMany(b => b.Carts);
        }
    }
}
