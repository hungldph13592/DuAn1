using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesLoaiDichVu:IServicesLoaiDichVu
    {
        private List<LoaiDichVu> _lstLoaiDichVus;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesLoaiDichVu()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstLoaiDichVus = new List<LoaiDichVu>();
            DBLoaiDV();
        }
        public void DBLoaiDV()
        {
            _lstLoaiDichVus = _dbContetxQlnt.LoaiDichVus.ToList();
        }

        public List<LoaiDichVu> LoadDataLoaiDV()
        {
            return _lstLoaiDichVus;
        }

        public string AddLoaiDV(LoaiDichVu loaiDichVu)
        {
            _dbContetxQlnt.LoaiDichVus.Add(loaiDichVu);
            _dbContetxQlnt.SaveChanges();
            DBLoaiDV();
            return "Đã thêm thành công!";
        }

        public string UpdateLoaiDV(LoaiDichVu loaiDichVu)
        {
            _dbContetxQlnt.LoaiDichVus.Update(loaiDichVu);
            _dbContetxQlnt.SaveChanges();
            DBLoaiDV();
            return "Đã cập nhật!";
        }
    }
}
