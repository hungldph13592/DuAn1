using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _2_BUS_QLNT.IServices
{
    public interface IServicesDoiTT
    {
        public List<PhongTro> LoadDataPhongTro();
        public void Update(PhongTro phongTro);
    }
}
