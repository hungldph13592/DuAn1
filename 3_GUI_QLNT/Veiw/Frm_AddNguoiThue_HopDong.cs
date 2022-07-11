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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_QLNT.Veiw
{
    public partial class Frm_AddNguoiThue_HopDong : Form
    {
        private IQuanLyNguoiThue BUS_NT;
        public static Frm_AddNguoiThue_HopDong instance;
        public NguoiThue NT;
        public Frm_AddNguoiThue_HopDong()
        {
            InitializeComponent();
            BUS_NT = new QuanLyNguoiThue();
            NT = new NguoiThue();
            instance = this;
            cbx_nam.Checked = true;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm người thuê ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (BUS_NT.LoaDataDV().Exists(c => c.SoDT == txt_sdt.Text || c.CMND == txt_cccd.Text || c.Email == txt_gmai.Text))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại");
                    return;
                }
                if (!int.TryParse(txt_namsing.Text, out int a) || txt_sdt.Text.Any(Char.IsLetter) || txt_cccd.Text.Any(Char.IsLetter))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ");
                    return;
                }
                NT = new NguoiThue();
                NT.MaNguoiThue = "NT" + (BUS_NT.LoaDataDV().Count + 1);
                NT.HoVaTen = txt_ten.Text;
                NT.SoDT = txt_sdt.Text;
                NT.CMND = txt_cccd.Text;
                NT.Email = txt_gmai.Text;
                NT.GioiTinh = cbx_nam.Checked == true ? true : false;
                NT.NamSinh = Convert.ToInt32(txt_namsing.Text);
                NT.TrangThai = 1;
                NT.QueQuan = txt_quequan.Text;
                MessageBox.Show(BUS_NT.AddDV(NT), "Thông báo");
                Frm_HopDong.instance._lstNT.Add(NT);
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }           
        }

        private void Frm_AddNguoiThue_HopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void cbx_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_nu.Checked)
            {
                cbx_nam.Checked = false;
            }
            else
            {
                cbx_nam.Checked = true;
            }
        }

        private void cbx_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_nam.Checked)
            {
                cbx_nu.Checked = false;
            }
            else
            {
                cbx_nu.Checked = true;
            }
        }

        private void txt_namsing_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
