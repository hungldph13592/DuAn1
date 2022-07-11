using _1_DAL_QLNT.Entitis;
using _1_DAL_QLNT.IServices;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_GUI_QLNT.Properties;

namespace _3_GUI_QLNT.Veiw
{
    public partial class frm_dangthue : Form
    {
        private IServicesDangThue _iServicesDangThue;
        private List<DichVu> _DV1;
        private List<DichVu> _DV2;
        private DichVu _dv;
        DateTime dt = DateTime.Now;
        public frm_dangthue()
        {
            InitializeComponent();
            _iServicesDangThue = new ServicesDangThue();
            _DV1 = new List<DichVu>();
            _DV2 = new List<DichVu>();
            _dv = new DichVu();
            foreach (var x in _iServicesDangThue.LoadDataDichVu().Where(c=>c.TrangThai==1))
            {
                _DV1.Add(x);
            }
            LoadData();
            loadDv1();
            loadDv3();
        }

        public void LoadData()
        {
            label17.Text = Properties.Settings.Default.MaPhongTro;
            var a = Properties.Settings.Default.MaNguoiThue;
            _iServicesDangThue.LoadDataNguoiThues().Where(c => c.MaNguoiThue == a).Select(c => c.HoVaTen)
                .FirstOrDefault();
            label8.Text = a;
            label9.Text = _iServicesDangThue.LoadDataNguoiThues().Where(c => c.MaNguoiThue == a).Select(c => c.HoVaTen)
                .FirstOrDefault();
            label10.Text = _iServicesDangThue.LoadDataNguoiThues().Where(c => c.MaNguoiThue == a).Select(c => c.SoDT)
                .FirstOrDefault();
            label11.Text = _iServicesDangThue.LoadDataNguoiThues().Where(c => c.MaNguoiThue == a).Select(c => c.CMND)
                .FirstOrDefault();
            label12.Text = _iServicesDangThue.LoadDataNguoiThues().Where(c => c.MaNguoiThue == a).Select(c => c.QueQuan)
                .FirstOrDefault();
            label13.Text = _iServicesDangThue.LoadDataNguoiThues().Where(c => c.MaNguoiThue == a).Select(c => c.NamSinh)
                .FirstOrDefault().ToString();
            label14.Text = _iServicesDangThue.LoadDataNguoiThues().Where(c => c.MaNguoiThue == a).Select(c => c.Email)
                .FirstOrDefault();
        }

