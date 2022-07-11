using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Services;

namespace _2_BUS_QLNT.Services
{
    public class QuanLyDienNuoc : IQuanLyDienNuoc
    {
        private IServicesDienNuoc _iServiceDienNuoc;

        public QuanLyDienNuoc()
        {
            _iServiceDienNuoc = new ServicesDienNuoc();
        }
        public List<DienNuoc> LoadDataLoaiDn()
        {
            return _iServiceDienNuoc.LoadDataDienNuoc();
        }

        public string AddDV(DienNuoc dienNuoc)
        {
            return _iServiceDienNuoc.AddDienNuoc(dienNuoc);
        }

        public string EditDV(DienNuoc dienNuoc)
        {
            return _iServiceDienNuoc.UpdateDienNuoc(dienNuoc);
        }

       
    }
}
