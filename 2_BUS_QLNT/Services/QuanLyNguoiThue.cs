using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.Services
{
     public class QuanLyNguoiThue : IQuanLyNguoiThue
     {
        private IServicesNguoiThue _iServicesNguoiThue;


        public QuanLyNguoiThue()
        {
            _iServicesNguoiThue = new ServicesNguoiThue();
        }


        public List<NguoiThue> LoaDataDV()
        {
            return _iServicesNguoiThue.LoadDataNguoiThue();
        }

        public string AddDV(NguoiThue nguoiThue)
        {
            return _iServicesNguoiThue.AddNguoiThue(nguoiThue);
        }

        public string EditDV(NguoiThue nguoiThue)
        {
            return _iServicesNguoiThue.UpdateNguoiThue(nguoiThue);
        }
    }
}
