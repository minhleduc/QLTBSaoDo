using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class DonNhapCongiguration : IEntityTypeConfiguration<DonNhap>
    {
        public void Configure(EntityTypeBuilder<DonNhap> builder)
        {
            builder.ToTable("DonNhap");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NgayNhap)
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");

            builder.Property(x => x.NguoiNhap)
                .IsRequired();
        }
    }
}
