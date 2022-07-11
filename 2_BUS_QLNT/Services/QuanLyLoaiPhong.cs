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
    public class QuanLyLoaiPhong : IQuanLyLoaiPhong
    {
        private IServicesLoaiPhong DAL_LoaiPhong;
        public QuanLyLoaiPhong()
        {
            DAL_LoaiPhong = new ServicesLoaiPhong();
        }
        public string AddLP(LoaiPhong lp)
        {
            return DAL_LoaiPhong.AddLoaiPhong(lp);
        }

        public List<LoaiPhong> GetLstLP()
        {
            return DAL_LoaiPhong.LoadDataLoaiPhong();
        }

        public string Update(LoaiPhong lp)
        {
            return DAL_LoaiPhong.UpdateLoaiPhong(lp);
        }
    }
}
