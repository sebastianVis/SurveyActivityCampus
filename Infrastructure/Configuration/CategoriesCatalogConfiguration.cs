using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CategoriesCatalogConfiguration : IEntityTypeConfiguration<CategoriesCatalog>
    {
        public void Configure(EntityTypeBuilder<CategoriesCatalog> builder)
        {
            builder.ToTable("categories_catalog");

            builder.HasKey(c => c.Id).HasName("id");

            builder.Property(c => c.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at")
                .HasColumnType("timestamp");

            builder.Property(c => c.UpdatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                .HasColumnName("updated_at")
                .HasColumnType("timestamp");

            builder.Property(c => c.Name)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}