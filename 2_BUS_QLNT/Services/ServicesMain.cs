using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;

namespace _2_BUS_QLNT.Services
{
    public class ServicesMain:IServicesMain
    {
        private IServicesPhongTro _iServicesPhongTro;
        private IServicesTang _iServicesTang;
        private IServicesLoaiPhong _iServicesLoaiPhong;
        private IServicesNguoiThue _iServicesNguoiThue;
        private IServicesHopDong _iServicesHopDong;

        public ServicesMain()
        {
            _iServicesTang = new ServicesTang();
            _iServicesLoaiPhong = new ServicesLoaiPhong();
            _iServicesPhongTro = new ServicesPhongTro();
            _iServicesNguoiThue = new ServicesNguoiThue();
            _iServicesHopDong = new ServicesHopDong();
        }
        public List<PhongTro> LoadDataPhong()
        {
            return _iServicesPhongTro.LoadDataPhongTro();
        }

        public List<Tang> LoadDataTang()
        {
            return _iServicesTang.LoadDataTang();
        }

        public List<NguoiThue> LoadDataNgThue()
        {
            return _iServicesNguoiThue.LoadDataNguoiThue();
        }

        public List<LoaiPhong> LoadDataLoaiPhong()
        {
            return _iServicesLoaiPhong.LoadDataLoaiPhong();
        }

        public List<HopDong> LoadDataHopDong()
        {
            return _iServicesHopDong.LoadDataHD();
        }
    }
}
