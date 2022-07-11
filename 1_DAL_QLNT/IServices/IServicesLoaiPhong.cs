using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesLoaiPhong
    {
        public void DBLoaiPhong();
        public List<LoaiPhong> LoadDataLoaiPhong();
        public string AddLoaiPhong(LoaiPhong loaiPhong);
        public string UpdateLoaiPhong(LoaiPhong loaiPhong);
    }
}
