using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("LoaiPhong")]
    public class LoaiPhong
    {
        [Key][StringLength(10)]public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public float DienTich { get; set; }
        public float GiaThue { get; set; }
        public string HinhAnh { get; set; }
        public virtual ICollection<PhongTro> PhongTros { get; set; }
    }
}
