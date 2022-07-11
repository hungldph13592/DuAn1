using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_QLNT.IServices;

namespace _3_GUI_QLNT.Veiw
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void Frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_doitt_Click(object sender, EventArgs e)
        {
            Frm_DoiTrangThai _frmDoiTrangThai = new Frm_DoiTrangThai();
            _frmDoiTrangThai.Show();
            this.Hide();
        }

        private void btn_chucnang_Click(object sender, EventArgs e)
        {
            frm_TaoHopDong _frmTaoHopDong = new frm_TaoHopDong();
            _frmTaoHopDong.Show();
            this.Hide();
        }
    }
}
