using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesPhongTro
    {
        public void DBPhongTro();
        public List<PhongTro> LoadDataPhongTro();
        public string AddPhpng(PhongTro phongTro);
        public string UpdatePhong(PhongTro phongTro);
    }
}
