using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class GVQuanLyConfiguration : IEntityTypeConfiguration<GVQuanLy>
    {
        public void Configure(EntityTypeBuilder<GVQuanLy> builder)
        {
            builder.ToTable("GVQuanLy");

            builder.HasKey(x => new { x.UserId, x.KhoaId, x.PhongId });

            builder.HasOne<User>(u => u.User)
                .WithOne(x => x.GVQuanLy)
                .HasForeignKey<GVQuanLy>(x => x.UserId);

            builder.HasOne<Khoa>(k => k.Khoa)
                .WithMany(x => x.GVQuanLys)
                .HasForeignKey(x => x.KhoaId);

            builder.HasOne<Phong>(k => k.Phong)
                .WithOne(x => x.GVQuanLy)
                .HasForeignKey<GVQuanLy>(x => x.PhongId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
