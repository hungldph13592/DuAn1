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
    public partial class Frm_DoiMatKhau : Form
    {
        IQlDangNhap services_DangNhap;
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
            services_DangNhap = new QlDangNhap();
        }
       
        private void btn_DangKi_Click(object sender, EventArgs e)
        {
          
                DangNhap dangNhap = new DangNhap();
           
             
            if (tbx_MatKhau2.Text.Length <= 0)
            {
                MessageBox.Show("Tài khoản mật khẩu không được để trống", "Thông báo");
            }
           else if (services_DangNhap.checkDangNhap(tbx_TaiKhoan.Text, services_DangNhap.mahoa(tbx_MatKhau.Text)))
            {

                if (services_DangNhap.updateMkTK(dangNhap, tbx_TaiKhoan.Text, tbx_MatKhau.Text, tbx_MatKhau2.Text) == "Thành công")
                {
                    Frm_Login frm_Login = new Frm_Login();
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                    MessageBox.Show("Mời đăng nhập lại", "Thông báo");
                    this.Hide();
                    frm_Login.Show();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không đúng", "Thông báo");
            }
            }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }

        private void tbx_MatKhau2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_MatKhau2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void tbx_TaiKhoan_Leave(object sender, EventArgs e)
        {
            string mail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(tbx_TaiKhoan.Text,mail))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tbx_TaiKhoan, "Tài khoản không hợp lệ");
                return;
            }
        }

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void tbx_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

       
    }

