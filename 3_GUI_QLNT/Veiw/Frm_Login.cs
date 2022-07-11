using _2_BUS_QLNT.IServices;
using _2_BUS_QLNT.Services;
using _3_GUI_QLNT.Veiw;
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

namespace _3_GUI_QLNT
{
    public partial class Frm_Login : Form
    {
        IQlDangNhap services_DangNhap;
       
        public Frm_Login()
        {
            InitializeComponent();
            services_DangNhap = new QlDangNhap();
            
        }
        private void tbx_TaiKhoan__KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        public void btn_Login_Click(object sender, EventArgs e)
        {
                Frm_Main frm_Main = new Frm_Main();
                if (tbx_TaiKhoan.Text.Length == 0 || tbx_MatKhau.Text.Length == 0)
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được để trống");
                    return;
                }
                else if (services_DangNhap.checkDangNhap(tbx_TaiKhoan.Text, services_DangNhap.mahoa(tbx_MatKhau.Text)))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    frm_Main.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng", "Thông báo");
                }

                   }

        private void lbl_QuenMk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_QuenMk frm_QuenMk = new Frm_QuenMk();
            this.Hide();
            frm_QuenMk.Show();
        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void tbx_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
