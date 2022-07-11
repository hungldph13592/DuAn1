using _1_DAL_QLNT.Entitis;
using _2_BUS_QLNT.IServices;
using _2_BUS_QLNT.Models;
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
    public partial class frm_TaoHopDong : Form
    {
        private IQuanLyNguoiThue _NguoiThue;
        /*rivate NguoiThue NT;*/
        private IQuanLyHopDong _hopdong;
        private IQuanLyLoaiPhong _LoaiPhong;
        private IQuanLyPhongTro _PhongTro;
        private IServicesQLHoaDon _HoaDon;
        
        private List<string> _lst;
        public List<PhongTro_DichVu> _lstPTDV;
        
        public frm_TaoHopDong()
        {
            InitializeComponent();
            _NguoiThue = new QuanLyNguoiThue();
            _NguoiThue = new QuanLyNguoiThue();
            _hopdong = new QuanLyHopDong();
            _LoaiPhong = new QuanLyLoaiPhong();
            _PhongTro = new QuanLyPhongTro();
            _HoaDon = new ServicesQLHoaDon();
            _lst = new List<string>();
            _lstPTDV = new List<PhongTro_DichVu>();
            loadData();
        }
        public void loadData()
        {
            lbl_maPT.Text = Properties.Settings.Default.MaPhongTro;
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Mã Người Thuê";
            dataGridView1.Columns[1].Name = "Họ và Tên ";
            dataGridView1.Columns[2].Name = "Số Điện Thoại ";
            dataGridView1.Columns[3].Name = "Số CMND/ CCCD";
            dataGridView1.Columns[4].Name = "Gmail";
            dataGridView1.Columns[5].Name = "Giới Tính ";
            dataGridView1.Columns[6].Name = "Năm Sinh ";
            dataGridView1.Columns[7].Name = "Trạng Thái";
            dataGridView1.Columns[8].Name = "Quê Quán";
            dataGridView1.Rows.Clear();
            foreach (var x in _NguoiThue.LoaDataDV())
            {
                dataGridView1.Rows.Add(x.MaNguoiThue, x.HoVaTen, x.SoDT, x.CMND, x.Email, x.GioiTinh == true ? "nam" : "nữ", x.NamSinh, x.TrangThai==1?"Hoạt động":"Không hoạt động",x.QueQuan);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= _NguoiThue.LoaDataDV().Count)
                {
                    return;
                }
                lbl_maNT.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbl_HoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbl_Sodt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbl_CCCD.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lbl_gmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbl_que.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                lbl_NS.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                lbl_GT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn tạo hợp đồng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                    if (int.Parse(txt_thoihan.Text) % int.Parse(txt_tratruoc.Text) != 0 || int.Parse(txt_thoihan.Text) <= 0 || int.Parse(txt_tratruoc.Text) <= 0)
                    {
                        MessageBox.Show("Hạn trả và thời hạn không hợp lệ");
                        return;
                    }
                    HopDong hd = new HopDong();
                    hd.MaHopDong = "HD-" + (_hopdong.GetLstHopDong().Count + 1).ToString("D3");
                    hd.MaNguoiThue = lbl_maNT.Text;
                    hd.MaPhongTro = lbl_maPT.Text;
                    hd.SoThangTraTruoc = int.Parse(txt_tratruoc.Text);
                    hd.NgayDangKy = DateTime.Today;
                    hd.NgayHetHan = DateTime.Today.AddMonths(int.Parse(txt_thoihan.Text));
                hd.TienCoc = _LoaiPhong.GetLstLP().First(c => c.MaLoaiPhong == _PhongTro.GetLstPhongTro().First(c => c.MaPhongTro == lbl_maPT.Text).MaLoaiPhong).GiaThue;
                hd.GhiChu = txt_ghichu.Text;
                    hd.TangThai = 1;
                    _hopdong.AddHD(hd);
                    DateTime a = DateTime.Today;
                for (int i = 1; i <= int.Parse(txt_thoihan.Text); i++)
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHoaDon = "HDN-" + a.Month.ToString("D2") + a.Year.ToString() + hd.MaPhongTro.Replace("-", "") + "C" + _HoaDon.LoadDataHoaDon().Count.ToString();
                    hoaDon.MaHopDong = hd.MaHopDong;
                    hoaDon.MaDienNuoc = _hopdong.GetLstDienNuoc()[0].MaDienNuoc;
                    hoaDon.NgayThang = a;
                    hoaDon.SoDien = 0;
                    hoaDon.SoNuoc = 0;
                    hoaDon.TienDichVu = 0;
                    hoaDon.TienGiamGia = 0;
                    hoaDon.TienThanhToan = 0;
                    if (i == 1 || (i - 1) % int.Parse(txt_tratruoc.Text) == 0)
                    {
                        hoaDon.TienNha = _LoaiPhong.GetLstLP().First(c => c.MaLoaiPhong == _PhongTro.GetLstPhongTro().First(c => c.MaPhongTro == hd.MaPhongTro).MaLoaiPhong).GiaThue * int.Parse(txt_tratruoc.Text);
                    }
                    else
                    {
                        hoaDon.TienNha = 0;
                    }
                    hoaDon.TrangThai = 0;
                    _HoaDon.AddHoaDon(hoaDon);
                    a = a.AddMonths(1);
                    _PhongTro.GetLstPhongTro().First(c => c.MaPhongTro == lbl_maPT.Text).TrangThai = 1;
                    _PhongTro.UpdatePT(_PhongTro.GetLstPhongTro().First(c => c.MaPhongTro == lbl_maPT.Text));
                }
                MessageBox.Show("Đã thêm hợp đồng");
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }

}
