using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _1_DAL_QLNT.Services;
using _2_BUS_QLNT.IServices;

namespace _2_BUS_QLNT.Services
{
    public class ServicesQLHoaDon:IServicesQLHoaDon
    {
        private IServicesHoaDon _iServicesHoaDon;
        private IServicesHoaDonChiTiet _iServicesHoaDonChiTiet;
        private IServicesDichVu _iServicesDichVu;
        private IServicesHopDong _iServicesHopDong;
        private IServicesDienNuoc _iServicesDienNuoc;
        private IServicesQLHoaDon _servicesQlHoaDon;
        private IServicesNguoiThue _iServicesNguoiThue;

        public ServicesQLHoaDon()
        {
            _iServicesDichVu = new ServicesDichVu();
            _iServicesDienNuoc = new ServicesDienNuoc();
            _iServicesHoaDonChiTiet = new ServicesHoaDonChiTiet();
            _iServicesHopDong = new ServicesHopDong();
            _iServicesHoaDon = new ServicesHoaDon();
            _iServicesNguoiThue = new ServicesNguoiThue();
        }
        public List<HoaDon> LoadDataHoaDon()
        {
            return _iServicesHoaDon.LoadDataHoaDon();
        }

        public List<HoaDonChiTiet> LoadDataHDCT()
        {
            return _iServicesHoaDonChiTiet.LoadDataHDCT();
        }

        public List<HopDong> LoadDataHopDong()
        {
            return _iServicesHopDong.LoadDataHD();
        }

        public List<DienNuoc> LoadDataDienNuoc()
        {
            return _iServicesDienNuoc.LoadDataDienNuoc();
        }

        public List<DichVu> LoadDataDV()
        {
            return _iServicesDichVu.LoadDataDichVu();
        }

        public List<NguoiThue> LoadDataNgThue()
        {
            return _iServicesNguoiThue.LoadDataNguoiThue();
        }

        public string AddHoaDon(HoaDon hoaDon)
        {
            return _iServicesHoaDon.AddDV(hoaDon);
        }

        public string UpdateHoaDon(HoaDon hoaDon)
        {
            return _iServicesHoaDon.UpdateDV(hoaDon);
        }

        public string UpdateHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            return _iServicesHoaDonChiTiet.UpdateHDCT(hoaDonChiTiet);
        }
    }
}
