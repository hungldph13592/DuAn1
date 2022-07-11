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
    public class ServicesDoiTT:IServicesDoiTT
    {
        private IServicesPhongTro _iServicesPhongTro;

        public ServicesDoiTT()
        {
            _iServicesPhongTro = new ServicesPhongTro();
        }
        public List<PhongTro> LoadDataPhongTro()
        {
            return _iServicesPhongTro.LoadDataPhongTro();
        }

        public void Update(PhongTro phongTro)
        {
            _iServicesPhongTro.UpdatePhong(phongTro);
        }
    }
}
