using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
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
    public partial class Frm_ListHopDong_HopDong : Form
    {
        private IQuanLyHopDong BUS_HD;
        private IQuanLyPhongTro BUS_PT;
        private IServicesQLHoaDon BUS_HoaDon;
        public HopDong _hd;
        public Frm_ListHopDong_HopDong()
        {
            InitializeComponent();
            BUS_HD = new QuanLyHopDong();
            BUS_PT = new QuanLyPhongTro();
            BUS_HoaDon = new ServicesQLHoaDon();
            _hd = new HopDong();
            loadData();
        }
        void loadData()
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Mã hợp đồng";
            dataGridView1.Columns[1].Name = "Mã người thuê";
            dataGridView1.Columns[2].Name = "Mã phòng trọ";
            dataGridView1.Columns[3].Name = "Trả trước";
            dataGridView1.Columns[4].Name = "Ngày đăng ký";
            dataGridView1.Columns[5].Name = "Ngày hết hạn";
            dataGridView1.Columns[6].Name = "Tiền cọc";
            dataGridView1.Columns[7].Name = "Ghi chú";
            dataGridView1.Columns[8].Name = "Trạng thái";
            dataGridView1.Rows.Clear();
            foreach (var item in BUS_HD.GetLstHopDong())
            {
                if (item.NgayHetHan <= DateTime.Today)
                {
                    item.TangThai = 0;
                    BUS_HD.UpdateHD(item);
                    BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == item.MaPhongTro).TrangThai = 0;
                    BUS_PT.UpdatePT(BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == item.MaPhongTro));                   
                }
                dataGridView1.Rows.Add(item.MaHopDong, item.MaNguoiThue, item.MaPhongTro, item.SoThangTraTruoc, item.NgayDangKy, item.NgayHetHan, item.TienCoc, item.GhiChu, item.TangThai == 1 ? "Hoạt động" : "Vô hiệu hóa");
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn hủy hợp đồng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _hd.TangThai = 0;
                BUS_HD.UpdateHD(_hd);
                BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == _hd.MaPhongTro).TrangThai = 0;
                BUS_PT.UpdatePT(BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == _hd.MaPhongTro));
                loadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= BUS_HD.GetLstHopDong().Count)
            {
                return;
            }
            _hd = BUS_HD.GetLstHopDong().First(c => c.MaHopDong == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Mã hợp đồng";
            dataGridView1.Columns[1].Name = "Mã người thuê";
            dataGridView1.Columns[2].Name = "Mã phòng trọ";
            dataGridView1.Columns[3].Name = "Trả trước";
            dataGridView1.Columns[4].Name = "Ngày đăng ký";
            dataGridView1.Columns[5].Name = "Ngày hết hạn";
            dataGridView1.Columns[6].Name = "Tiền cọc";
            dataGridView1.Columns[7].Name = "Ghi chú";
            dataGridView1.Columns[8].Name = "Trạng thái";
            dataGridView1.Rows.Clear();
            foreach (var item in BUS_HD.GetLstHopDong().Where(c=>c.MaNguoiThue.Contains(textBox1.Text)).ToList())
            {
                if (item.NgayHetHan <= DateTime.Today)
                {
                    item.TangThai = 0;
                    BUS_HD.UpdateHD(item);
                    BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == item.MaPhongTro).TrangThai = 0;
                    BUS_PT.UpdatePT(BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == item.MaPhongTro));
                }
                dataGridView1.Rows.Add(item.MaHopDong, item.MaNguoiThue, item.MaPhongTro, item.SoThangTraTruoc, item.NgayDangKy, item.NgayHetHan, item.TienCoc, item.GhiChu, item.TangThai == 1 ? "Hoạt động" : "Vô hiệu hóa");
            }
        }
    }
}
