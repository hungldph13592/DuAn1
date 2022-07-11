using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesHopDong
    {
        public void DBHopDong();
        public List<HopDong> LoadDataHD();
        public string AddHopDong(HopDong hopDong);
        public string UpdateHopDong(HopDong hopDong);
    }
}
