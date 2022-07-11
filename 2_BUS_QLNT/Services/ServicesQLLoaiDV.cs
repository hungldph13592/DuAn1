using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;

namespace _2_BUS_QLNT.Services
{
    public class ServicesQLLoaiDV:IServicesQLLoaiDV
    {
        private IServicesLoaiDichVu _iServicesLoaiDichVu;

        public ServicesQLLoaiDV()
        {
            _iServicesLoaiDichVu = new ServicesLoaiDichVu();
        }
        public List<LoaiDichVu> LoadDataLoaiDV()
        {
            return _iServicesLoaiDichVu.LoadDataLoaiDV();
        }

        public string AddLoaiDV(LoaiDichVu loaiDichVu)
        {
            return _iServicesLoaiDichVu.AddLoaiDV(loaiDichVu);
        }

        public string EditLoaiDV(LoaiDichVu loaiDichVu)
        {
            return _iServicesLoaiDichVu.UpdateLoaiDV(loaiDichVu);
        }
    }
}
