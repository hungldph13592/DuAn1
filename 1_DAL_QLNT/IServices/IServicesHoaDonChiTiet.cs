using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesHoaDonChiTiet
    {
        public void DBHoaDonCT();
        public List<HoaDonChiTiet> LoadDataHDCT();
        public string AddHDCT(HoaDonChiTiet hoaDonChiTiet);
        public string UpdateHDCT(HoaDonChiTiet hoaDonChiTiet);
    }
}
