using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesDangNhap:IServicesDangNhap
    {
        private List<DangNhap> _lstDangNhaps;
        private DBContetxQLNT _dbContetxQlnt;
        public ServicesDangNhap()
        {
            _lstDangNhaps = new List<DangNhap>();
            _dbContetxQlnt = new DBContetxQLNT();
            getDBDangNhap();
        }

        public void getDBDangNhap()
        {
            _lstDangNhaps = _dbContetxQlnt.DangNhaps.ToList();
        }

        public void DBInsertTK(DangNhap dangNhap)
        {
            _dbContetxQlnt.DangNhaps.Add(dangNhap);
            _dbContetxQlnt.SaveChanges();
        }
        public List<DangNhap> getListDangNhap()
        {
            return _lstDangNhaps;
        }
        public bool checkmail(string email)
        {
            for (int i = 0; i < _lstDangNhaps.Count; i++)
            {
                if (_lstDangNhaps[i].TaiKhoan == email)
                {
                    return true;
                }
            }
            return false;
        }
        public bool DBUpdateTK(DangNhap dangNhap, string email)
        {
            for (int i = 0; i < _lstDangNhaps.Count; i++)
            {
                if (_lstDangNhaps[i].TaiKhoan == email)
                {
                    _dbContetxQlnt.DangNhaps.Update(dangNhap);
                    _dbContetxQlnt.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public void doiMk(DangNhap dangNhap)
        {
            _dbContetxQlnt.DangNhaps.Update(dangNhap);
            _dbContetxQlnt.SaveChanges();
        }
    }
}
