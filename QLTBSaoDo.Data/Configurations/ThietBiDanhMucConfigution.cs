using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class ThietBiDanhMucConfigution : IEntityTypeConfiguration<ThietBiDanhMuc>
    {
        public void Configure(EntityTypeBuilder<ThietBiDanhMuc> builder)
        {
            builder.ToTable("ThietBiDanhMuc");

            builder.HasKey(x => new { x.ThietBiId, x.DanhMucId });

            builder.HasOne<ThietBi>(t => t.ThietBi)
                .WithMany(x => x.ThietBiDanhMucs)
                .HasForeignKey(t => t.ThietBiId);

            builder.HasOne<DanhMuc>(d => d.DanhMuc)
                .WithMany(x => x.ThietBiDanhMucs)
                .HasForeignKey(d => d.DanhMucId);

        }
    }
}
