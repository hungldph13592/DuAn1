using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesDichVu
    {
        public void DBDichVu();
        public List<DichVu> LoadDataDichVu();
        public string AddDV(DichVu dichVu);
        public string UpdateDV(DichVu dichVu);
    }
}
