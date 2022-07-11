using _1_DAL_QLNT.DBContext;
using _3_GUI_QLNT;
using _3_GUI_QLNT.Veiw;
using NUnit.Framework;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UnitTest
{
    public class Tests
    {
        Frm_Tang frmTang;
        DBContetxQLNT _dbContetxQlnt;
        Frm_LoaiPhong frm_LoaiPhong;
        Frm_PhongTro frm_PhongTro;
        Frm_NguoiThue frm_NguoiThue;
        Frm_HopDong frm_HopDong;
        Frm_ListHopDong_HopDong frm_ListHopDong_HopDong;
        frm_DienNuoc frm_DienNuoc;
        Frm_QLHoaDon frm_QLHoaDon;
        Frm_QLDichVu frm_QLDichVu;
        Frm_QLLoaiDV frm_QLLoaiDV;
        Frm_Login frm_Login;
        Frm_QuenMk frm_QuenMk;
        [SetUp]
        public void Setup()
        {
            _dbContetxQlnt = new DBContetxQLNT();
            frmTang = new Frm_Tang();
            frm_LoaiPhong = new Frm_LoaiPhong();
            frm_PhongTro = new Frm_PhongTro();
            frm_NguoiThue = new Frm_NguoiThue();
            frm_HopDong = new Frm_HopDong();
            frm_ListHopDong_HopDong = new Frm_ListHopDong_HopDong();
            frm_DienNuoc = new frm_DienNuoc();
            frm_QLHoaDon = new Frm_QLHoaDon();
            frm_QLDichVu = new Frm_QLDichVu();
            frm_QLLoaiDV = new Frm_QLLoaiDV();
            frm_Login = new Frm_Login();
            frm_QuenMk = new Frm_QuenMk();
            frm_QLHoaDon.Load();
        }

        [Ignore("Pass")]
        [Test]
        public void AddTang()
        {
            frmTang.button1_Click_1(null,null);
        }
        #region Form Loại Phòng
        [Ignore("Pass")]
        [Test]
        [TestCase("","123")]
        [TestCase("Vip","234")]//Đã có tên trùng trong database
        public void AddLP_QLP01_2_3(string name, string img)
        {
            frm_LoaiPhong.textBox1.Text = name;
            frm_LoaiPhong.textBox2.Text = "10000";
            frm_LoaiPhong.txtDienTich.Text = "20";
            frm_LoaiPhong.txtImg.Text = img;
            frm_LoaiPhong.button1_Click(null,null);
        }
        [Ignore("Pass")]
        [Test]
        [TestCase("")]
        [TestCase("12a")]
        [TestCase("12@")]
        public void AddLP_QLP03_4_5(string price)
        {
            frm_LoaiPhong.textBox1.Text = "VipPro";
            frm_LoaiPhong.textBox2.Text = price;
            frm_LoaiPhong.txtDienTich.Text = "20";
            frm_LoaiPhong.txtImg.Text = "123";
            frm_LoaiPhong.button1_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        [TestCase("")]
        [TestCase("12a")]
        [TestCase("12@")]
        public void AddLP_QLP06_7_8(string dt)
        {
            frm_LoaiPhong.textBox1.Text = "VipPro";
            frm_LoaiPhong.textBox2.Text = "10000";
            frm_LoaiPhong.txtDienTich.Text = dt;
            frm_LoaiPhong.txtImg.Text = "123";
            frm_LoaiPhong.button1_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        [TestCase("")]
        //Đã có dl trong db
        [TestCase(@"D:\study\DA1\DuAn1_nhom55\QuanLyNhaTro\2_BUS_QLNT\Image\LP\asset-v1_FPOLY+COM107+2019_T09+type@asset+block@nganh-cong-nghe-thong-tin-hoc-nhung-mon-gi-1.jpg")]
        public void AddLP_QLP9_10(string img)
        {
            frm_LoaiPhong.textBox1.Text = "VipPro";
            frm_LoaiPhong.textBox2.Text = "10000";
            frm_LoaiPhong.txtDienTich.Text = "20";
            frm_LoaiPhong.txtImg.Text = img;
            frm_LoaiPhong.button1_Click(null, null);
        }
        #endregion
        #region Form Phòng Trọ
        [Ignore("Pass")]
        [Test]
        public void AddPT_QLPT01()
        {
            frm_PhongTro.comboBox1.SelectedIndex = -1;
            frm_PhongTro.comboBox2.SelectedIndex = 0;
            frm_PhongTro.button1_Click(null,null);
        }
        [Ignore("Pass")]
        [Test]
        public void AddPT_QLPT02()
        {
            frm_PhongTro.comboBox1.SelectedIndex = 0;
            frm_PhongTro.comboBox2.SelectedIndex = -1;
            frm_PhongTro.button1_Click(null, null);
        }
        [Ignore("Pass")]
        [Test]
        public void UpdatePT_QLPT03()
        {
            frm_PhongTro._pt = frm_PhongTro.BUS_PT.GetLstPhongTro().First(c => c.TrangThai == 1);
            frm_PhongTro.textBox1.Text = frm_PhongTro._pt.MaPhongTro;
            frm_PhongTro.comboBox1.Text = _dbContetxQlnt.LoaiPhongs.First(c=>c.MaLoaiPhong==frm_PhongTro._pt.MaLoaiPhong).TenLoaiPhong;
            frm_PhongTro.comboBox2.Text = _dbContetxQlnt.Tangs.First(c => c.MaTang == frm_PhongTro._pt.MaTang).TangNha;
            frm_PhongTro.txtStatus.Text = frm_PhongTro._pt.TrangThai == 1 ? "Đang thuê" : frm_PhongTro._pt.TrangThai == 0 ? "Chưa thuê" : "Dừng hoạt động";
            frm_PhongTro.button2_Click(null, null);
        }
        #endregion
        #region Form Người thuê
        [Ignore("Fail")]
        [Test]
        [TestCase("","1")]
        [TestCase("123", "2")]
        [TestCase("asd@", "3")]
        public void AddNT_QLNT01_2_3(string test, string info)
        {
            frm_NguoiThue.txt_ten.Text = test;
            frm_NguoiThue.txt_sdt.Text = info;
            frm_NguoiThue.txt_gmai.Text = info;
            frm_NguoiThue.txt_cccd.Text = info;
            frm_NguoiThue.txt_quequan.Text = info;
            frm_NguoiThue.txt_namsing.Text = info;
            frm_NguoiThue.cbx_nam.Checked = true;
            frm_NguoiThue.btn_them_Click(null,null);
        }
        [Ignore("Fail")]
        [Test]
        [TestCase("", "1")]
        [TestCase("123a", "2")]
        [TestCase("123@", "3")]
        [TestCase("123", "4")]//Đã có dl trong db
        public void AddNT_QLNT04_5_6_7(string test, string info)
        {
            frm_NguoiThue.txt_ten.Text = info;
            frm_NguoiThue.txt_sdt.Text = test;
            frm_NguoiThue.txt_gmai.Text = info;
            frm_NguoiThue.txt_cccd.Text = info;
            frm_NguoiThue.txt_quequan.Text = info;
            frm_NguoiThue.txt_namsing.Text = info;
            frm_NguoiThue.cbx_nam.Checked = true;
            frm_NguoiThue.btn_them_Click(null, null);
        }

        [Ignore("Fail")]
        [Test]
        [TestCase("", "1")]
        [TestCase("123a", "2")]
        [TestCase("123@", "3")]
        [TestCase("123", "4")]//Đã có dl trong db
        public void AddNT_QLNT08_9_10_11(string test, string info)
        {
            frm_NguoiThue.txt_ten.Text = info;
            frm_NguoiThue.txt_sdt.Text = info;
            frm_NguoiThue.txt_gmai.Text = info;
            frm_NguoiThue.txt_cccd.Text = test;
            frm_NguoiThue.txt_quequan.Text = info;
            frm_NguoiThue.txt_namsing.Text = info;
            frm_NguoiThue.cbx_nam.Checked = true;
            frm_NguoiThue.btn_them_Click(null, null);
        }

        [Ignore("Fail")]
        [Test]
        [TestCase("","5")]
        [TestCase("123", "6")]//Đã có dl trong db
        public void AddNT_QLNT12_13(string test, string info)
        {
            frm_NguoiThue.txt_ten.Text = info;
            frm_NguoiThue.txt_sdt.Text = info;
            frm_NguoiThue.txt_gmai.Text = test;
            frm_NguoiThue.txt_cccd.Text = info;
            frm_NguoiThue.txt_quequan.Text = info;
            frm_NguoiThue.txt_namsing.Text = info;
            frm_NguoiThue.cbx_nam.Checked = true;
            frm_NguoiThue.btn_them_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        [TestCase("", "14")]
        [TestCase("123a", "15")]
        [TestCase("123@", "16")]
        public void AddNT_QLNT14_15_16(string test, string info)
        {
            frm_NguoiThue.txt_ten.Text = info;
            frm_NguoiThue.txt_sdt.Text = info;
            frm_NguoiThue.txt_gmai.Text = info;
            frm_NguoiThue.txt_cccd.Text = info;
            frm_NguoiThue.txt_quequan.Text = info;
            frm_NguoiThue.txt_namsing.Text = test;
            frm_NguoiThue.cbx_nam.Checked = true;
            frm_NguoiThue.btn_them_Click(null, null);
        }

        [Ignore("Fail")]
        [Test]
        [TestCase("", "17")]
        public void AddNT_QLNT17(string test, string info)
        {
            frm_NguoiThue.txt_ten.Text = info;
            frm_NguoiThue.txt_sdt.Text = info;
            frm_NguoiThue.txt_gmai.Text = info;
            frm_NguoiThue.txt_cccd.Text = info;
            frm_NguoiThue.txt_quequan.Text = test;
            frm_NguoiThue.txt_namsing.Text = info;
            frm_NguoiThue.cbx_nam.Checked = true;
            frm_NguoiThue.btn_them_Click(null, null);
        }
        [Ignore("Fail")]
        [Test]
        //Đã có dl trong db
        [TestCase("", "NT3")]
        [TestCase("123a", "NT4")]
        [TestCase("123@", "NT5")]
        public void UpdateNT_QLNT19_20_21(string test, string info)
        {
            frm_NguoiThue.MaNguoiThue = info;
            var a = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == info);
            frm_NguoiThue.txt_ten.Text = test;
            frm_NguoiThue.txt_sdt.Text = a.SoDT;
            frm_NguoiThue.txt_gmai.Text = a.Email;
            frm_NguoiThue.txt_cccd.Text = a.CMND;
            frm_NguoiThue.txt_quequan.Text = a.QueQuan;
            frm_NguoiThue.txt_namsing.Text = a.NamSinh.ToString();
            frm_NguoiThue.btn_sua_Click(null, null);
        }
        [Ignore("Fail")]
        [Test]
        //Đã có dl trong db
        [TestCase("", "NT3")]
        [TestCase("123a", "NT4")]
        [TestCase("123@", "NT5")]
        [TestCase("123", "NT6")]
        public void UpdateNT_QLNT22_23_24_25(string test, string info)
        {
            frm_NguoiThue.MaNguoiThue = info;
            var a = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == info);
            frm_NguoiThue.txt_ten.Text = a.HoVaTen;
            frm_NguoiThue.txt_sdt.Text = test;
            frm_NguoiThue.txt_gmai.Text = a.Email;
            frm_NguoiThue.txt_cccd.Text = a.CMND;
            frm_NguoiThue.txt_quequan.Text = a.QueQuan;
            frm_NguoiThue.txt_namsing.Text = a.NamSinh.ToString();
            frm_NguoiThue.btn_sua_Click(null, null);
        }
        [Ignore("Fail")]
        [Test]
        //Đã có dl trong db
        [TestCase("", "NT3")]
        [TestCase("123a", "NT4")]
        [TestCase("123@", "NT5")]
        [TestCase("123", "NT6")]
        public void UpdateNT_QLNT26_27_28_29(string test, string info)
        {
            frm_NguoiThue.MaNguoiThue = info;
            var a = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == info);
            frm_NguoiThue.txt_ten.Text = a.HoVaTen;
            frm_NguoiThue.txt_sdt.Text = a.SoDT;
            frm_NguoiThue.txt_gmai.Text = a.Email;
            frm_NguoiThue.txt_cccd.Text = test;
            frm_NguoiThue.txt_quequan.Text = a.QueQuan;
            frm_NguoiThue.txt_namsing.Text = a.NamSinh.ToString();
            frm_NguoiThue.btn_sua_Click(null, null);
        }
        [Ignore("Fail")]
        [Test]
        //Đã có dl trong db
        [TestCase("", "NT3")]
        [TestCase("123", "NT4")]
        public void UpdateNT_QLNT30_31(string test, string info)
        {
            frm_NguoiThue.MaNguoiThue = info;
            var a = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == info);
            frm_NguoiThue.txt_ten.Text = a.HoVaTen;
            frm_NguoiThue.txt_sdt.Text = a.SoDT;
            frm_NguoiThue.txt_gmai.Text = test;
            frm_NguoiThue.txt_cccd.Text = a.CMND;
            frm_NguoiThue.txt_quequan.Text = a.QueQuan;
            frm_NguoiThue.txt_namsing.Text = a.NamSinh.ToString();
            frm_NguoiThue.btn_sua_Click(null, null);
        }
        [Ignore("Fail")]
        [Test]
        //Đã có dl trong db
        [TestCase("", "NT3")]
        [TestCase("123a", "NT4")]
        [TestCase("123@", "NT5")]
        public void UpdateNT_QLNT32_33_34(string test, string info)
        {
            frm_NguoiThue.MaNguoiThue = info;
            var a = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == info);
            frm_NguoiThue.txt_ten.Text = a.HoVaTen;
            frm_NguoiThue.txt_sdt.Text = a.SoDT;
            frm_NguoiThue.txt_gmai.Text = a.Email;
            frm_NguoiThue.txt_cccd.Text = a.CMND;
            frm_NguoiThue.txt_quequan.Text = a.QueQuan;
            frm_NguoiThue.txt_namsing.Text = test;
            frm_NguoiThue.btn_sua_Click(null, null);
        }
        [Ignore("Fail")]
        [TestCase("", "NT3")]
        public void UpdateNT_QLNT35(string test, string info)
        {
            frm_NguoiThue.MaNguoiThue = info;
            var a = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == info);
            frm_NguoiThue.txt_ten.Text = a.HoVaTen;
            frm_NguoiThue.txt_sdt.Text = a.SoDT;
            frm_NguoiThue.txt_gmai.Text = a.Email;
            frm_NguoiThue.txt_cccd.Text = a.CMND;
            frm_NguoiThue.txt_quequan.Text = test;
            frm_NguoiThue.txt_namsing.Text = a.NamSinh.ToString();
            frm_NguoiThue.btn_sua_Click(null, null);
        }
        #endregion
        #region Form Hợp Đồng
        [Ignore("Pass")]
        [Test]
        public void List_QLHD01()
        {
            frm_HopDong.btnList_Click(null, null);
            Thread.Sleep(2000);
        }
        [Ignore("Pass")]
        [Test]
        //Đã có dl trong db
        [TestCase("HD-002")]
        public void List_QLHD02(string id)
        {
            frm_ListHopDong_HopDong._hd = _dbContetxQlnt.HopDongs.First(c => c.MaHopDong == id);
            frm_ListHopDong_HopDong.button1_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        [TestCase("")]
        [TestCase("123a")]
        [TestCase("123@")]
        public void AddHD_QLHD03_4_5(string test)
        {
            var nt = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == "NT2");
            frm_HopDong.txtHoTen.Text = nt.HoVaTen;
            frm_HopDong.txtCMND.Text = nt.CMND;
            frm_HopDong.txtEmail.Text = nt.Email;
            frm_HopDong.txtGioiTinh.Text = nt.GioiTinh == true ? "Nam" : "Nữ";
            frm_HopDong.txtMaNguoiThue.Text = nt.MaNguoiThue;
            frm_HopDong.txtNamSinh.Text = nt.NamSinh.ToString();
            frm_HopDong.txtQueQuan.Text = nt.QueQuan;
            frm_HopDong.txtSDT.Text = nt.SoDT;
            frm_HopDong.txtThoiHan.Text = test;
            frm_HopDong.txtTraTruoc.Text = "1";
            //MessageBox.Show(frm_HopDong.listView1.Items[3].Text);
            for (int i = 0; i < frm_HopDong.listView1.Items.Count; i++)
            {
                if (frm_HopDong.listView1.Items[i].Text == "PT-104")
                {
                    ItemCheckEventArgs e = new ItemCheckEventArgs(i,CheckState.Checked,CheckState.Unchecked);
                    frm_HopDong.listView1_ItemCheck(frm_HopDong, e);
                }
            }
            frm_HopDong.btnAdd_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        [TestCase("","4")]
        [TestCase("123a","4")]
        [TestCase("123@","4")]
        [TestCase("3", "4")]
        public void AddHD_QLHD06_7_8_9(string test, string test2)
        {
            var nt = _dbContetxQlnt.NNguoiThues.First(c => c.MaNguoiThue == "NT2");
            frm_HopDong.txtHoTen.Text = nt.HoVaTen;
            frm_HopDong.txtCMND.Text = nt.CMND;
            frm_HopDong.txtEmail.Text = nt.Email;
            frm_HopDong.txtGioiTinh.Text = nt.GioiTinh == true ? "Nam" : "Nữ";
            frm_HopDong.txtMaNguoiThue.Text = nt.MaNguoiThue;
            frm_HopDong.txtNamSinh.Text = nt.NamSinh.ToString();
            frm_HopDong.txtQueQuan.Text = nt.QueQuan;
            frm_HopDong.txtSDT.Text = nt.SoDT;
            frm_HopDong.txtThoiHan.Text = test2;
            frm_HopDong.txtTraTruoc.Text = test;
            //MessageBox.Show(frm_HopDong.listView1.Items[3].Text);
            for (int i = 0; i < frm_HopDong.listView1.Items.Count; i++)
            {
                if (frm_HopDong.listView1.Items[i].Text == "PT-104")
                {
                    ItemCheckEventArgs e = new ItemCheckEventArgs(i, CheckState.Checked, CheckState.Unchecked);
                    frm_HopDong.listView1_ItemCheck(frm_HopDong, e);
                }
            }
            frm_HopDong.btnAdd_Click(null, null);
        }
        [Ignore("Pass")]
        [Test]
        public void Loc_QLHD13()
        {
            frm_HopDong.comboBox1.SelectedIndex = 0;
            frm_HopDong.btnLoc_Click(null, null);
        }

        #endregion
        #region Form Điện nước
        [Ignore("Pass")]
        [Test]
        [TestCase("","2000")]
        [TestCase("123a", "2000")]
        [TestCase("123@", "2000")]
        public void AddDienNuoc_QLDN01_2_3(string test, string test2)
        {
            frm_DienNuoc.txt_dien.Text = test;
            frm_DienNuoc.txt_nuoc.Text = test2;
            frm_DienNuoc.btn_them_Click(null, null);
        }
        [Ignore("Pass")]
        [Test]
        [TestCase("", "2000")]
        [TestCase("123a", "2000")]
        [TestCase("123@", "2000")]
        public void AddDienNuoc_QLDN04_5_6(string test, string test2)
        {
            frm_DienNuoc.txt_dien.Text = test2;
            frm_DienNuoc.txt_nuoc.Text = test;
            frm_DienNuoc.btn_them_Click(null, null);
        }
        [Ignore("Pass")]
        [Test]
        [TestCase("", "2000", "DN1")]
        [TestCase("123a", "2000", "DN1")]
        [TestCase("123@", "2000", "DN1")]
        public void UpdateDienNuoc_QLDN07_8_9(string test, string test2, string test3)
        {
            frm_DienNuoc.txt_dien.Text = test2;
            frm_DienNuoc.txt_nuoc.Text = test;
            frm_DienNuoc.MADN = test3;
            frm_DienNuoc.btn_sua_Click(null, null);
        }
        [Ignore("Pass")]
        [Test]
        [TestCase("", "2000", "DN1")]
        [TestCase("123a", "2000", "DN1")]
        [TestCase("123@", "2000", "DN1")]
        public void UpdateDienNuoc_QLDN10_11_12(string test, string test2, string test3)
        {
            frm_DienNuoc.txt_dien.Text = test;
            frm_DienNuoc.txt_nuoc.Text = test2;
            frm_DienNuoc.MADN = test3;
            frm_DienNuoc.btn_sua_Click(null, null);
        }
        #endregion
        #region Form Hóa đơn
        [Ignore("Pass")]
        [Test]
        [TestCase("")]
        [TestCase("123a")]
        [TestCase("123@")]
        public void UpdateGiamGia_QLHD01_2_3(string test)
        {
            DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, 0);
            frm_QLHoaDon.dgrv_HoaDon_CellClick(frm_QLHoaDon, e);
            frm_QLHoaDon.txt_tiengiam.Text = test;
            frm_QLHoaDon.btn_tiengiam_Click(null, null);
        }
        [Ignore("Pass")]
        [Test]
        [TestCase("")]
        [TestCase("123a")]
        [TestCase("123@")]
        public void UpdateGiamGia_QLHD04_5_6(string test)
        {
            DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, 0);
            frm_QLHoaDon.dgrv_HoaDon_CellClick(frm_QLHoaDon, e);
            frm_QLHoaDon.txt_tientt.Text = test;
            frm_QLHoaDon.btn_update_Click(null, null);
        }
        #endregion
        #region Form Loại dịch vụ
        [Ignore("Fail")]
        [Test]
        [TestCase("")]
        [TestCase("asd")]//Đã có dl trong db
        public void AddLDV_QLLDV01_2_3(string test)
        {
            frm_QLLoaiDV.txt_TenLoaiDV.Text = test;
            frm_QLLoaiDV.btn_add_Click(null, null);
        }
        [Ignore("Fail")]
        [Test]
        [TestCase("")]
        [TestCase("asd")]//Đã có dl trong db
        public void UpdateLDV_QLLDV04_5_6(string test)
        {
            frm_QLLoaiDV.txt_TenLoaiDV.Text = test;
            frm_QLLoaiDV.btn_edit_Click(null, null);
        }
        #endregion
        #region Form Dịch vụ
        [Ignore("Fail")]
        [Test]
        [TestCase("")]
        [TestCase("123@")]
        public void AddDV_QLDV01_2(string test)
        {
            frm_QLDichVu.cmbx_LoaiDichVu.SelectedIndex = 0;
            frm_QLDichVu.txt_TenDV.Text = test;
            frm_QLDichVu.txt_DonGia.Text = "10000";
            frm_QLDichVu.btn_add_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        [TestCase("","1")]
        [TestCase("123@","2")]
        [TestCase("123a", "3")]
        public void AddDV_QLDV03_4_5(string test, string tendv)
        {
            frm_QLDichVu.cmbx_LoaiDichVu.SelectedIndex = 0;
            frm_QLDichVu.txt_TenDV.Text = tendv;
            frm_QLDichVu.txt_DonGia.Text = test;
            frm_QLDichVu.btn_add_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        public void AddDV_QLDV06()
        {
            frm_QLDichVu.cmbx_LoaiDichVu.SelectedItem = null;
            frm_QLDichVu.txt_TenDV.Text = "fsdfsdf";
            frm_QLDichVu.txt_DonGia.Text = "10000";
            frm_QLDichVu.btn_add_Click(null, null);
        }

        [Ignore("Fail")]
        [Test]
        [TestCase("")]
        [TestCase("123@")]
        [TestCase("zxc")]//Đã có dl trong db
        public void AddDV_QLDV07_8_9(string test)
        {
            DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, 0);
            frm_QLDichVu.dgrv_qldichvu_CellClick(frm_QLDichVu, e);
            frm_QLDichVu.txt_TenDV.Text = test;
            frm_QLDichVu.btn_edit_Click(null, null);
        }

        [Ignore("Pass")]
        [Test]
        [TestCase("")]
        [TestCase("123a")]
        [TestCase("123@")]
        public void AddDV_QLDV10_11_12(string test)
        {
            DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, 0);
            frm_QLDichVu.dgrv_qldichvu_CellClick(frm_QLDichVu, e);
            frm_QLDichVu.txt_DonGia.Text = test;
            frm_QLDichVu.btn_edit_Click(null, null);
        }
        #endregion
        #region Form Đăng nhập
        [Ignore("Pass")]
        [Test]
        [TestCase("hungldph13592@fpt.edu.vn","123")]
        [TestCase("hungldph13592@fpt.edu.vn1", "1234")]
        public void Login_QLDN01_2(string a, string b)
        {
            frm_Login.tbx_MatKhau.Text = b;
            frm_Login.tbx_TaiKhoan.Text = a;
            frm_Login.btn_Login_Click(null, null);
        }
        [Ignore("Fail")]
        [Test]
        [TestCase("hungldph13592@fpt.edu.vn")]
        [TestCase("hungldph13592@fpt.edu.vn1")]
        public void QuenMK_QLDN03_4(string test)
        {
            frm_QuenMk.tbx_TaiKhoan.Text = test;
            frm_QuenMk.button1_Click(null, null);
        }
        #endregion
    }
}