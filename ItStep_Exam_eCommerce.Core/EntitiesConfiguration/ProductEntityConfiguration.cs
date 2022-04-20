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
    internal class ProductEntityConfiguration : BaseEntityConfiguration<ProductEntity>
    {
        public override void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.Category).WithMany(c => c.Products);
            builder.HasMany(p => p.ProductImages).WithOne(i => i.Product).IsRequired();
            builder.HasMany(p => p.Feedbacks).WithOne(f => f.Product).HasForeignKey(f => f.ProductId);
            builder.HasMany(p => p.CartItems).WithOne(c => c.Product).IsRequired();
            builder.HasMany(p => p.OrderItems).WithOne(o => o.Product).IsRequired();
        }
    }
}
