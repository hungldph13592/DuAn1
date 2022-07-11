using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public interface IServicesDangNhap
    {
        public void getDBDangNhap();//lấy dữ liệu từ CSDL
        public List<DangNhap> getListDangNhap();//gán dự liệu vào list
        void DBInsertTK(DangNhap dangNhap);
        bool checkmail(string email);
        bool DBUpdateTK(DangNhap dangNhap, string email);
        void doiMk(DangNhap dangNhap);
    }
}
