using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_QLNT.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DangNhap",
                columns: table => new
                {
                    TaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangNhap", x => x.TaiKhoan);
                });

            migrationBuilder.CreateTable(
                name: "DienNuoc",
                columns: table => new
                {
                    MaDienNuoc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GiaDien = table.Column<float>(type: "real", nullable: false),
                    GiaNuoc = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienNuoc", x => x.MaDienNuoc);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    MaLoaiDV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenLoaiDV = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVu", x => x.MaLoaiDV);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    MaLoaiPhong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenLoaiPhong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTich = table.Column<float>(type: "real", nullable: false),
                    GiaThue = table.Column<float>(type: "real", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.MaLoaiPhong);
                });

            migrationBuilder.CreateTable(
                name: "NguoiThue",
                columns: table => new
                {
                    MaNguoiThue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SoDT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CMND = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    QueQuan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NamSinh = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiThue", x => x.MaNguoiThue);
                });

            migrationBuilder.CreateTable(
                name: "Tang",
                columns: table => new
                {
                    MaTang = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TangNha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tang", x => x.MaTang);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    MaDV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaLoaiDV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TenDV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.MaDV);
                    table.ForeignKey(
                        name: "FK_DichVu_LoaiDichVu_MaLoaiDV",
                        column: x => x.MaLoaiDV,
                        principalTable: "LoaiDichVu",
                        principalColumn: "MaLoaiDV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhongTro",
                columns: table => new
                {
                    MaPhongTro = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaLoaiPhong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MaTang = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongTro", x => x.MaPhongTro);
                    table.ForeignKey(
                        name: "FK_PhongTro_LoaiPhong_MaLoaiPhong",
                        column: x => x.MaLoaiPhong,
                        principalTable: "LoaiPhong",
                        principalColumn: "MaLoaiPhong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhongTro_Tang_MaTang",
                        column: x => x.MaTang,
                        principalTable: "Tang",
                        principalColumn: "MaTang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    MaHopDong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaNguoiThue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MaPhongTro = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SoThangTraTruoc = table.Column<int>(type: "int", nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienCoc = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.MaHopDong);
                    table.ForeignKey(
                        name: "FK_HopDong_NguoiThue_MaNguoiThue",
                        column: x => x.MaNguoiThue,
                        principalTable: "NguoiThue",
                        principalColumn: "MaNguoiThue",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HopDong_PhongTro_MaPhongTro",
                        column: x => x.MaPhongTro,
                        principalTable: "PhongTro",
                        principalColumn: "MaPhongTro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaHopDong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MaDienNuoc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgayThang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    SoDien = table.Column<int>(type: "int", nullable: false),
                    SoNuoc = table.Column<int>(type: "int", nullable: false),
                    TienNha = table.Column<float>(type: "real", nullable: false),
                    TienDichVu = table.Column<float>(type: "real", nullable: false),
                    TienGiamGia = table.Column<float>(type: "real", nullable: false),
                    TienThanhToan = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_DienNuoc_MaDienNuoc",
                        column: x => x.MaDienNuoc,
                        principalTable: "DienNuoc",
                        principalColumn: "MaDienNuoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_HopDong_MaHopDong",
                        column: x => x.MaHopDong,
                        principalTable: "HopDong",
                        principalColumn: "MaHopDong",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    MaHoaDonCT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaDV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiHan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => x.MaHoaDonCT);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_DichVu_MaDV",
                        column: x => x.MaDV,
                        principalTable: "DichVu",
                        principalColumn: "MaDV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_HoaDon_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_MaLoaiDV",
                table: "DichVu",
                column: "MaLoaiDV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaDienNuoc",
                table: "HoaDon",
                column: "MaDienNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHopDong",
                table: "HoaDon",
                column: "MaHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaDV",
                table: "HoaDonCT",
                column: "MaDV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaHoaDon",
                table: "HoaDonCT",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_MaNguoiThue",
                table: "HopDong",
                column: "MaNguoiThue");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_MaPhongTro",
                table: "HopDong",
                column: "MaPhongTro");

            migrationBuilder.CreateIndex(
                name: "IX_PhongTro_MaLoaiPhong",
                table: "PhongTro",
                column: "MaLoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_PhongTro_MaTang",
                table: "PhongTro",
                column: "MaTang");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangNhap");

            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");

            migrationBuilder.DropTable(
                name: "DienNuoc");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "NguoiThue");

            migrationBuilder.DropTable(
                name: "PhongTro");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "Tang");
        }
    }
}
