using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_QLNT.DBContext
{
    public class DBContetxQLNT:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //alt+insert chọn Ov... member
            if (!optionsBuilder.IsConfigured)
            {
                //Khi cấu hình đổi tên DATABASE mà bạn muốn nó tạo ra
                optionsBuilder.UseSqlServer(
                    "Data Source=LAPTOP-IOP6D48P\\SQLEXPRESS;Initial Catalog=QLNT;User ID=hung;Password=hung");
            }
        }
        //2. Tiến hành tạo bảng
        public DbSet<DangNhap> DangNhaps { get; set; }
        public DbSet<Tang> Tangs { get; set; }
        public DbSet<NguoiThue> NNguoiThues { get; set; }
        public DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<PhongTro> PhongTros { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<DienNuoc> DienNuocs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
