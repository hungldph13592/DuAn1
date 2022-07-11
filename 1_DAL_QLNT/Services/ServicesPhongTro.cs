using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLNT.DBContext;
using _1_DAL_QLNT.Entitis;

namespace _1_DAL_QLNT.IServices
{
    public class ServicesPhongTro:IServicesPhongTro
    {
        private List<PhongTro> _lstPhongTros;
        private DBContetxQLNT _dbContetxQlnt;

        public ServicesPhongTro()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            _lstPhongTros = new List<PhongTro>();
            DBPhongTro();
        }
        public void DBPhongTro()
        {
            _lstPhongTros = _dbContetxQlnt.PhongTros.ToList();
        }

        public List<PhongTro> LoadDataPhongTro()
        {
            return _lstPhongTros;
        }

        public string AddPhpng(PhongTro phongTro)
        {
            _dbContetxQlnt.PhongTros.Add(phongTro);
            _dbContetxQlnt.SaveChanges();
            DBPhongTro();
            return "Đã thêm thành công!";
        }

        public string UpdatePhong(PhongTro phongTro)
        {
            _dbContetxQlnt.PhongTros.Update(phongTro);
            _dbContetxQlnt.SaveChanges();
            DBPhongTro();
            return "Đã cập nhật!";
        }
    }
}