        public void loadDv1()
        {
            var lst = _iServicesDangThue.LoaDataHDCT().Where(c =>
                c.MaHoaDon == _iServicesDangThue.LoadDataHoaDon().Where(c => c.MaHopDong == Settings.Default.MaHopDong && c.NgayThang.Month == dt.Month && c.NgayThang.Year == dt.Year)
                    .Select(c => c.MaHoaDon).FirstOrDefault());
            foreach (var x in lst)
            {
                foreach (var z in _iServicesDangThue.LoadDataDichVu().Where(c=>c.TrangThai==1))
                {
                    if (x.NgayDangKy.Day == dt.Day && x.NgayDangKy.Month == dt.Month && x.NgayDangKy.Year == dt.Year)
                    {
                        if (z.MaDV==x.MaDV)
                        {
                            _DV1.Remove(z);
                        }
                    }
                }
            }
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Mã dịch vụ";
            dataGridView1.Columns[1].Name = "Tên dịch vụ";
            dataGridView1.Columns[2].Name = "Đơn giá";
            dataGridView1.Rows.Clear();
            foreach (var x in _DV1)
            {
                dataGridView1.Rows.Add(x.MaDV, x.TenDV, x.DonGia);
            }
        }
        public void loadDv2()
        {
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Mã dịch vụ";
            dataGridView2.Columns[1].Name = "Tên dịch vụ";
            dataGridView2.Columns[2].Name = "Đơn giá";
            dataGridView2.Rows.Clear();
            foreach (var x in _DV2)
            {
                dataGridView2.Rows.Add(x.MaDV, x.TenDV, x.DonGia);
            }
        }
        public void loadDv3()
        {
            var lst = _iServicesDangThue.LoaDataHDCT().Where(c =>
                c.MaHoaDon == _iServicesDangThue.LoadDataHoaDon().Where(c => c.MaHopDong == Settings.Default.MaHopDong && c.NgayThang.Month == dt.Month && c.NgayThang.Year == dt.Year)
                    .Select(c => c.MaHoaDon).FirstOrDefault());
            foreach (var x in lst)
            {
                foreach (var z in _iServicesDangThue.LoadDataDichVu().Where(c=>c.TrangThai==1))
                {
                    if (x.NgayDangKy.Day == dt.Day && x.NgayDangKy.Month == dt.Month && x.NgayDangKy.Year == dt.Year)
                    {
                        if (z.MaDV == x.MaDV)
                        {
                            _DV2.Add(z);
                        }
                    }
                }
            }
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Mã dịch vụ";
            dataGridView2.Columns[1].Name = "Tên dịch vụ";
            dataGridView2.Columns[2].Name = "Đơn giá";
            dataGridView2.Rows.Clear();
            foreach (var x in _DV2)
            {
                dataGridView2.Rows.Add(x.MaDV, x.TenDV, x.DonGia);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                HoaDonChiTiet p = new HoaDonChiTiet();
                p.MaHoaDonCT = "CT-" + p.NgayDangKy.Day.ToString() + p.NgayDangKy.Month.ToString() + p.NgayDangKy.Year.ToString() + label17.Text.Replace("-", "") + label18.Text + "C" + _iServicesDangThue.LoaDataHDCT().Count.ToString()  ;
                p.MaDV = label18.Text;
                p.NgayDangKy = DateTime.Today;
                p.ThoiHan = p.NgayDangKy.AddDays(1);
                p.MaHoaDon =_iServicesDangThue.LoadDataHoaDon().Where(c => c.MaHopDong == Settings.Default.MaHopDong&&c.NgayThang.Month==dt.Month&&c.NgayThang.Year==dt.Year).Select(c=>c.MaHoaDon).FirstOrDefault();
            if (_iServicesDangThue.LoaDataHDCT().Where(c => c.MaHoaDon == _iServicesDangThue.LoadDataHoaDon().Where(c => c.MaHopDong == Settings.Default.MaHopDong && c.NgayThang.Month == dt.Month && c.NgayThang.Year == dt.Year).Select(c => c.MaHoaDon).FirstOrDefault()).Count() == _iServicesDangThue.LoadDataDichVu().Where(c => c.TrangThai == 1).Count())
            {
                MessageBox.Show("Không có dịch vụ để đăng ký", "thông báo");
                loadDv1();
                loadDv2();
                return;
            }
            if (p.MaDV=="label18")
                {
                    MessageBox.Show("Bạn cần chọn 1 dịch vụ để đăng ký", "Thông báo");
                    return;
                }
                else
                if (_iServicesDangThue.LoaDataHDCT().Where(c=>c.MaHoaDon== _iServicesDangThue.LoadDataHoaDon().Where(c => c.MaHopDong == Settings.Default.MaHopDong && c.NgayThang.Month == dt.Month && c.NgayThang.Year == dt.Year).Select(c => c.MaHoaDon).FirstOrDefault()).Select(c=>c.MaDV).FirstOrDefault()==label18.Text)
                {
                    MessageBox.Show("Dịch vụ này đã đăng ký ngày hôm nay", "thông báo");
                    loadDv1();
                    loadDv2();
                return;
                }
                else
                {
                    _iServicesDangThue.AddHDCT(p);
                    _DV1.Remove(_dv);
                    _DV2.Add(_dv);
                    loadDv1();
                    loadDv2();
                    var hd = _iServicesDangThue.LoadDataHoaDon().Where(c =>
                        c.MaHopDong == Settings.Default.MaHopDong && c.NgayThang.Month == dt.Month &&
                        c.NgayThang.Year == dt.Year).FirstOrDefault();
                    hd.TienDichVu = hd.TienDichVu + _iServicesDangThue.LoadDataDichVu()
                        .Where(c => c.MaDV == label18.Text).Select(c => c.DonGia).FirstOrDefault();
                    MessageBox.Show(_iServicesDangThue.UpdateHoaDon(hd),"Thông báo");
                }
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex==_DV1.Count||e.RowIndex<0)
                {
                    return;
                }
                _dv = _iServicesDangThue.LoadDataDichVu().First(c => c.MaDV == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                label18.Text = _dv.MaDV;
            }
            catch (Exception exception)
            {
            }
        }
        private void frm_dangthue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
