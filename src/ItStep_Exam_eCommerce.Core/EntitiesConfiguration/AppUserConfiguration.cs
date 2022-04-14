using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.EntitiesConfiguration
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(u => u.PhoneNumber).IsUnique();
            builder.Property(u => u.Email).IsRequired().HasMaxLength(64);
            builder.Property(u => u.Name).HasMaxLength(64);
            builder.Property(u => u.Surname).HasMaxLength(64);

            builder.Property(u => u.RegisteredAt).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAdd();
            builder.Property(u => u.UpdatedAt).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAddOrUpdate();

            builder.HasMany(f => f.Feedbacks).WithOne(u => u.Owner).IsRequired();
            builder.HasMany(f => f.Orders).WithOne(u => u.Buyer).IsRequired();
            builder.HasMany(f => f.Carts).WithOne(u => u.Buyer).IsRequired();
        }
    }
}
