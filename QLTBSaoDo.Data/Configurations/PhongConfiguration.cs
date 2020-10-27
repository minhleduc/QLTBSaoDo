using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class PhongConfiguration : IEntityTypeConfiguration<Phong>
    {
        public void Configure(EntityTypeBuilder<Phong> builder)
        {
            builder.ToTable("Phong");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne<Khoa>(k => k.Khoa)
                .WithMany(x => x.Phong)
                .HasForeignKey(x => x.KhoaId);
        }
    }
}
