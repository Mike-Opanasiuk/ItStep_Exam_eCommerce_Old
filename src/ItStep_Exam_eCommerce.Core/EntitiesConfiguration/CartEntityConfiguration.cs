using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Core.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.EntitiesConfiguration
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
