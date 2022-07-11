using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _2_BUS_QLNT.IServices
{
    public interface IServicesQLHoaDon
    {
        public List<HoaDon> LoadDataHoaDon();
        public List<HoaDonChiTiet> LoadDataHDCT();
        public List<HopDong> LoadDataHopDong();
        public List<DienNuoc> LoadDataDienNuoc();
        public List<DichVu> LoadDataDV();
        public List<NguoiThue> LoadDataNgThue();
        string AddHoaDon(HoaDon hoaDon);
        string UpdateHoaDon(HoaDon hoaDon);
        string UpdateHDCT(HoaDonChiTiet hoaDonChiTiet);
    }
}
