using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _2_BUS_QLNT.IServices
{
    public interface IServicesDangThue
    {
        public List< HoaDon> LoadDataHoaDon();
        public void AddHDCT(HoaDonChiTiet hoaDonChiTiet);
        public List<DichVu> LoadDataDichVu();
        public string UpdateHoaDon(HoaDon hoaDon);
        public List<NguoiThue> LoadDataNguoiThues();
        public List<DichVu> LoadDataDV();
        public List<HoaDonChiTiet> LoaDataHDCT();
    }
}
