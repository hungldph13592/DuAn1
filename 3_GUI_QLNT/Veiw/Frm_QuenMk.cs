using _1_DAL_QLNT.Entitis;
using _2_BUS_QLNT.IServices;
using _2_BUS_QLNT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_QLNT.Veiw
{
    public partial class Frm_QuenMk : Form
    {
        IQlDangNhap services_DangNhap;
        public Frm_QuenMk()
        {
            InitializeComponent();
            services_DangNhap = new QlDangNhap();
        }

       

        public void button1_Click(object sender, EventArgs e)
        {

            int mk = services_DangNhap.RamdomNumber(100000, 99999999);
            MessageBox.Show(services_DangNhap.checkMail(tbx_TaiKhoan.Text),"Thông báo");
           
            if (tbx_TaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo");
            }
            if (services_DangNhap.checkMail(tbx_TaiKhoan.Text)=="Email hợp lệ")
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap = services_DangNhap.getlistTKTk(tbx_TaiKhoan.Text);
                dangNhap.MatKhau = services_DangNhap.mahoa(mk.ToString());
                services_DangNhap.TkTk(dangNhap, tbx_TaiKhoan.Text);
                services_DangNhap.guiMail(tbx_TaiKhoan.Text, mk);
                MessageBox.Show("Đã gửi mật khẩu đến mail. Vui lòng kiểm tra!");
                this.Hide();
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.Show();
            }
            else
            {
                return;
            }
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }

        private void tbx_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_TaiKhoan_Leave(object sender, EventArgs e)
        {
            string mail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(tbx_TaiKhoan.Text, mail))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tbx_TaiKhoan, "Tài khoản không hợp lệ");
                return;
            }
        }
    }
}
