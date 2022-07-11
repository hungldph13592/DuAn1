using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key][StringLength(50)]public string MaHoaDon { get; set; }
        [ForeignKey("HopDong")][StringLength(10)]public string MaHopDong { get; set; }
        [ForeignKey("DienNuoc")][StringLength(10)]public string MaDienNuoc { get; set; }
        public DateTime NgayThang { get; set; }
        public int TrangThai { get; set; }
        public int SoDien { get; set; }
        public int SoNuoc { get; set; }
        public float TienNha { get; set; }
        public float TienDichVu { get; set; }
        public float TienGiamGia { get; set; }
        public float TienThanhToan { get; set; }
        public virtual HopDong HopDong { get; set; }
        public virtual DienNuoc DienNuoc { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
    }
}
