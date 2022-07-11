using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesNguoiThue:IServicesNguoiThue
    {
        private List<NguoiThue> _lstNguoiThues;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesNguoiThue()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstNguoiThues = new List<NguoiThue>();
            DBNguoiThue();
        }
        public void DBNguoiThue()
        {
            _lstNguoiThues = _dbContetxQlnt.NNguoiThues.ToList();
        }

        public List<NguoiThue> LoadDataNguoiThue()
        {
            return _lstNguoiThues;
        }

        public string AddNguoiThue(NguoiThue nguoiThue)
        {
            _dbContetxQlnt.NNguoiThues.Add(nguoiThue);
            _dbContetxQlnt.SaveChanges();
            DBNguoiThue();
            return "Đã thêm thành công!";
        }

        public string UpdateNguoiThue(NguoiThue nguoiThue)
        {
            _dbContetxQlnt.NNguoiThues.Update(nguoiThue);
            _dbContetxQlnt.SaveChanges();
            DBNguoiThue();
            return "Đã cập nhật!";
        }
    }
}
