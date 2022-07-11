using System;
using System.Collections;
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
    public partial class Frm_Main : Form
    {
        private IServicesMain _iServicesMain;
        private int SoPhong;
        private int CCao;
        private int a;
        private string MaNgThue;
        private string MaHopDong;
        private string MaPhongTro;
        public Frm_Main()
        {
            InitializeComponent();
            _iServicesMain = new ServicesMain();
            LoadTang();
            try
            {
                cmbx_tang.SelectedIndex = 0;
                TinhToan();
                LoadCCao();
                LoadPhong();
            }
            catch (Exception e)
            {
                
            }
        }
        public void LoadTang()
        { 
            cmbx_tang.Items.Clear();
            foreach (var x in _iServicesMain.LoadDataTang())
            {
                cmbx_tang.Items.Add(x.TangNha);
            }
        }
        private void quảnLýPhòngTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tang frm = new Frm_Tang();
            frm.Show();
        }

        private void quảnLýLoạiDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QLLoaiDV frmQlLoaiDv = new Frm_QLLoaiDV();
            frmQlLoaiDv.Show();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QLDichVu frmQlDichVu = new Frm_QLDichVu();
            frmQlDichVu.Show();
        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LoaiPhong frmLoaiPhong = new Frm_LoaiPhong();
            frmLoaiPhong.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PhongTro frmPhongTro = new Frm_PhongTro();
            frmPhongTro.Show();
        }
        /************************************************************************************************************************************************************************/
        //PT tạo button hiển thị phòng
        public void TinhToan()
        {
            SoPhong = _iServicesMain.LoadDataPhong().Where(c =>
                c.MaTang == (_iServicesMain.LoadDataTang().Where(c => c.TangNha == cmbx_tang.Text).Select(c => c.MaTang)
                    .FirstOrDefault())).Count();
            btn_Trong.Text = _iServicesMain.LoadDataPhong().Where(c => c.TrangThai == 0&&c.MaTang==_iServicesMain.LoadDataTang().Where(c=>c.TangNha==cmbx_tang.Text).Select(c=>c.MaTang).FirstOrDefault()).Count().ToString();
            btn_dathue.Text = _iServicesMain.LoadDataPhong().Where(c => c.TrangThai == 1 && c.MaTang == _iServicesMain.LoadDataTang().Where(c => c.TangNha == cmbx_tang.Text).Select(c => c.MaTang).FirstOrDefault()).Count().ToString();
            btn_sua.Text = _iServicesMain.LoadDataPhong().Where(c => c.TrangThai == 2 && c.MaTang == _iServicesMain.LoadDataTang().Where(c => c.TangNha == cmbx_tang.Text).Select(c => c.MaTang).FirstOrDefault()).Count().ToString();
        }
        public void LoadCCao()
        {
            a=SoPhong;
            if (SoPhong <= 6)
            {
                CCao = 1;
            }
            else
            {
                CCao = 0;
                while (a>=9)
                {
                    a = a - 9;
                    CCao++;
                }
            }
        }

        public void LoadPhong()
        {
            pal_Phong.Controls.Clear();
            var lst = _iServicesMain.LoadDataPhong().Where(c =>
                c.MaTang == _iServicesMain.LoadDataTang().Where(c => c.TangNha == cmbx_tang.Text).Select(c => c.MaTang)
                    .FirstOrDefault());
            var b = 0;
            string[] Arr = new string[lst.Count()];
            foreach (var x in lst)
            {
                Arr[b] = x.MaPhongTro;
                b++;
            }
            lst.ToString();
            Button TrDo = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            if (SoPhong<=9)
            {
                foreach (var x in lst)
                {
                    Button btn = new Button() { Width = 200, Height = 200, TextAlign = ContentAlignment.TopCenter, Text = x.MaPhongTro, BackColor = x.TrangThai == 1 ? Color.Aqua :x.TrangThai==0 ? Color.White:Color.Gold };
                    btn.Location = new Point(TrDo.Location.X + TrDo.Width, TrDo.Location.Y);
                    Label lbl = new Label() {Width = 180,Font = new Font("Segoe UI", 10), Text = "N.Thuê: "+_iServicesMain.LoadDataNgThue().Where(c=>c.MaNguoiThue== _iServicesMain.LoadDataHopDong().Where(c => c.MaPhongTro == x.MaPhongTro).Select(c => c.MaNguoiThue).FirstOrDefault()).Select(c=>c.HoVaTen).FirstOrDefault(),BackColor = btn.BackColor};
                    lbl.Location = new Point(TrDo.Location.X + TrDo.Width+10, TrDo.Location.Y+70); 
                    Label lbl2 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "D.Tích: "+_iServicesMain.LoadDataLoaiPhong().Where(c=>c.MaLoaiPhong==_iServicesMain.LoadDataPhong().Where(c=>c.MaPhongTro==x.MaPhongTro).Select(c=>c.MaLoaiPhong).FirstOrDefault()).Select(c=>c.DienTich).FirstOrDefault()+" m2", BackColor = btn.BackColor };
                    lbl2.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 100); 
                    Label lbl3 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "Giá: "+ _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == x.MaPhongTro).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.GiaThue).FirstOrDefault() + " Đ", BackColor = btn.BackColor };
                    lbl3.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 130);
                    Label lbl4 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "Loại phòng: "+ _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == x.MaPhongTro).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.TenLoaiPhong).FirstOrDefault(), BackColor = btn.BackColor };
                    lbl4.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 160);
                    pal_Phong.Controls.Add(lbl);
                    pal_Phong.Controls.Add(lbl2);
                    pal_Phong.Controls.Add(lbl3);
                    pal_Phong.Controls.Add(lbl4);
                    pal_Phong.Controls.Add(btn);
                    TrDo = btn;
                    if (x.TrangThai == 0)
                    {
                        btn.Click += PhongTrong;
                    }

                    if (x.TrangThai==1)
                    {
                        btn.Click += PhongDaThue;
                    }

                    if (x.TrangThai==2)
                    {
                        btn.Click += PhongDangSua;
                    }
                }
            }
            else
            {
                int c = 0;
                for (int i = 0; i < CCao; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        string d = Arr[c].ToString();
                        Button btn = new Button()
                        {
                            Width = 200, Height = 200,TextAlign = ContentAlignment.TopCenter,Text = Arr[c],BackColor = _iServicesMain.LoadDataPhong().Where(c=>c.MaPhongTro==d).Select(c=>c.TrangThai).FirstOrDefault()==1?Color.Aqua : _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.TrangThai).FirstOrDefault()==0? Color.White:Color.Gold};
                        btn.Location = new Point(TrDo.Location.X + TrDo.Width, TrDo.Location.Y);
                        Label lbl = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "N.Thuê: " + _iServicesMain.LoadDataNgThue().Where(c => c.MaNguoiThue == _iServicesMain.LoadDataHopDong().Where(c => c.MaPhongTro == d).Select(c => c.MaNguoiThue).FirstOrDefault()).Select(c => c.HoVaTen).FirstOrDefault(), BackColor = btn.BackColor };
                        lbl.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 70);
                        Label lbl2 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "D.Tích: " + _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.DienTich).FirstOrDefault() + " m2", BackColor = btn.BackColor };
                        lbl2.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 100);
                        Label lbl3 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "Giá: " + _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro ==d).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.GiaThue).FirstOrDefault() + " Đ", BackColor = btn.BackColor };
                        lbl3.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 130); 
                        Label lbl4 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "Loại phòng: " + _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.TenLoaiPhong).FirstOrDefault(), BackColor = btn.BackColor };
                        lbl4.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 160);
                        pal_Phong.Controls.Add(lbl);
                        pal_Phong.Controls.Add(lbl2);
                        pal_Phong.Controls.Add(lbl3);
                        pal_Phong.Controls.Add(lbl4);
                        pal_Phong.Controls.Add(btn);
                        TrDo = btn;
                        c++;
                        var u = _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.TrangThai)
                            .FirstOrDefault();
                        if (u==0)
                        {
                            btn.Click += PhongTrong;
                        }
                        if (u == 1)
                        {
                            btn.Click += PhongDaThue;
                        }
                        if (u == 2)
                        {
                            btn.Click += PhongDangSua;
                        }
                    }
                    TrDo = new Button() {Width = 0, Height = 0, Location = new Point(0, TrDo.Location.Y + 200)};
                }

                try
                {
                    for (int j = 0; j < a; j++)
                    {
                        string d = Arr[c].ToString();
                        Button btn = new Button() { Width = 200, Height = 200, TextAlign = ContentAlignment.TopCenter, Text = Arr[c], BackColor = _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.TrangThai).FirstOrDefault() == 1 ? Color.Aqua : _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.TrangThai).FirstOrDefault() == 0 ? Color.White : Color.Gold };
                        btn.Location = new Point(TrDo.Location.X + TrDo.Width, TrDo.Location.Y);
                        Label lbl = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "N.Thuê: " + _iServicesMain.LoadDataNgThue().Where(c => c.MaNguoiThue == _iServicesMain.LoadDataHopDong().Where(c => c.MaPhongTro == d).Select(c => c.MaNguoiThue).FirstOrDefault()).Select(c => c.HoVaTen).FirstOrDefault(), BackColor = btn.BackColor };
                        lbl.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 70);
                        Label lbl2 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "D.Tích: " + _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.DienTich).FirstOrDefault() + " m2", BackColor = btn.BackColor };
                        lbl2.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 100);
                        Label lbl3 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "Giá: " + _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.GiaThue).FirstOrDefault() + " Đ", BackColor = btn.BackColor };
                        lbl3.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 130);
                        Label lbl4 = new Label() { Width = 180, Font = new Font("Segoe UI", 10), Text = "Loại phòng: " + _iServicesMain.LoadDataLoaiPhong().Where(c => c.MaLoaiPhong == _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.MaLoaiPhong).FirstOrDefault()).Select(c => c.TenLoaiPhong).FirstOrDefault(), BackColor = btn.BackColor };
                        lbl4.Location = new Point(TrDo.Location.X + TrDo.Width + 10, TrDo.Location.Y + 160);
                        pal_Phong.Controls.Add(lbl);
                        pal_Phong.Controls.Add(lbl2);
                        pal_Phong.Controls.Add(lbl3);
                        pal_Phong.Controls.Add(lbl4);
                        pal_Phong.Controls.Add(btn);
                        TrDo = btn;
                        c++; 
                        var t = _iServicesMain.LoadDataPhong().Where(c => c.MaPhongTro == d).Select(c => c.TrangThai)
                            .FirstOrDefault();
                        if (t == 0)
                        {
                            btn.Click += PhongTrong;
                        }
                        if (t == 1)
                        {
                            btn.Click += PhongDaThue;
                        }
                        if (t == 2)
                        {
                            btn.Click += PhongDangSua;
                        }
                    }
                }
                catch (Exception e)
                {
                }
            }


            void PhongDaThue(object sender, EventArgs e)
            {
                AddValua((sender as Button).Text);
                frm_dangthue _frmDangthue = new frm_dangthue();
                _frmDangthue.Show();
            }
            void PhongTrong(object sender, EventArgs e)
            {
                AddValua((sender as Button).Text);
                Frm_menu _frmMenu = new Frm_menu();
                _frmMenu.Show();
            }
            void PhongDangSua(object sender, EventArgs e)
            {
                AddValua((sender as Button).Text);
                Frm_DoiTrangThai _frmDoiTrangThai = new Frm_DoiTrangThai();
                _frmDoiTrangThai.Show();
            }

            void AddValua(string MaPT)//PT lưu lại MaHopDong, MaPhong, MaNguoiDung
            {
                Properties.Settings.Default.MaPhongTro = MaPT;
                Properties.Settings.Default.MaNguoiThue = _iServicesMain.LoadDataHopDong()
                    .Where(c => c.MaPhongTro == MaPT).Select(c => c.MaNguoiThue).FirstOrDefault();
                    Properties.Settings.Default.MaHopDong = _iServicesMain.LoadDataHopDong()
                        .Where(c => c.MaPhongTro == MaPT).Select(c => c.MaHopDong).FirstOrDefault();
                Properties.Settings.Default.Save();

            }
        }
        private void cmbx_tang_SelectedValueChanged(object sender, EventArgs e)
        {
            _iServicesMain = new ServicesMain();
            TinhToan();
            LoadCCao();
            LoadPhong();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void đăngSuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login _frmLogin = new Frm_Login();
            _frmLogin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _iServicesMain = new ServicesMain();
            LoadTang(); 
            TinhToan();
            LoadCCao();
            LoadPhong();
        }

        private void quảnKýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QLHoaDon _frmQlHoaDon = new Frm_QLHoaDon();
            _frmQlHoaDon.Show();
        }

        private void quảnLýGiáĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DienNuoc _frmDienNuoc = new frm_DienNuoc();
            _frmDienNuoc.Show();
        }

        private void quảnLýNgườiThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NguoiThue _frmNguoiThue = new Frm_NguoiThue();
            _frmNguoiThue.Show();
        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HopDong _frmHopDong = new Frm_HopDong();
            _frmHopDong.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau _frmDoiMatKhau = new Frm_DoiMatKhau();
            _frmDoiMatKhau.Show();
        }
    }
    }
