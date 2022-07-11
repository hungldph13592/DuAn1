using _1_DAL_QLNT.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.IServices
{
    public interface IQlDangNhap
    {
        DangNhap getlistTKTk(string email);
        bool checkDangNhap(string email, string matKhau);
        string checkMail(string email);
        void DBInsertTK(DangNhap dangNhap);
        List<DangNhap> getlistDangNhap();
        string guiMail(string email, int matkhau);
        string mahoa(string pass);
        string TkTk(DangNhap dangNhap, string email);
        string updateMkTK(DangNhap dangNhap, string email, string oldpass, string newpass);
        int RamdomNumber(int min, int max);
    }
}
