using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesTang
    {
        public void DBTangNha();
        public List<Tang> LoadDataTang();
        public string AddTang(Tang tang);
        public string UpdateTang(Tang tang);
    }
}
