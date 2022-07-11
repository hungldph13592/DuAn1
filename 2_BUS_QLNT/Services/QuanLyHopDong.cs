using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _1_DAL_QLNT.Services;
using _2_BUS_QLNT.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.Services
{
    public class QuanLyHopDong : IQuanLyHopDong
    {
        private IServicesHopDong DAL_HD;
        private IServicesHoaDon DAL_HoaDon;
        private IServicesDienNuoc DAL_DienNuoc;
        private IServicesHoaDonChiTiet DAL_HDCT;
        public QuanLyHopDong()
        {
            DAL_HD = new ServicesHopDong();
            DAL_HoaDon = new ServicesHoaDon();
            DAL_DienNuoc = new ServicesDienNuoc();
            DAL_HDCT = new ServicesHoaDonChiTiet();
        }

        public string AddHD(HopDong hd)
        {
            return DAL_HD.AddHopDong(hd);
        }

        public string AddHoaDon(HoaDon hoaDon)
        {
            return DAL_HoaDon.AddDV(hoaDon);
        }

        public string AddHoaDonCT(HoaDonChiTiet hoaDonChiTiet)
        {
            return DAL_HDCT.AddHDCT(hoaDonChiTiet);
        }

        public List<DienNuoc> GetLstDienNuoc()
        {
            return DAL_DienNuoc.LoadDataDienNuoc();
        }

        public List<HopDong> GetLstHopDong()
        {
            return DAL_HD.LoadDataHD();
        }

        public string UpdateHD(HopDong hd)
        {
            return DAL_HD.UpdateHopDong(hd);
        }
    }
}
