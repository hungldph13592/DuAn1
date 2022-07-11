using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.Services
{
    public class QuanLyTang : IQuanLyTang
    {
        private IServicesTang DAL_Tang;
        public QuanLyTang()
        {
            DAL_Tang = new ServicesTang();
        }
        public string AddTang(Tang tg)
        {
            return DAL_Tang.AddTang(tg);
        }

        public List<Tang> LstTang()
        {
            return DAL_Tang.LoadDataTang();
        }
    }
}
