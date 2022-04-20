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
    internal class OrderItemEntityConfiguration : BaseEntityConfiguration<OrderItemEntity>
    {
        public override void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(o => o.Order).WithMany(o => o.OrderItems);
            builder.HasOne(o => o.Product).WithMany(p => p.OrderItems);
        }
    }
}
