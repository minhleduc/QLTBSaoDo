using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class ChiTietDonNhapConfiguration : IEntityTypeConfiguration<ChiTietDonNhap>
    {
        public void Configure(EntityTypeBuilder<ChiTietDonNhap> builder)
        {
            builder.ToTable("ChiTietDonNhap");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.SoLuong)
                .HasDefaultValue(0);

            builder.Property(x => x.Gia)
                .HasColumnType("decimal(15,2)");

            builder.HasOne<DonNhap>(d => d.DonNhap)
                .WithMany(x => x.ChiTietDonNhap)
                .HasForeignKey(t => t.DonNhapId);

            builder.HasOne<ThietBi>(t => t.ThietBi)
                .WithMany(x => x.ChiTietDonNhap)
                .HasForeignKey(t => t.ThietBiId);

            builder.HasOne<NhaCungCap>(ncc => ncc.NhaCungCap)
                .WithMany(x => x.ChiTietDonNhap)
                .HasForeignKey(ncc => ncc.NhaCungCapId);

        }
    }
}
