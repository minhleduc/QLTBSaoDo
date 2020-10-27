using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using QLTBSaoDo.Data.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class TinhTrangConfiguration : IEntityTypeConfiguration<TinhTrang>
    {
        public void Configure(EntityTypeBuilder<TinhTrang> builder)
        {
            builder.ToTable("TinhTrang");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.HienTrang)
                .HasColumnName("HienTrang")
                .HasColumnType("nvarchar(max)")
                .HasDefaultValue<HienTrang>(HienTrang.Tốt);

            builder.Property(x => x.NgayCapNhat)
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");

            builder.HasOne<ThietBiPhong>(t => t.ThietBiPhong)
                .WithMany(x => x.TinhTrang)
                .HasForeignKey(x => x.ThietBiPhongId);
        }
    }
}
