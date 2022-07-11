using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesHopDong:IServicesHopDong
    {
        private List<HopDong> _lstHopDongs;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesHopDong()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstHopDongs = new List<HopDong>();
            DBHopDong();
        }
        public void DBHopDong()
        {
            _lstHopDongs = _dbContetxQlnt.HopDongs.ToList();
        }

        public List<HopDong> LoadDataHD()
        {
            return _lstHopDongs;
        }

        public string AddHopDong(HopDong hopDong)
        {
            _dbContetxQlnt.HopDongs.Add(hopDong);
            _dbContetxQlnt.SaveChanges();
            DBHopDong();
            return "Đã thêm thành công!";
        }

        public string UpdateHopDong(HopDong hopDong)
        {
            _dbContetxQlnt.HopDongs.Update(hopDong);
            _dbContetxQlnt.SaveChanges();
            DBHopDong();
            return "Đã cập nhật!";
        }
    }
}
