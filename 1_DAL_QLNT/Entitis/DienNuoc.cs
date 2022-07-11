using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("DienNuoc")]
    public class DienNuoc
    {
        [Key][StringLength(10)]public string MaDienNuoc { get; set; }
        public float GiaDien { get; set; }
        public float GiaNuoc { get; set; }
        public virtual ICollection<HoaDon>HoaDons { get; set; }
    }
}
