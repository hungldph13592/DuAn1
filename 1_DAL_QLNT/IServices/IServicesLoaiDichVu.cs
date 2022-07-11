using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesLoaiDichVu
    {
        public void DBLoaiDV();
        public List<LoaiDichVu> LoadDataLoaiDV();
        public string AddLoaiDV(LoaiDichVu loaiDichVu);
        public string UpdateLoaiDV(LoaiDichVu loaiDichVu);
    }
}
