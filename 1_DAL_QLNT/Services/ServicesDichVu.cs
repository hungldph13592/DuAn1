using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesDichVu:IServicesDichVu
    {
        private List<DichVu> _lstDichVus;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesDichVu()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstDichVus = new List<DichVu>();
            DBDichVu();
        }
        public void DBDichVu()
        {
            _lstDichVus = _dbContetxQlnt.DichVus.ToList();
        }

        public List<DichVu> LoadDataDichVu()
        {
            return _lstDichVus;
        }

        public string AddDV(DichVu dichVu)
        {
            _dbContetxQlnt.DichVus.Add(dichVu);
            _dbContetxQlnt.SaveChanges();
            DBDichVu();
            return "Đã thêm thành công!";
        }

        public string UpdateDV(DichVu dichVu)
        {
            _dbContetxQlnt.DichVus.Update(dichVu);
            _dbContetxQlnt.SaveChanges();
            DBDichVu();
            return "Đã cập nhật!";
        }
    }
}
