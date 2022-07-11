using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;

namespace _2_BUS_QLNT.Services
{
    public class ServicesDangThue:IServicesDangThue
    {
        private IServicesDichVu _iServicesDichVu;
        private IServicesHoaDon _iServicesHoaDon;
        private IServicesHoaDonChiTiet _hoaDonChiTiet;
        private IServicesNguoiThue _iServicesNguoiThue;
        public ServicesDangThue()
        {
            _iServicesHoaDon = new ServicesHoaDon();
            _hoaDonChiTiet = new ServicesHoaDonChiTiet();
            _iServicesDichVu = new ServicesDichVu();
            _iServicesNguoiThue = new ServicesNguoiThue();
        }
        public List<HoaDon> LoadDataHoaDon()
        {
            return _iServicesHoaDon.LoadDataHoaDon();
        }

        public void AddHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            _hoaDonChiTiet.AddHDCT(hoaDonChiTiet);
        }

        public List<DichVu> LoadDataDichVu()
        {
            return _iServicesDichVu.LoadDataDichVu();
        }

        public string UpdateHoaDon(HoaDon hoaDon)
        {
            return _iServicesHoaDon.UpdateDV(hoaDon);
        }

        public List<NguoiThue> LoadDataNguoiThues()
        {
            return _iServicesNguoiThue.LoadDataNguoiThue();
        }

        public List<DichVu> LoadDataDV()
        {
            return _iServicesDichVu.LoadDataDichVu();
        }

        public List<HoaDonChiTiet> LoaDataHDCT()
        {
            return _hoaDonChiTiet.LoadDataHDCT();
        }
    }
}
