using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _2_BUS_QLNT.IServices
{
    public interface IServicesQLDichVu
    {
        public List<DichVu> LoaDataDV();
        public List<LoaiDichVu> LoadDataLoaiDV();
        public string AddDV(DichVu dichVu);
        public string EditDV(DichVu dichVu);
    }
}
