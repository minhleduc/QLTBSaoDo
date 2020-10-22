using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class TSThanhLyConfiguration : IEntityTypeConfiguration<TSThanhLy>
    {
        public void Configure(EntityTypeBuilder<TSThanhLy> builder)
        {
            builder.ToTable("TSThanhLy");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Gia)
                .HasColumnType("decimal(15,2")
                .HasDefaultValueSql("0");
            builder.HasOne<ThietBiPhong>(t => t.ThietBiPhong)
                .WithOne(x => x.TSThanhLy)
                .HasForeignKey<TSThanhLy>(x => x.ThietBiPhongId);
        }
    }
}
