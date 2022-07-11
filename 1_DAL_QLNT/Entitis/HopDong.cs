using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.Entitis
{
    [Table("HopDong")]
    public class HopDong
    {
        [Key][StringLength(10)]public string MaHopDong { get; set; }
        [ForeignKey("NguoiThue")][StringLength(10)] public string MaNguoiThue { get; set; }
        [ForeignKey("PhongTro")] [StringLength(10)] public string MaPhongTro { get; set; }
        public int SoThangTraTruoc { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime NgayHetHan { get; set; }
        public float TienCoc { get; set; }
        public string GhiChu { get; set; }
        public int TangThai { get; set; }
        public virtual NguoiThue NguoiThue { get; set; }
        public virtual PhongTro PhongTro { get; set; }
        public virtual ICollection<HoaDon>HoaDons { get; set; }
    }
}