using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesHoaDonChiTiet:IServicesHoaDonChiTiet
    {
        private List<HoaDonChiTiet> _lstHoaDonChiTiets;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesHoaDonChiTiet()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstHoaDonChiTiets = new List<HoaDonChiTiet>();
            DBHoaDonCT();
        }
        public void DBHoaDonCT()
        {
            _lstHoaDonChiTiets = _dbContetxQlnt.HoaDonChiTiets.ToList();
        }

        public List<HoaDonChiTiet> LoadDataHDCT()
        {
            return _lstHoaDonChiTiets;
        }

        public string AddHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            _dbContetxQlnt.HoaDonChiTiets.Add(hoaDonChiTiet);
            _dbContetxQlnt.SaveChanges();
            DBHoaDonCT();
            return "Đã thêm thành công!";
        }

        public string UpdateHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            _dbContetxQlnt.HoaDonChiTiets.Update(hoaDonChiTiet);
            _dbContetxQlnt.SaveChanges();
            DBHoaDonCT();
            return "Đã cập nhật!";
        }
    }
}
