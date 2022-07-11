using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_QLNT.Entitis;
using _2_BUS_QLNT.IServices;
using _2_BUS_QLNT.Services;

namespace _3_GUI_QLNT.Veiw
{
    public partial class Frm_QLHoaDon : Form
    {
        private IServicesQLHoaDon _iServicesQlHoaDon;
        private int _Count;
        private int _Count2;
        private int _Thang;
        private int _Nam; 
        public Frm_QLHoaDon()
        {
            InitializeComponent();
            _iServicesQlHoaDon = new ServicesQLHoaDon();
            Load();
            _Count = 0;
            try
            {
                cmbx_diennuoc.SelectedIndex = 0;
            }
            catch (Exception e) { }
            LoadHoaDon();
            btn_huytt.Hide();
            linkLabel1.Text=linkLabel1.Text+" "+_Thang.ToString() + " Năm " + _Nam.ToString();
        }

        public void Load()
        {
            cmbx_diennuoc.Items.Clear();
            foreach (var x in _iServicesQlHoaDon.LoadDataDienNuoc())
            {
                cmbx_diennuoc.Items.Add(x.MaDienNuoc);
            }
        }

        public void LoadHoaDon()
        {
            DateTime dt=DateTime.Now;
            _Thang = dt.Month;
           _Nam = dt.Year;
           _Count = 0;
            dgrv_HoaDon.ColumnCount = 9;
            dgrv_HoaDon.Columns[0].Name = "MaHD";
            dgrv_HoaDon.Columns[1].Name = "Ngày tháng";
            dgrv_HoaDon.Columns[2].Name = "Số điện";
            dgrv_HoaDon.Columns[3].Name = "Số nước";
            dgrv_HoaDon.Columns[4].Name = "Tiền nhà";
            dgrv_HoaDon.Columns[5].Name = "Tiền dịch vụ";
            dgrv_HoaDon.Columns[6].Name = "Tiền giảm giá";
            dgrv_HoaDon.Columns[7].Name = "Đã trả";
            dgrv_HoaDon.Columns[8].Name = "Trạng thái";
            dgrv_HoaDon.Rows.Clear();
            var a = _iServicesQlHoaDon.LoadDataHoaDon();
            for (int i = 0; i < a.Count; i++)
            {
                if (_iServicesQlHoaDon.LoadDataHopDong().Where(c=>c.MaHopDong==a[i].MaHopDong).Select(c=>c.TangThai).FirstOrDefault()==1 && a[i].NgayThang.Month==_Thang && a[i].NgayThang.Year==_Nam)
                {
                    dgrv_HoaDon.Rows.Add(a[i].MaHopDong, a[i].NgayThang, a[i].SoDien, a[i].SoNuoc, a[i].TienNha,
                        a[i].TienDichVu, a[i].TienGiamGia,
                        a[i].TienThanhToan,
                        a[i].TrangThai == 0 ? "Chưa thanh toán" : a[i].TrangThai == 1 ? "Đã thanh toán" : "Còn thiếu");
                    _Count++;
                }
            }
            LoadHDCT();
        }

