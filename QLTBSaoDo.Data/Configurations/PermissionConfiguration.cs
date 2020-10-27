using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permission");
            builder.HasKey(x => x.RoleId);

            builder.HasOne(d => d.Role)
                .WithMany(p => p.Permission)
                .HasForeignKey(d => d.RoleId);

            builder.HasOne(f => f.Function)
                .WithMany(x => x.Permission)
                .HasForeignKey(x => x.FunctionId);

            builder.HasOne(f => f.Actions)
                .WithMany(x => x.Permission)
                .HasForeignKey(f => f.ActionId);
        }
    }
}
