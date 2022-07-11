using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("NguoiThue")]
    public class NguoiThue
    {
        [Key] [StringLength(10)] public string MaNguoiThue { get; set; }
        [StringLength(30)]public string HoVaTen { get; set; }
        [StringLength(15)]public string SoDT { get; set; }
        [StringLength(15)]public string CMND { get; set; }
        [StringLength(20)]public string QueQuan { get; set; }
        public int NamSinh { get; set; }
        public bool GioiTinh { get; set; }
        public string Email { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<HopDong> HopDong { get; set; }
    }
}
