using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("DichVu")]
    public class DichVu
    {
        [Key][StringLength(10)]public string MaDV { get; set; }
        [ForeignKey("LoaiDichVu")][StringLength(10)]public string MaLoaiDV { get; set; }
        public string TenDV { get; set; }
        public float DonGia { get; set; }
        public int TrangThai { get; set; }
        public virtual LoaiDichVu LoaiDichVu { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
    }
}
