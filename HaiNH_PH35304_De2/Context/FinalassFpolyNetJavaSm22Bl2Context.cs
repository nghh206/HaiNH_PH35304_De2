using System;
using System.Collections.Generic;
using De2.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace De2.Context;

public partial class FinalassFpolyNetJavaSm22Bl2Context : DbContext
{
    public FinalassFpolyNetJavaSm22Bl2Context()
    {
    }

    public FinalassFpolyNetJavaSm22Bl2Context(DbContextOptions<FinalassFpolyNetJavaSm22Bl2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<LoaiSp> LoaiSps { get; set; }

    public virtual DbSet<LoaiXm> LoaiXms { get; set; }

    public virtual DbSet<MoiQuanHe> MoiQuanHes { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Nxb> Nxbs { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<XeMay> XeMays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=Nghh;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ban__3214EC07CAB22F12");

            entity.ToTable("Ban");

            entity.HasIndex(e => e.Ma, "UQ__Ban__3214CC9E45E72DA5").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdMqh).HasColumnName("IdMQH");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SoThich).HasMaxLength(30);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdMqhNavigation).WithMany(p => p.Bans)
                .HasForeignKey(d => d.IdMqh)
                .HasConstraintName("FK1_MQH");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChucVu__3214EC077A436B32");

            entity.ToTable("ChucVu");

            entity.HasIndex(e => e.Ma, "UQ__ChucVu__3214CC9EC537C345").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiSp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiSP__3214EC07C39A602B");

            entity.ToTable("LoaiSP");

            entity.HasIndex(e => e.Ma, "UQ__LoaiSP__3214CC9E39D3B058").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiXm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiXM__3214EC07004E4A10");

            entity.ToTable("LoaiXM");

            entity.HasIndex(e => e.Ma, "UQ__LoaiXM__3214CC9E0776E27D").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<MoiQuanHe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MoiQuanH__3214EC073677839C");

            entity.ToTable("MoiQuanHe");

            entity.HasIndex(e => e.Ma, "UQ__MoiQuanH__3214CC9E66758884").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3214EC07871C7503");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.Ma, "UQ__NhanVien__3214CC9EFA710D6F").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.Ho).HasMaxLength(30);
            entity.Property(e => e.IdCv).HasColumnName("IdCV");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau).IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TenDem).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdCvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdCv)
                .HasConstraintName("FK1_NV");
        });

        modelBuilder.Entity<Nxb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NXB__3214EC073592C5C0");

            entity.ToTable("NXB");

            entity.HasIndex(e => e.Ma, "UQ__NXB__3214CC9E5150EDB4").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sach__3214EC071618D78B");

            entity.ToTable("Sach");

            entity.HasIndex(e => e.Ma, "UQ__Sach__3214CC9EC3692C5A").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DonGia)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdNxb).HasColumnName("IdNXB");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayXuatBan).HasColumnType("date");
            entity.Property(e => e.SoTrang).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdNxbNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.IdNxb)
                .HasConstraintName("FK1_NXB");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3214EC070602CEB2");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.Ma, "UQ__SanPham__3214CC9EE6E0C918").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdLoaiSp).HasColumnName("IdLoaiSP");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mota).HasMaxLength(30);
            entity.Property(e => e.NgaySx)
                .HasColumnType("date")
                .HasColumnName("NgaySX");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            entity.Property(e => e.Website).HasMaxLength(30);

            entity.HasOne(d => d.IdLoaiSpNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdLoaiSp)
                .HasConstraintName("FK1_LSP");
        });

        modelBuilder.Entity<XeMay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__XeMay__3214EC074876ECDD");

            entity.ToTable("XeMay");

            entity.HasIndex(e => e.Ma, "UQ__XeMay__3214CC9EDC911877").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.GiaNhap)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdLxm).HasColumnName("IdLXM");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mota).HasMaxLength(30);
            entity.Property(e => e.NgaySx)
                .HasColumnType("date")
                .HasColumnName("NgaySX");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            entity.Property(e => e.Website).HasMaxLength(30);

            entity.HasOne(d => d.IdLxmNavigation).WithMany(p => p.XeMays)
                .HasForeignKey(d => d.IdLxm)
                .HasConstraintName("FK1_LXM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
