using _1_DAL_QLNT.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.IServices
{
    public interface IQuanLyTang
    {
        string AddTang(Tang tg);
        List<Tang> LstTang();
    }
}
