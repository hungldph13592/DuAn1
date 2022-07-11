using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesLoaiPhong:IServicesLoaiPhong
    {
        private List<LoaiPhong> _lstLoaiPhongs;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesLoaiPhong()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstLoaiPhongs = new List<LoaiPhong>();
            DBLoaiPhong();
        }
        public void DBLoaiPhong()
        {
            _lstLoaiPhongs = _dbContetxQlnt.LoaiPhongs.ToList();
        }

        public List<LoaiPhong> LoadDataLoaiPhong()
        {
            return _lstLoaiPhongs;
        }

        public string AddLoaiPhong(LoaiPhong loaiPhong)
        {
            _dbContetxQlnt.LoaiPhongs.Add(loaiPhong);
            _dbContetxQlnt.SaveChanges();
            DBLoaiPhong();
            return "Đã thêm thành công!";
        }

        public string UpdateLoaiPhong(LoaiPhong loaiPhong)
        {
            _dbContetxQlnt.LoaiPhongs.Update(loaiPhong);
            _dbContetxQlnt.SaveChanges();
            DBLoaiPhong();
            return "Đã cập nhật!!";
        }
    }
}
