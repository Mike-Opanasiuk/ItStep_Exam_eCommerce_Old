using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration
{
    internal class OrderEntityConfiguration : BaseEntityConfiguration<OrderEntity>
    {
        public override void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(o => o.Buyer).WithMany(u => u.Orders);
            builder.HasMany(o => o.OrderItems).WithOne(o => o.Order).IsRequired();
        }
    }
}
