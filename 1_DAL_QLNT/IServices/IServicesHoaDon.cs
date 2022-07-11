using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesHoaDon
    {
        public void DBHoaDon();
        public List<HoaDon> LoadDataHoaDon();
        public string AddDV(HoaDon hoaDon);
        public string UpdateDV(HoaDon hoaDon);
    }
}
