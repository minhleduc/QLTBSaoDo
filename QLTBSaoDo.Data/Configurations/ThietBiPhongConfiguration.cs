using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class ThietBiPhongConfiguration : IEntityTypeConfiguration<ThietBiPhong>
    {
        public void Configure(EntityTypeBuilder<ThietBiPhong> builder)
        {
            builder.ToTable("ThietBiPhong");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TenThietBi).IsRequired();

            builder.HasOne<ThietBi>(t => t.ThietBi)
                .WithMany(x => x.ThietBiPhong)
                .HasForeignKey(x => x.ThietBiId);

            builder.HasOne<Phong>(t => t.Phong)
                .WithMany(x => x.ThietBiPhong)
                .HasForeignKey(x => x.PhongId);
        }
    }
}
