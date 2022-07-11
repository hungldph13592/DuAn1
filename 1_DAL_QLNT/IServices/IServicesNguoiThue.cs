using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesNguoiThue
    {
        public void DBNguoiThue();
        public List<NguoiThue> LoadDataNguoiThue();
        public string AddNguoiThue(NguoiThue nguoiThue);
        public string UpdateNguoiThue(NguoiThue nguoiThue);
    }
}
