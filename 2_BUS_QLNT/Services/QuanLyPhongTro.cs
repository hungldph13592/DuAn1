using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.Services
{
    public class QuanLyPhongTro : IQuanLyPhongTro
    {
        private IServicesPhongTro DAL_PhongTro;
        public QuanLyPhongTro()
        {
            DAL_PhongTro = new ServicesPhongTro();
        }
        public string AddPT(PhongTro pt)
        {
            return DAL_PhongTro.AddPhpng(pt);
        }

        public List<PhongTro> GetLstPhongTro()
        {
            return DAL_PhongTro.LoadDataPhongTro();
        }

        public string UpdatePT(PhongTro pt)
        {
            return DAL_PhongTro.UpdatePhong(pt);
        }
    }
}
