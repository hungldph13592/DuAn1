using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesTang:IServicesTang
    {
        private List<Tang> _lstTangs;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesTang()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstTangs = new List<Tang>();
            DBTangNha();
        }
        public void DBTangNha()
        {
            _lstTangs = _dbContetxQlnt.Tangs.ToList();
        }

        public List<Tang> LoadDataTang()
        {
            return _lstTangs;
        }

        public string AddTang(Tang tang)
        {
            _dbContetxQlnt.Tangs.Add(tang);
            _dbContetxQlnt.SaveChanges();
            DBTangNha();
            return "Đã thêm thành công!";
        }

        public string UpdateTang(Tang tang)
        {
            _dbContetxQlnt.Tangs.Update(tang);
            _dbContetxQlnt.SaveChanges();
            DBTangNha();
            return "Đã cập nhật!";
        }
    }
}
