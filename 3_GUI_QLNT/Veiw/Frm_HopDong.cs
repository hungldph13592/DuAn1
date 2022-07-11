using _1_DAL_QLNT.Entitis;
using _2_BUS_QLNT.IServices;
using _2_BUS_QLNT.Models;
using _2_BUS_QLNT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_QLNT.Veiw
{
    public partial class Frm_HopDong : Form
    {
        private IQuanLyPhongTro BUS_PT;
        private IQuanLyLoaiPhong BUS_LP;
        private IQuanLyTang BUS_TG;
        private IQuanLyNguoiThue BUS_NT;
        private IQuanLyHopDong BUS_HD;
        private IServicesQLHoaDon BUS_HoaDon;
        public List<ListViewItem> _lstViewItem;
        public float a = 0;
        public List<string> _lst;
        public string _ctxpt;
        public List<PhongTro_DichVu> _lstPTDV;
        public static Frm_HopDong instance;
        public List<NguoiThue> _lstNT;
        public Frm_HopDong()
        {
            InitializeComponent();
            BUS_PT = new QuanLyPhongTro();
            BUS_LP = new QuanLyLoaiPhong();
            BUS_TG = new QuanLyTang();
            BUS_NT = new QuanLyNguoiThue();
            BUS_HD = new QuanLyHopDong();
            BUS_HoaDon = new ServicesQLHoaDon();
            instance = this;
            _lstViewItem = new List<ListViewItem>();
            _lst = new List<string>();
            _lstPTDV = new List<PhongTro_DichVu>();
            _lstNT = new List<NguoiThue>();
            _lstNT = BUS_NT.LoaDataDV();
            //MessageBox.Show(_lst.Count.ToString());
            LoadDataNT();
            LoadCbx();
            try
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
                LoadDataPT();
            }
            catch (Exception e)
            {
            }
        }
        void LoadCbx()
        {
            try
            {
                imageList1 = new ImageList();
                imageList1.ImageSize = new Size(120, 120);
                foreach (var item in BUS_TG.LstTang())
                {
                    comboBox1.Items.Add(item.TangNha);
                }
                foreach (var item in BUS_LP.GetLstLP())
                {
                    imageList1.Images.Add(item.HinhAnh,Image.FromFile(item.HinhAnh));
                }
                //MessageBox.Show(imageList1.Images.Count.ToString());
            }
            catch (Exception e)
            {
            }
        }
        private void LoadDataNT()
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Mã người thuê";
            dataGridView1.Columns[1].Name = "Họ và tên";
            dataGridView1.Columns[2].Name = "SĐT";
            dataGridView1.Columns[3].Name = "CMND";
            dataGridView1.Columns[4].Name = "Quên quán";
            dataGridView1.Columns[5].Name = "Năm sinh";
            dataGridView1.Columns[6].Name = "Giới tính";
            dataGridView1.Columns[7].Name = "Email";
            dataGridView1.Rows.Clear();
            foreach (var item in BUS_NT.LoaDataDV().Where(c=>c.TrangThai==1).ToList())
            {
                dataGridView1.Rows.Add(item.MaNguoiThue, item.HoVaTen, item.SoDT, item.CMND, item.QueQuan, item.NamSinh, item.GioiTinh == true ? "Nam" : "Nữ", item.Email);
            }
        }
        void LoadDataPT()
        {
            listView1.MultiSelect = true;
            listView1.View = View.LargeIcon;
            foreach (var item in BUS_PT.GetLstPhongTro().Where(c => c.MaTang == BUS_TG.LstTang().First(c => c.TangNha == comboBox1.Text).MaTang).ToList())
            {
                if (item.TrangThai == 1)
                {
                    ListViewItem item1 = new ListViewItem(item.MaPhongTro, imageList1.Images.IndexOfKey(BUS_LP.GetLstLP().First(c => c.MaLoaiPhong == item.MaLoaiPhong).HinhAnh));
                    item1.ForeColor = Color.Red;
                    item1.Font = new Font("Segoe UI", 12);
                    _lstViewItem.Add(item1);
                }
                else if (item.TrangThai == 2)
                {
                    ListViewItem item1 = new ListViewItem(item.MaPhongTro, imageList1.Images.IndexOfKey(BUS_LP.GetLstLP().First(c => c.MaLoaiPhong == item.MaLoaiPhong).HinhAnh));
                    item1.ForeColor = Color.Black;
                    item1.Font = new Font("Segoe UI", 12);
                    _lstViewItem.Add(item1);
                }
                else
                {
                    ListViewItem item1 = new ListViewItem(item.MaPhongTro , imageList1.Images.IndexOfKey(BUS_LP.GetLstLP().First(c => c.MaLoaiPhong == item.MaLoaiPhong).HinhAnh));
                    item1.ForeColor = Color.Green;
                    item1.Font = new Font("Segoe UI", 12);
                    _lstViewItem.Add(item1);
                }   
            }
            listView1.Items.AddRange(_lstViewItem.ToArray());
            ImageList imageListLarge = imageList1;
            List<string> lst = new List<string>();
            lst = _lst;
            listView1.LargeImageList = imageListLarge;
            foreach (string item in lst)
            {
                if (_lstViewItem.Exists(c => c.Text == item))
                {
                    _lstViewItem.First(c => c.Text == item).Checked = true;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_HopDong_Load(object sender, EventArgs e)
        {
            Panel P = new Panel();
            P.BackColor = listView1.BackColor;
            P.Location = listView1.Location;
            P.Size = listView1.Size;
            P.Padding = new System.Windows.Forms.Padding(10);
            P.BorderStyle = listView1.BorderStyle;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Parent = P;
            listView1.Dock = DockStyle.Fill;
            this.Controls.Add(P);
        }

        public void btnLoc_Click(object sender, EventArgs e)
        {
            if (!BUS_TG.LstTang().Exists(c=>c.TangNha==comboBox1.Text))
            {
                return;
            }
            listView1.Items.Clear();
            _lstViewItem.Clear();
            LoadDataPT();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
        }

        public void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BUS_PT.GetLstPhongTro().First(c=>c.MaPhongTro== listView1.Items[e.Index].Text).TrangThai != 0)
            {
                e.NewValue = e.CurrentValue;
                return;
            }

            if (e.CurrentValue == CheckState.Checked)
            {
                _lst.Remove(listView1.Items[e.Index].Text);
                MessageBox.Show(_lst.Count.ToString());
                a -= BUS_LP.GetLstLP().First(c=>c.MaLoaiPhong== BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == listView1.Items[e.Index].Text).MaLoaiPhong).GiaThue;
                foreach (var item in _lstPTDV.ToList())
                {
                    if (item.MaPhongTro == listView1.Items[e.Index].Text)
                    {
                        _lstPTDV.Remove(item);
                    }
                }
            }
            if (e.CurrentValue == CheckState.Unchecked)
            {
                if (_lst.Exists(c => c.ToString() == listView1.Items[e.Index].Text))
                {
                    return;
                }
                _lst.Add(listView1.Items[e.Index].Text);     
                MessageBox.Show(_lst.Count.ToString());
                a += BUS_LP.GetLstLP().First(c => c.MaLoaiPhong == BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == listView1.Items[e.Index].Text).MaLoaiPhong).GiaThue;
            }
            txtTienCoc.Text = a.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= BUS_NT.LoaDataDV().Count)
            {
                return;
            }
            txtMaNguoiThue.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); 
            txtCMND.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQueQuan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNamSinh.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn tạo hợp đồng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                #region Validate
                if (string.IsNullOrEmpty(txtMaNguoiThue.Text))
                {
                    MessageBox.Show("Chưa chọn người thuê");
                    return;

                }
                if (string.IsNullOrEmpty(txtTienCoc.Text))
                {
                    MessageBox.Show("Chưa chọn phòng thuê");
                    return;
                }
                if (!int.TryParse(txtThoiHan.Text, out int a2) || !int.TryParse(txtTraTruoc.Text, out int a1))
                {
                    MessageBox.Show("Hạn trả và thời hạn không hợp lệ");
                    return;
                }
                #endregion
                foreach (var item in _lst)
                {
                    if (int.Parse(txtThoiHan.Text) % int.Parse(txtTraTruoc.Text) != 0 || int.Parse(txtThoiHan.Text) <= 0 || int.Parse(txtTraTruoc.Text) <= 0)
                    {
                        MessageBox.Show("Hạn trả và thời hạn không hợp lệ");
                        return;
                    }
                    HopDong hd = new HopDong();
                    hd.MaHopDong = "HD-" + (BUS_HD.GetLstHopDong().Count + 1).ToString("D3");
                    hd.TienCoc = BUS_LP.GetLstLP().First(c => c.MaLoaiPhong == BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == item).MaLoaiPhong).GiaThue;
                    hd.NgayDangKy = DateTime.Today;
                    hd.NgayHetHan = DateTime.Today.AddMonths(int.Parse(txtThoiHan.Text));
                    hd.MaNguoiThue = txtMaNguoiThue.Text;
                    hd.MaPhongTro = item;
                    hd.SoThangTraTruoc = int.Parse(txtTraTruoc.Text);
                    hd.GhiChu = txtGhiXhu.Text;
                    hd.TangThai = 1;
                    BUS_HD.AddHD(hd);
                    DateTime a = DateTime.Today;
                    for (int i = 1; i <= int.Parse(txtThoiHan.Text); i++)
                    {
                        HoaDon hoaDon = new HoaDon();
                        hoaDon.MaHoaDon = "HDN-" + a.Month.ToString("D2") + a.Year.ToString() + hd.MaPhongTro.Replace("-", "") + "C" + BUS_HoaDon.LoadDataHoaDon().Count.ToString();
                        hoaDon.MaHopDong = hd.MaHopDong;
                        hoaDon.MaDienNuoc = BUS_HD.GetLstDienNuoc()[0].MaDienNuoc;
                        hoaDon.NgayThang = a;
                        hoaDon.SoDien = 0;
                        hoaDon.SoNuoc = 0;
                        hoaDon.TienDichVu = 0;
                        hoaDon.TienGiamGia = 0;
                        hoaDon.TienThanhToan = 0;
                        if (i == 1 || (i - 1) % int.Parse(txtTraTruoc.Text) == 0)
                        {
                            hoaDon.TienNha = BUS_LP.GetLstLP().First(c => c.MaLoaiPhong == BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == hd.MaPhongTro).MaLoaiPhong).GiaThue * int.Parse(txtTraTruoc.Text);
                        }
                        else
                        {
                            hoaDon.TienNha = 0;
                        }
                        hoaDon.TrangThai = 0;
                        BUS_HoaDon.AddHoaDon(hoaDon);
                        a = a.AddMonths(1);
                        BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == item).TrangThai = 1;
                        BUS_PT.UpdatePT(BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == item));
                    }
                }
                foreach (var item1 in _lstPTDV)
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon = BUS_HoaDon.LoadDataHoaDon().First(c => c.MaHopDong == BUS_HD.GetLstHopDong().FirstOrDefault(c => c.MaPhongTro == item1.MaPhongTro && c.NgayDangKy == DateTime.Today).MaHopDong && c.NgayThang == DateTime.Today);
                    HoaDonChiTiet b = new HoaDonChiTiet();
                    b.MaDV = item1.MaDichVu;
                    b.MaHoaDon = hoaDon.MaHoaDon;
                    b.NgayDangKy = DateTime.Today;
                    b.ThoiHan = b.NgayDangKy.AddDays(1);
                    b.MaHoaDonCT = "CT-" + b.NgayDangKy.Day.ToString() + b.NgayDangKy.Month.ToString() + b.NgayDangKy.Year.ToString() + item1.MaPhongTro.Replace("-", "") + item1.MaDichVu + "C" + BUS_HoaDon.LoadDataHDCT().Count.ToString();
                    BUS_HD.AddHoaDonCT(b);
                    hoaDon.TienDichVu += item1.DonGia;
                    BUS_HoaDon.UpdateHoaDon(hoaDon);
                }
                MessageBox.Show("Đã thêm " + _lst.Count + " hợp đồng");
                _lst = new List<string>();
                _lstPTDV = new List<PhongTro_DichVu>();
                _lstViewItem = new List<ListViewItem>();
                a = 0;
                txtTienCoc.Text = a.ToString();
                listView1.Items.Clear();
                LoadDataPT();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }  
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location) == true && focusedItem.Checked==true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                    _ctxpt = focusedItem.Text;
                }
                else
                {
                    _ctxpt = null;
                    return;
                }
            }
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_ctxpt)||BUS_PT.GetLstPhongTro().First(c=>c.MaPhongTro==_ctxpt).TrangThai!=0)
            {
                return;
            }
            else
            {
                Frm_AddDichVu_HopDong frm = new Frm_AddDichVu_HopDong();
                frm.GetName(_ctxpt,_lstPTDV);
                frm.Show();
            }  
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.Item.ForeColor == Color.Red)
            {
                e.Graphics.DrawRectangle(Pens.Red, e.Item.Bounds.X + 12, e.Item.Bounds.Y, e.Item.Bounds.Width - 12, e.Item.Bounds.Height + 3);
            }
            else if (e.Item.ForeColor == Color.Black)
            {
                e.Graphics.DrawRectangle(Pens.Black, e.Item.Bounds.X + 12, e.Item.Bounds.Y, e.Item.Bounds.Width - 12, e.Item.Bounds.Height + 3);
            }
            else
            {
                e.Graphics.DrawRectangle(Pens.Green, e.Item.Bounds.X + 12, e.Item.Bounds.Y, e.Item.Bounds.Width - 12, e.Item.Bounds.Height + 3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AddNguoiThue_HopDong frm = new Frm_AddNguoiThue_HopDong();
            frm.Show();
        }

        public void btnList_Click(object sender, EventArgs e)
        {
            Frm_ListHopDong_HopDong frm = new Frm_ListHopDong_HopDong();
            frm.Show();
        }

        private void Frm_HopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
        public void GetList(List<DichVu> lst, string txt)
        {
            foreach (var item in lst)
            {
                PhongTro_DichVu a = new PhongTro_DichVu();
                a.DonGia = item.DonGia;
                a.MaDichVu = item.MaDV;
                a.TenDichVu = item.TenDV;
                a.MaPhongTro = txt;
                _lstPTDV.Add(a);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Mã người thuê";
            dataGridView1.Columns[1].Name = "Họ và tên";
            dataGridView1.Columns[2].Name = "SĐT";
            dataGridView1.Columns[3].Name = "CMND";
            dataGridView1.Columns[4].Name = "Quên quán";
            dataGridView1.Columns[5].Name = "Năm sinh";
            dataGridView1.Columns[6].Name = "Giới tính";
            dataGridView1.Columns[7].Name = "Email";
            dataGridView1.Rows.Clear();
            foreach (var item in _lstNT.Where(c => c.TrangThai == 1).ToList())
            {
                dataGridView1.Rows.Add(item.MaNguoiThue, item.HoVaTen, item.SoDT, item.CMND, item.QueQuan, item.NamSinh, item.GioiTinh == true ? "Nam" : "Nữ", item.Email);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Mã người thuê";
            dataGridView1.Columns[1].Name = "Họ và tên";
            dataGridView1.Columns[2].Name = "SĐT";
            dataGridView1.Columns[3].Name = "CMND";
            dataGridView1.Columns[4].Name = "Quên quán";
            dataGridView1.Columns[5].Name = "Năm sinh";
            dataGridView1.Columns[6].Name = "Giới tính";
            dataGridView1.Columns[7].Name = "Email";
            dataGridView1.Rows.Clear();
            foreach (var item in BUS_NT.LoaDataDV().Where(c => c.TrangThai == 1 && c.HoVaTen.Contains(txtTimKiem.Text)).ToList())
            {
                dataGridView1.Rows.Add(item.MaNguoiThue, item.HoVaTen, item.SoDT, item.CMND, item.QueQuan, item.NamSinh, item.GioiTinh == true ? "Nam" : "Nữ", item.Email);
            }
        }

        private void txtTraTruoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNguoiThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
