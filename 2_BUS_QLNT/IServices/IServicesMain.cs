using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _2_BUS_QLNT.IServices
{
    public interface IServicesMain
    {
        public List<PhongTro> LoadDataPhong();
        public List<Tang> LoadDataTang();
        public List<NguoiThue> LoadDataNgThue();
        public List<LoaiPhong> LoadDataLoaiPhong();
        public List<HopDong> LoadDataHopDong();
    }
}
