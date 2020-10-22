using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class ThietBiConfiguration : IEntityTypeConfiguration<ThietBi>
    {
        public void Configure(EntityTypeBuilder<ThietBi> builder)
        {
            builder.ToTable("ThietBi");

            builder.HasKey(x => x.Id)
                .HasName("Mã thiết bị");

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("decimal(15,2)")
                .HasDefaultValue(0);

            builder.Property(x => x.Stock)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(x => x.Details)
                .IsRequired(false);

            builder.Property(x => x.DateCreated)
                .IsRequired(false)
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");

        }
    }
}
