using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("Tang")]
    public class Tang
    {
        [Key]
        [StringLength(10)] public string MaTang { get; set; }
        public string TangNha { get; set; }
        public virtual ICollection<PhongTro> PhongTros { get; set; }
    }
}
