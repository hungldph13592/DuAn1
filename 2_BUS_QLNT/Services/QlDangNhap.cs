using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
using _2_BUS_QLNT.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLNT.Services
{
    public class QlDangNhap : IQlDangNhap
    {
        IServicesDangNhap qlDangNhap;
        List<DangNhap> _lstdangNhaps;

        public QlDangNhap()
        {
            qlDangNhap = new ServicesDangNhap();
        }
        public DangNhap getlistTKTk(string email)
        {
            return qlDangNhap.getListDangNhap().Where(c => c.TaiKhoan == email).FirstOrDefault();
        }

        public bool checkDangNhap(string email, string matKhau)
        {
            foreach (var x in qlDangNhap.getListDangNhap())
            {
                if (x.TaiKhoan == email && x.MatKhau == matKhau)
                {
                    return true;
                }
            }
            return false;
        }

        public string checkMail(string email)
        {
            if (qlDangNhap.checkmail(email))
            {
                return "Email hợp lệ";

            }
            return "Email không tồn tại";
        }

        public void DBInsertTK(DangNhap dangNhap)
        {
            qlDangNhap.DBInsertTK(dangNhap);
        }
        public List<DangNhap> getlistDangNhap()
        {
            return _lstdangNhaps = qlDangNhap.getListDangNhap();
        }
        public string guiMail(string email, int matkhau)
        {
            var mail = new MailMessage();
            var SmtpServer = new SmtpClient(); // giúp gửi mail
            SmtpServer.Credentials = new NetworkCredential("demoduanmau@gmail.com", "Hung12345");
            SmtpServer.EnableSsl = true;
            mail.From = new MailAddress("demoduanmau@gmail.com", "Hung12345");
            mail.BodyEncoding = mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            mail.To.Add(email);
            mail.Subject = "Quên mật khẩu";
            mail.Body = "Mật khẩu mới là: " + matkhau;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.Port = 587;
            SmtpServer.Send(mail);
            return "OK";

        }
       
        public string mahoa(string pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] enctypt;
            UTF8Encoding encode = new UTF8Encoding();
            enctypt = md5.ComputeHash(encode.GetBytes(pass));
            StringBuilder encriptdata = new StringBuilder();
            for (int i = 0; i < enctypt.Length; i++)
            {
                encriptdata.Append(enctypt[i].ToString());
            }
            return encriptdata.ToString();
        }
        public int RamdomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string TkTk(DangNhap dangNhap, string email)
        {
            if (qlDangNhap.DBUpdateTK(dangNhap, email))
            {
                return "Thành công";
            }
            return "Thất bại";
        }

        public string updateMkTK(DangNhap dangNhap, string email, string oldpass, string newpass)
        {
            dangNhap = qlDangNhap.getListDangNhap().Where(c => c.TaiKhoan == email).FirstOrDefault();
            if (dangNhap.MatKhau == mahoa(oldpass))
            {
                dangNhap.MatKhau = mahoa(newpass);
                qlDangNhap.doiMk(dangNhap);
                return "Thành công";
            }
            return "Tài khoản mật khẩu không đúng";

        }
    }
}
