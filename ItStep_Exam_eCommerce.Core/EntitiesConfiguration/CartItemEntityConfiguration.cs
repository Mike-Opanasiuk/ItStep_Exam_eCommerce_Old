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