        public void LoadHDCT()
        {
            var lst = _iServicesQlHoaDon.LoadDataHDCT().Where(c => c.MaHoaDon == lbl_mahoadon.Text);
            _Count2 = lst.Count();
            dgrv_HDCT.ColumnCount = 6;
            dgrv_HDCT.Columns[0].Name = "Mã HD";
            dgrv_HDCT.Columns[1].Name = "Mã HDCT";
            dgrv_HDCT.Columns[2].Name = "Tên DV";
            dgrv_HDCT.Columns[3].Name = "Đơn giá";
            dgrv_HDCT.Columns[4].Name = "Ngày ĐK";
            dgrv_HDCT.Columns[5].Name = "Ngày hết hạn";
            dgrv_HDCT.Rows.Clear();
            foreach (var x in lst)
            {
                dgrv_HDCT.Rows.Add(x.MaHoaDon, x.MaHoaDonCT,
                    _iServicesQlHoaDon.LoadDataDV().Where(c => c.MaDV == x.MaDV).Select(c => c.TenDV).FirstOrDefault(),
                    _iServicesQlHoaDon.LoadDataDV().Where(c => c.MaDV == x.MaDV).Select(c => c.DonGia).FirstOrDefault(),
                    x.NgayDangKy, x.ThoiHan);
            }
        }
        private void btn_loc_Click(object sender, EventArgs e)
        {
            dgrv_HoaDon.Rows.Clear();
            _Thang = time_loc.Value.Month;
           _Nam = time_loc.Value.Year;
           _Count = 0;
            dgrv_HoaDon.ColumnCount = 9;
            dgrv_HoaDon.Columns[0].Name = "MaHD";
            dgrv_HoaDon.Columns[1].Name = "Ngày tháng";
            dgrv_HoaDon.Columns[2].Name = "Số điện";
            dgrv_HoaDon.Columns[3].Name = "Số nước";
            dgrv_HoaDon.Columns[4].Name = "Tiền nhà";
            dgrv_HoaDon.Columns[5].Name = "Tiền dịch vụ";
            dgrv_HoaDon.Columns[6].Name = "Giảm giá";
            dgrv_HoaDon.Columns[7].Name = "Đã trả";
            dgrv_HoaDon.Columns[8].Name = "Trạng thái";
            var a = _iServicesQlHoaDon.LoadDataHoaDon();
            for (int i = 0; i < a.Count; i++)
            {
                if (_iServicesQlHoaDon.LoadDataHopDong().Where(c => c.MaHopDong == a[i].MaHopDong).Select(c => c.TangThai).FirstOrDefault() == 1 && a[i].NgayThang.Month == _Thang && a[i].NgayThang.Year == _Nam)
                {
                    dgrv_HoaDon.Rows.Add(a[i].MaHopDong, a[i].NgayThang, a[i].SoDien, a[i].SoNuoc, a[i].TienNha,
                        a[i].TienDichVu, a[i].TienGiamGia,
                        a[i].TienThanhToan,
                        a[i].TrangThai == 0 ? "Chưa thanh toán" : a[i].TrangThai == 1 ? "Đã thanh toán" : "Còn thiếu");
                    _Count++;
                }
            }
        }
        public void dgrv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index<0||index>=_Count)
            {
                return;
            }
            lbl_mahopdong.Text = dgrv_HoaDon.Rows[index].Cells[0].Value.ToString();
            lbl_mahoadon.Text = _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHopDong == lbl_mahopdong.Text).Where(c => c.NgayThang.Month == _Thang && c.NgayThang.Year == _Nam)
                .Select(c => c.MaHoaDon).FirstOrDefault().ToString();
            var TienNha= _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text)
                .Select(c => c.TienNha).FirstOrDefault();
            var TienDichVu = _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text)
                .Select(c => c.TienDichVu).FirstOrDefault();
            var Tiendien = (_iServicesQlHoaDon.LoadDataDienNuoc()
                .Where(c => c.MaDienNuoc == _iServicesQlHoaDon.LoadDataHoaDon()
                    .Where(c => c.MaHoaDon == lbl_mahoadon.Text).Select(c => c.MaDienNuoc).FirstOrDefault())
                .Select(c => c.GiaDien).FirstOrDefault())*_iServicesQlHoaDon.LoadDataHoaDon().Where(c=>c.MaHoaDon==lbl_mahoadon.Text).Select(c=>c.SoDien).FirstOrDefault();
            var Tiennuoc = (_iServicesQlHoaDon.LoadDataDienNuoc()
                .Where(c => c.MaDienNuoc == _iServicesQlHoaDon.LoadDataHoaDon()
                    .Where(c => c.MaHoaDon == lbl_mahoadon.Text).Select(c => c.MaDienNuoc).FirstOrDefault())
                .Select(c => c.GiaNuoc).FirstOrDefault()) * _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text).Select(c => c.SoNuoc).FirstOrDefault();
            var TienDienNuoc = Tiendien+Tiennuoc;
            var TienDaTra = _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text)
                .Select(c => c.TienThanhToan).FirstOrDefault(); 
            var TienGiam = _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text)
                .Select(c => c.TienGiamGia).FirstOrDefault();
           lbl_trangthai.Text = dgrv_HoaDon.Rows[index].Cells[8].Value.ToString();
           txt_tientt.Text = dgrv_HoaDon.Rows[index].Cells[7].Value.ToString();
           txt_tiengiam.Text = dgrv_HoaDon.Rows[index].Cells[6].Value.ToString();
           num_dien.Text = dgrv_HoaDon.Rows[index].Cells[2].Value.ToString();
           num_nuoc.Text = dgrv_HoaDon.Rows[index].Cells[3].Value.ToString();
           lbl_tongtien.Text = (TienNha + TienDichVu + TienDienNuoc - TienGiam - TienDaTra).ToString()+" VND";
            LoadHDCT();
           if (lbl_trangthai.Text=="Đã thanh toán"||lbl_trangthai.Text=="Còn thiếu")
           {
               btn_huytt.Show();
           }
           else
           {
               btn_huytt.Hide();
           }
           lbl_tennt.Text=_iServicesQlHoaDon.LoadDataNgThue().Where(c=>c.MaNguoiThue==_iServicesQlHoaDon.LoadDataHopDong().Where(c=>c.MaHopDong==lbl_mahopdong.Text).Select(c=>c.MaNguoiThue).FirstOrDefault()).Select(c=>c.HoVaTen).FirstOrDefault();
           lbl_sodtnt.Text = _iServicesQlHoaDon.LoadDataNgThue().Where(c => c.MaNguoiThue == _iServicesQlHoaDon.LoadDataHopDong().Where(c => c.MaHopDong == lbl_mahopdong.Text).Select(c => c.MaNguoiThue).FirstOrDefault()).Select(c => c.SoDT).FirstOrDefault();
        }
        private void Frm_QLHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            _iServicesQlHoaDon = new ServicesQLHoaDon();
            LoadHoaDon();
        }


        private void dgrv_HDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index2 = e.RowIndex;
            if(Index2<0||Index2>=_Count2)return;
            lbl_mahoadon2.Text = dgrv_HDCT.Rows[Index2].Cells[0].Value.ToString();
            lbl_mahdct.Text = dgrv_HDCT.Rows[Index2].Cells[1].Value.ToString();
            lbl_tendichvu.Text = dgrv_HDCT.Rows[Index2].Cells[2].Value.ToString();
            lbl_gia.Text = dgrv_HDCT.Rows[Index2].Cells[3].Value.ToString();
            time_ngdk.Text = dgrv_HDCT.Rows[Index2].Cells[4].Value.ToString();
            time_nghethan.Text = dgrv_HDCT.Rows[Index2].Cells[5].Value.ToString();
        }

        private void cmbx_diennuoc_SelectedValueChanged(object sender, EventArgs e)
        {
                txt_diennuoc.Text = "Điện: "+_iServicesQlHoaDon.LoadDataDienNuoc().Where(c => c.MaDienNuoc == cmbx_diennuoc.Text)
                    .Select(c => c.GiaDien).FirstOrDefault().ToString()+", Nước" + _iServicesQlHoaDon.LoadDataDienNuoc().Where(c => c.MaDienNuoc == cmbx_diennuoc.Text)
                    .Select(c => c.GiaNuoc).FirstOrDefault().ToString();
        }

        private void btn_huytt_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text).FirstOrDefault();
                hd.TienThanhToan = 0;
                hd.TrangThai = 0;
                MessageBox.Show(_iServicesQlHoaDon.UpdateHoaDon(hd), "Thông báo");
                LoadHoaDon();
            }
            catch (Exception exception) { }
        }

        public void btn_tiengiam_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text).FirstOrDefault();
                hd.TienGiamGia = float.Parse(txt_tiengiam.Text);
                MessageBox.Show(_iServicesQlHoaDon.UpdateHoaDon(hd), "Thông báo");
                LoadHoaDon();
            }
            catch (Exception exception){}
        }

        public void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = _iServicesQlHoaDon.LoadDataHoaDon().Where(c => c.MaHoaDon == lbl_mahoadon.Text).FirstOrDefault();
                hd.MaDienNuoc = cmbx_diennuoc.Text;
                hd.SoDien = int.Parse(num_dien.Text);
                hd.SoNuoc = int.Parse(num_nuoc.Text);
                var TienDien=_iServicesQlHoaDon.LoadDataDienNuoc().Where(c=>c.MaDienNuoc==cmbx_diennuoc.Text).Select(c=>c.GiaDien).FirstOrDefault()*int.Parse(num_dien.Text);
                var TienNuoc = _iServicesQlHoaDon.LoadDataDienNuoc().Where(c => c.MaDienNuoc == cmbx_diennuoc.Text).Select(c => c.GiaNuoc).FirstOrDefault() * int.Parse(num_nuoc.Text);
                if (txt_tientt.Text=="0")
                {
                    hd.TienThanhToan = hd.TienNha + hd.TienDichVu +TienDien+TienNuoc- hd.TienGiamGia;
                }
                else
                {
                    hd.TienThanhToan = float.Parse(txt_tientt.Text);
                }

                if (hd.TienThanhToan== hd.TienNha + hd.TienDichVu + TienDien + TienNuoc - hd.TienGiamGia)
                {
                    hd.TrangThai = 1;
                }

                if (hd.TienThanhToan==0)
                {
                    hd.TrangThai = 0;
                }

                if (hd.TienThanhToan< hd.TienNha + hd.TienDichVu + TienDien + TienNuoc - hd.TienGiamGia)
                {
                    hd.TrangThai = 2;
                }
                LoadHoaDon();
                MessageBox.Show(_iServicesQlHoaDon.UpdateHoaDon(hd), "Thông báo");
            }
            catch (Exception exception){}
        }
    }
}
