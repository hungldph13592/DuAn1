using _1_DAL_QLNT.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesDienNuoc
    {
        public void DBDienNuoc();
        public List<DienNuoc> LoadDataDienNuoc();
        public string AddDienNuoc(DienNuoc dienNuoc);
        public string UpdateDienNuoc(DienNuoc dienNuoc);
    }
}
