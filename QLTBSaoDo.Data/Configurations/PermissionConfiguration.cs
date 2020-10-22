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
            builder.HasOne<Role>(r => r.Role)
                .WithMany(x => x.Permissions)
                .HasForeignKey(x => x.RoleId);
            builder.HasOne<Function>(f => f.Function)
                .WithMany(x => x.Permissions)
                .HasForeignKey(x => x.FunctionId);
            builder.HasOne<Actions>(f => f.Action)
                .WithMany(x => x.Permissions)
                .HasForeignKey(x => x.ActionId);
        }
    }
}
