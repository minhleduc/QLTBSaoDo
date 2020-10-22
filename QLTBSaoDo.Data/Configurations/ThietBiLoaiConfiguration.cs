using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class ThietBiLoaiConfiguration : IEntityTypeConfiguration<ThietBiLoai>
    {
        public void Configure(EntityTypeBuilder<ThietBiLoai> builder)
        {
            builder.ToTable("ThietBiLoai");

            builder.HasKey(x => new { x.ThietBiId, x.LoaiId });

            builder.HasOne<ThietBi>(t => t.ThietBi)
                .WithMany(x => x.ThietBiLoais)
                .HasForeignKey(t => t.ThietBiId);

            builder.HasOne<Loai>(l => l.Loai)
                .WithMany(x => x.ThietBiLoais)
                .HasForeignKey(d => d.LoaiId);
        }
    }
}
