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
    public partial class Frm_NguoiThue : Form
    {
        private IQuanLyNguoiThue QLnguoiThue;
        private NguoiThue _NT;
        public string MaNguoiThue;
        private int count;
        public Frm_NguoiThue()
        {
           
            InitializeComponent();
            QLnguoiThue = new QuanLyNguoiThue();
            
            loadData();
        }

        public void loadData()
        {
            data.ColumnCount = 9;
            data.Columns[0].Name = "Mã Người Thuê";
            data.Columns[1].Name = "Họ và Tên ";
            data.Columns[2].Name = "Số Điện Thoại ";
            data.Columns[3].Name = "Số CMND/ CCCD";
            data.Columns[4].Name = "Gmail";
            data.Columns[5].Name = "Giới Tính ";
            data.Columns[6].Name = "Năm Sinh ";
            data.Columns[7].Name = "Trạng Thái";
            data.Columns[8].Name = "Quê Quán";
            data.Rows.Clear();
            foreach (var x in QLnguoiThue.LoaDataDV())
            {
                data.Rows.Add(x.MaNguoiThue, x.HoVaTen,x.SoDT,x.CMND,x.Email,x.GioiTinh == true ? "nam": "nữ",x.NamSinh, x.TrangThai == 1 ? "Hoạt Động ": "Không Hoạt Động",x.QueQuan);
            }
        }

        public void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (QLnguoiThue.LoaDataDV().Exists(c => c.SoDT == txt_sdt.Text || c.CMND == txt_cccd.Text || c.Email == txt_gmai.Text))
                {
                    MessageBox.Show("Đã có");
                    return;
                }
                if (!int.TryParse(txt_namsing.Text, out int a) || txt_sdt.Text.Any(Char.IsLetter) || txt_cccd.Text.Any(Char.IsLetter))
                {
                    MessageBox.Show("Không hợp lệ");
                    return;
                }
                NguoiThue NT = new NguoiThue();
                NT.MaNguoiThue = "NT" + (QLnguoiThue.LoaDataDV().Count + 1);
                NT.HoVaTen = txt_ten.Text;
                NT.SoDT = txt_sdt.Text;
                NT.CMND = txt_cccd.Text;
                NT.Email = txt_gmai.Text;
                NT.GioiTinh = cbx_nam.Checked == true ? true : false;
                NT.NamSinh = Convert.ToInt32(txt_namsing.Text);
                NT.TrangThai = rdb_hoadong.Checked == true ? 1 : 0;
                NT.QueQuan = txt_quequan.Text;
                MessageBox.Show(QLnguoiThue.AddDV(NT), "Thông báo");
                loadData();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Lỗi nhập", "Thông báo");
            }
            
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= QLnguoiThue.LoaDataDV().Count) return;
            label1.Text = data.Rows[index].Cells[0].Value.ToString();
            txt_ten.Text = data.Rows[index].Cells[1].Value.ToString();
            txt_sdt.Text = data.Rows[index].Cells[2].Value.ToString();
            txt_gmai.Text = data.Rows[index].Cells[3].Value.ToString();
            txt_cccd.Text = data.Rows[index].Cells[4].Value.ToString();
            cbx_nam.Checked = data.Rows[index].Cells[5].Value.ToString() == "Nam" ? true : false;
            cbx_nu.Checked = data.Rows[index].Cells[5].Value.ToString() == " Nữ" ? false : true;
            txt_namsing.Text = data.Rows[index].Cells[6].Value.ToString();
            rdb_hoadong.Checked = data.Rows[index].Cells[7].Value.ToString() == "Hoạt động" ? true : false;
            rdb_khonghoatdong.Checked = data.Rows[index].Cells[7].Value.ToString() == " Không Hoạt động" ? false : true;
            txt_quequan.Text = data.Rows[index].Cells[8].Value.ToString();
            MaNguoiThue = data.Rows[index].Cells[0].Value.ToString();

        }

        public void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (QLnguoiThue.LoaDataDV().Exists(c => c.SoDT == txt_sdt.Text || c.CMND == txt_cccd.Text || c.Email == txt_gmai.Text))
                {
                    MessageBox.Show("Đã Có");
                    return;
                }
                if (!int.TryParse(txt_namsing.Text, out int a) || txt_sdt.Text.Any(Char.IsLetter) || txt_cccd.Text.Any(Char.IsLetter))
                {
                    MessageBox.Show("Không hợp lệ");
                    return;
                }
                NguoiThue NT = new NguoiThue();
                NT = QLnguoiThue.LoaDataDV().Where(c => c.MaNguoiThue == MaNguoiThue).FirstOrDefault();
                NT.HoVaTen = txt_ten.Text;
                NT.SoDT = txt_sdt.Text;
                NT.CMND = txt_cccd.Text;
                NT.Email = txt_gmai.Text;
                NT.GioiTinh = cbx_nam.Checked == true ? true : false;
                NT.NamSinh = Convert.ToInt32(txt_namsing.Text);
                NT.TrangThai = rdb_hoadong.Checked == true ? 1 : 0;
                NT.QueQuan = txt_quequan.Text;
                MessageBox.Show(QLnguoiThue.EditDV(NT), "Thông báo");
                loadData();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Sửa lỗi");
            }


        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            var tk = QLnguoiThue.LoaDataDV().Where(c => c.MaNguoiThue.Contains(txt_timkiem.Text));
            data.Rows.Clear();
            foreach (var x in tk)
            {
                data.Rows.Add(x.MaNguoiThue, x.HoVaTen,x.SoDT,x.NamSinh,x.GioiTinh ? "nam" : "nữ",x.CMND,x.Email,x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động",x.QueQuan);
            }
        }

        private void Frm_NguoiThue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void cbx_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_nu.Checked)
            {
                cbx_nam.Checked = false;
            }
            else
            {
                cbx_nu.Checked = true;
            }
        }

        private void cbx_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_nam.Checked)
            {
                cbx_nu.Checked = false;
            }
            else
            {
                cbx_nam.Checked = true;
            }
        }
    }
}
