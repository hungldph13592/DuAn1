using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;

namespace _1_DAL_QLNT.Services
{
    public class ServicesDienNuoc:IServicesDienNuoc
    {
        private DBContetxQLNT _dbContetxQlnt;
        private List<DienNuoc> _lstDienNuocs;
        public ServicesDienNuoc()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstDienNuocs = new List<DienNuoc>();
            DBDienNuoc();
        }

        public void DBDienNuoc()
        {
            _lstDienNuocs=_dbContetxQlnt.DienNuocs.ToList();
        }

        public List<DienNuoc> LoadDataDienNuoc()
        {
            return _lstDienNuocs;
        }

        public string AddDienNuoc(DienNuoc dienNuoc)
        {
            _dbContetxQlnt.DienNuocs.Add(dienNuoc);
            _dbContetxQlnt.SaveChanges();
            DBDienNuoc();
            return "Đã thêm thành công!";
        }

        public string UpdateDienNuoc(DienNuoc dienNuoc)
        {
            _dbContetxQlnt.DienNuocs.Update(dienNuoc);
            _dbContetxQlnt.SaveChanges();
            DBDienNuoc();
            return "Đã cập nhật!";
        }
    }
}
