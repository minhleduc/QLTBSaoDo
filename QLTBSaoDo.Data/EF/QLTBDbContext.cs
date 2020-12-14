
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QLTBSaoDo.Data.Configurations;
using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.EF
{
    public class QLTBDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public QLTBDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActionConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietDonNhapConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucConfiguration());
            modelBuilder.ApplyConfiguration(new DonNhapCongiguration());
            modelBuilder.ApplyConfiguration(new FunctionConfiguration());
            modelBuilder.ApplyConfiguration(new GVQuanLyConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiConfiguration());
            modelBuilder.ApplyConfiguration(new NhaCungCapConfiguration());
            //modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new PhongConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new ThietBiConfiguration());
            modelBuilder.ApplyConfiguration(new ThietBiDanhMucConfigution());
            modelBuilder.ApplyConfiguration(new ThietBiLoaiConfiguration());
            modelBuilder.ApplyConfiguration(new ThietBiPhongConfiguration());
            modelBuilder.ApplyConfiguration(new TinhTrangConfiguration());
            modelBuilder.ApplyConfiguration(new TSThanhLyConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new UserRolesConfiguration());
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

        }

        public DbSet<AppConfig> AppConfig { get; set; }
        public DbSet<Actions> Actions { get; set; }
        public DbSet<ChiTietDonNhap> ChiTietDonNhap { get; set; }
        public DbSet<DanhMuc> DanhMuc { get; set; }
        public DbSet<DonNhap> DonNhap { get; set; }
        public DbSet<Function> Function { get; set; }
        public DbSet<GVQuanLy> GVQuanLy { get; set; }
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<Loai> Loai { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        //public DbSet<Permission> Permission { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<AppRole> Role { get; set; }
        public DbSet<ThietBi> ThietBi { get; set; }
        public DbSet<ThietBiDanhMuc> ThietBiDanhMuc { get; set; }
        public DbSet<ThietBiLoai> ThietBiLoai { get; set; }
        public DbSet<ThietBiPhong> ThietBiPhong { get; set; }
        public DbSet<TinhTrang> TinhTrang { get; set; }
        public DbSet<TSThanhLy> TSThanhLy { get; set; }
        //public DbSet<User> User { get; set; }
        //public DbSet<UserRoles> UserRoles { get; set; }
    }
}
