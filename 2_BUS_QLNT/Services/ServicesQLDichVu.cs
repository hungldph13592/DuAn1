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
    public class ServicesQLDichVu:IServicesQLDichVu
    {
        private IServicesLoaiDichVu _iServicesLoaiDichVu;
        private IServicesDichVu _iServicesDichVu;

        public ServicesQLDichVu()
        {
            _iServicesLoaiDichVu = new ServicesLoaiDichVu();
            _iServicesDichVu = new ServicesDichVu();
        }
        public List<DichVu> LoaDataDV()
        {
            return _iServicesDichVu.LoadDataDichVu();
        }

        public List<LoaiDichVu> LoadDataLoaiDV()
        {
            return _iServicesLoaiDichVu.LoadDataLoaiDV();
        }

        public string AddDV(DichVu dichVu)
        {
            return _iServicesDichVu.AddDV(dichVu);
        }

        public string EditDV(DichVu dichVu)
        {
            return _iServicesDichVu.UpdateDV(dichVu);
        }
    }
}
