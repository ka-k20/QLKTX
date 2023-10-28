using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKTX.Models.EF
{
    public partial class QLKTXDBContext : DbContext
    {
        public QLKTXDBContext()
            : base("name=QLKTXDBContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<KyLuat> KyLuat { get; set; }
        public virtual DbSet<KhenThuong> KhenThuong { get; set; }
        public virtual DbSet<KhuNha> KhuNha { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<PhieuChuyenPhong> PhieuChuyenPhong { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ThanNhan> ThanNhan { get; set; }
        public virtual DbSet<TrangThietBi> TrangThietBi { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.HoaDonChiTiet)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuNha>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<KhuNha>()
                .Property(e => e.SoTang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhuNha>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CCCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HopDong)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuChuyenPhong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.GiaPhong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Phong>()
                .Property(e => e.SoNguoiO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.KhuNha)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDonChiTiet)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.TrangThietBi)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanNhan>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TrangThietBi>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonChiTiet>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonChiTiet>()
                .Property(e => e.SoDienCu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonChiTiet>()
                .Property(e => e.SoDienMoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonChiTiet>()
                .Property(e => e.SoNuocCu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonChiTiet>()
                .Property(e => e.SoNuocMoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.CCCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaPhong)
                .IsFixedLength();
        }
    }
}
