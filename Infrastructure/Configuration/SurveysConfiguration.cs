using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class SurveysConfiguration : IEntityTypeConfiguration<Surveys>
    {
        public void Configure(EntityTypeBuilder<Surveys> builder)
        {
            builder.ToTable("surveys");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("id");

            builder.Property(s => s.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at")
                .HasColumnType("timestamp");

            builder.Property(s => s.UpdatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at")
                .HasColumnType("timestamp");

            builder.Property(s => s.ComponentHtml)
                .HasColumnName("componenthtml")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(s => s.ComponentReact)
                .HasColumnName("componentreact")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(s => s.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasColumnType("text");

            builder.Property(s => s.Instruction)
                .HasColumnName("instruction")
                .HasColumnType("text");

            builder.Property(s => s.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("text");
        }
    }
}