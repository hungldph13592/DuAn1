using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesHoaDon:IServicesHoaDon
    {
        private List<HoaDon> _lstHoaDons;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesHoaDon()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstHoaDons = new List<HoaDon>();
            DBHoaDon();
        }
        public void DBHoaDon()
        {
            _lstHoaDons = _dbContetxQlnt.HoaDons.ToList();
        }

        public List<HoaDon> LoadDataHoaDon()
        {
            return _lstHoaDons;
        }

        public string AddDV(HoaDon hoaDon)
        {
            _dbContetxQlnt.HoaDons.Add(hoaDon);
            _dbContetxQlnt.SaveChanges();
            DBHoaDon();
            return "Đã thêm thành công!";
        }

        public string UpdateDV(HoaDon hoaDon)
        {
            _dbContetxQlnt.HoaDons.Update(hoaDon);
            _dbContetxQlnt.SaveChanges();
            DBHoaDon();
            return "Đã cập nhật!";
        }
    }
}
