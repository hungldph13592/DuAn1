using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.Entitis
{
    [Table("DangNhap")]
    public class DangNhap
    {
        [Key] public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
}
