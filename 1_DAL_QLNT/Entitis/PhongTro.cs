using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("PhongTro")]
    public class PhongTro
    {
        [Key][StringLength(10)]public string MaPhongTro { get; set; }
        [ForeignKey("LoaiPhongs")] [StringLength(10)]public string MaLoaiPhong { get; set; }
        [ForeignKey("Tangs")] [StringLength(10)]public string MaTang { get; set; }
        public int TrangThai { get; set; }
        public virtual LoaiPhong LoaiPhongs { get; set; }
        public virtual Tang Tangs { get; set; }
        public virtual ICollection<HopDong>HopDongs { get; set; }
    }
}
