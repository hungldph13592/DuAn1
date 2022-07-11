using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("HoaDonCT")]
    public class HoaDonChiTiet
    {
        [Key][StringLength(50)]public string MaHoaDonCT { get; set; }
        [ForeignKey("HoaDon")][StringLength(50)]public string MaHoaDon { get; set; }
        [ForeignKey("DichVu")][StringLength(10)]public string MaDV { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime ThoiHan { get; set; }
        public virtual DichVu DichVu { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
