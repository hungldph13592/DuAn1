﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_QLNT.DBContext;

namespace _1_DAL_QLNT.Migrations
{
    [DbContext(typeof(DBContetxQLNT))]
    partial class DBContetxQLNTModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.DangNhap", b =>
                {
                    b.Property<string>("TaiKhoan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaiKhoan");

                    b.ToTable("DangNhap");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.DichVu", b =>
                {
                    b.Property<string>("MaDV")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("DonGia")
                        .HasColumnType("real");

                    b.Property<string>("MaLoaiDV")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenDV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaDV");

                    b.HasIndex("MaLoaiDV");

                    b.ToTable("DichVu");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.DienNuoc", b =>
                {
                    b.Property<string>("MaDienNuoc")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("GiaDien")
                        .HasColumnType("real");

                    b.Property<float>("GiaNuoc")
                        .HasColumnType("real");

                    b.HasKey("MaDienNuoc");

                    b.ToTable("DienNuoc");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HoaDon", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaDienNuoc")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaHopDong")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("NgayThang")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoDien")
                        .HasColumnType("int");

                    b.Property<int>("SoNuoc")
                        .HasColumnType("int");

                    b.Property<float>("TienDichVu")
                        .HasColumnType("real");

                    b.Property<float>("TienGiamGia")
                        .HasColumnType("real");

                    b.Property<float>("TienNha")
                        .HasColumnType("real");

                    b.Property<float>("TienThanhToan")
                        .HasColumnType("real");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaDienNuoc");

                    b.HasIndex("MaHopDong");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HoaDonChiTiet", b =>
                {
                    b.Property<string>("MaHoaDonCT")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaDV")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiHan")
                        .HasColumnType("datetime2");

                    b.HasKey("MaHoaDonCT");

                    b.HasIndex("MaDV");

                    b.HasIndex("MaHoaDon");

                    b.ToTable("HoaDonCT");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HopDong", b =>
                {
                    b.Property<string>("MaHopDong")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNguoiThue")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaPhongTro")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoThangTraTruoc")
                        .HasColumnType("int");

                    b.Property<int>("TangThai")
                        .HasColumnType("int");

                    b.Property<float>("TienCoc")
                        .HasColumnType("real");

                    b.HasKey("MaHopDong");

                    b.HasIndex("MaNguoiThue");

                    b.HasIndex("MaPhongTro");

                    b.ToTable("HopDong");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.LoaiDichVu", b =>
                {
                    b.Property<string>("MaLoaiDV")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenLoaiDV")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiDV");

                    b.ToTable("LoaiDichVu");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.LoaiPhong", b =>
                {
                    b.Property<string>("MaLoaiPhong")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("DienTich")
                        .HasColumnType("real");

                    b.Property<float>("GiaThue")
                        .HasColumnType("real");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoaiPhong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiPhong");

                    b.ToTable("LoaiPhong");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.NguoiThue", b =>
                {
                    b.Property<string>("MaNguoiThue")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CMND")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HoVaTen")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("NamSinh")
                        .HasColumnType("int");

                    b.Property<string>("QueQuan")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SoDT")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaNguoiThue");

                    b.ToTable("NguoiThue");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.PhongTro", b =>
                {
                    b.Property<string>("MaPhongTro")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaLoaiPhong")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaTang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaPhongTro");

                    b.HasIndex("MaLoaiPhong");

                    b.HasIndex("MaTang");

                    b.ToTable("PhongTro");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.Tang", b =>
                {
                    b.Property<string>("MaTang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TangNha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTang");

                    b.ToTable("Tang");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.DichVu", b =>
                {
                    b.HasOne("_1_DAL_QLNT.Entitis.LoaiDichVu", "LoaiDichVu")
                        .WithMany("DichVus")
                        .HasForeignKey("MaLoaiDV");

                    b.Navigation("LoaiDichVu");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HoaDon", b =>
                {
                    b.HasOne("_1_DAL_QLNT.Entitis.DienNuoc", "DienNuoc")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaDienNuoc");

                    b.HasOne("_1_DAL_QLNT.Entitis.HopDong", "HopDong")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaHopDong");

                    b.Navigation("DienNuoc");

                    b.Navigation("HopDong");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1_DAL_QLNT.Entitis.DichVu", "DichVu")
                        .WithMany("HoaDonChiTiet")
                        .HasForeignKey("MaDV");

                    b.HasOne("_1_DAL_QLNT.Entitis.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiet")
                        .HasForeignKey("MaHoaDon");

                    b.Navigation("DichVu");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HopDong", b =>
                {
                    b.HasOne("_1_DAL_QLNT.Entitis.NguoiThue", "NguoiThue")
                        .WithMany("HopDong")
                        .HasForeignKey("MaNguoiThue");

                    b.HasOne("_1_DAL_QLNT.Entitis.PhongTro", "PhongTro")
                        .WithMany("HopDongs")
                        .HasForeignKey("MaPhongTro");

                    b.Navigation("NguoiThue");

                    b.Navigation("PhongTro");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.PhongTro", b =>
                {
                    b.HasOne("_1_DAL_QLNT.Entitis.LoaiPhong", "LoaiPhongs")
                        .WithMany("PhongTros")
                        .HasForeignKey("MaLoaiPhong");

                    b.HasOne("_1_DAL_QLNT.Entitis.Tang", "Tangs")
                        .WithMany("PhongTros")
                        .HasForeignKey("MaTang");

                    b.Navigation("LoaiPhongs");

                    b.Navigation("Tangs");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.DichVu", b =>
                {
                    b.Navigation("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.DienNuoc", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.HopDong", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.LoaiDichVu", b =>
                {
                    b.Navigation("DichVus");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.LoaiPhong", b =>
                {
                    b.Navigation("PhongTros");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.NguoiThue", b =>
                {
                    b.Navigation("HopDong");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.PhongTro", b =>
                {
                    b.Navigation("HopDongs");
                });

            modelBuilder.Entity("_1_DAL_QLNT.Entitis.Tang", b =>
                {
                    b.Navigation("PhongTros");
                });
#pragma warning restore 612, 618
        }
    }
}