using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QLTBSaoDo.Data.Configurations
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
           builder.ToTable("UserRoles");
            builder.HasKey(x => new { x.UserId, x.RoleId });
            builder.HasOne<User>(u => u.User)
                .WithOne(x => x.UserRoles)
                .HasForeignKey<UserRoles>(x => x.UserId);
            builder.HasOne<Role>(u => u.Role)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.RoleId);
        }
    }
}
