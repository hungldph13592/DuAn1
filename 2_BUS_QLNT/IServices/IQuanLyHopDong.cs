using _1_DAL_QLNT.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.IServices
{
    public interface IQuanLyHopDong
    {
        List<HopDong> GetLstHopDong();
        string AddHD(HopDong hd);
        string UpdateHD(HopDong hd);
        string AddHoaDon(HoaDon hoaDon);
        List<DienNuoc> GetLstDienNuoc();
        string AddHoaDonCT(HoaDonChiTiet hoaDonChiTiet);
    }
}
