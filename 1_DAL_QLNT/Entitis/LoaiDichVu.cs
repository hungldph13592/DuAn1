using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("LoaiDichVu")]
    public class LoaiDichVu
    {
        [Key][StringLength(10)]public string MaLoaiDV{get; set; }
        public string TenLoaiDV { get; set; }
        public virtual ICollection<DichVu>DichVus { get; set; }
    }
}
