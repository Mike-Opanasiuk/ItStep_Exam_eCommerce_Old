using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.EntitiesConfiguration.Abstract
{
    internal abstract class BaseEntityConfiguration<TEntity>
        : IEntityTypeConfiguration<TEntity> where TEntity
        : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAdd();
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAddOrUpdate();
        }
    }
}
