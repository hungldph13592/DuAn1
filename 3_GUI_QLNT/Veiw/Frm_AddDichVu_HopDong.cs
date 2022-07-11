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
    public partial class Frm_AddDichVu_HopDong : Form
    {
        private IServicesQLDichVu BUS_DV;
        private List<DichVu> _lst1;
        private List<DichVu> _lst2;
        private DichVu _dv1;
        private DichVu _dv2;
        public static Frm_AddDichVu_HopDong instance;
        public Frm_AddDichVu_HopDong()
        {
            InitializeComponent();
            instance = this;
            BUS_DV = new ServicesQLDichVu();
            _lst1 = new List<DichVu>();
            _lst2 = new List<DichVu>();
            _dv1 = new DichVu();
            _dv2 = new DichVu();
            label1.Text = "";
            label3.Text = "";
            loadData1();
            loadData2();
        }
        public void GetName(string a, List<PhongTro_DichVu> lst)
        {
            label2.Text = a;
            foreach (var item in lst)
            {
                if (item.MaPhongTro == a)
                {
                    DichVu dichVu = new DichVu();
                    dichVu = BUS_DV.LoaDataDV().First(c => c.MaDV == item.MaDichVu);
                    _lst2.Add(dichVu); 
                }
            }
            loadData1();
            loadData2();
        }
        void loadData1()
        {
            _lst1 = new List<DichVu>();
            foreach (var item in BUS_DV.LoaDataDV().Where(c=>c.TrangThai==1).ToList())
            {
                _lst1.Add(item);
            }
            foreach (var item in _lst2)
            {
                if (_lst1.Exists(c=>c.MaDV==item.MaDV))
                {
                    _lst1.Remove(_lst1.First(c => c.MaDV == item.MaDV));
                }
            }
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Mã dịch vụ";
            dataGridView1.Columns[1].Name = "Tên dịch vụ";
            dataGridView1.Columns[2].Name = "Đơn giá";
            dataGridView1.Rows.Clear();
            foreach (var item in _lst1)
            {
                dataGridView1.Rows.Add(item.MaDV, item.TenDV, item.DonGia);
            }
        }
        void loadData2()
        {
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Mã dịch vụ";
            dataGridView2.Columns[1].Name = "Tên dịch vụ";
            dataGridView2.Columns[2].Name = "Đơn giá";
            dataGridView2.Rows.Clear();
            foreach (var item in _lst2)
            {
                dataGridView2.Rows.Add(item.MaDV, item.TenDV, item.DonGia);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_dv1.MaDV == null)
            {
                return;
            }
            _lst2.Add(_dv1);
            loadData1();
            loadData2();
            PhongTro_DichVu a = new PhongTro_DichVu();
            a.MaPhongTro = label2.Text;
            a.MaDichVu = _dv1.MaDV;
            a.TenDichVu = _dv1.TenDV;
            a.DonGia = _dv1.DonGia;
            Frm_HopDong.instance._lstPTDV.Add(a);
            _dv1 = new DichVu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _lst1.Count)
            {
                return;
            }
            else
            {
                _dv1 = BUS_DV.LoaDataDV().First(c => c.MaDV == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                label1.Text = _dv1.MaDV;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _lst2.Count)
            {
                return;
            }
            _dv2 = BUS_DV.LoaDataDV().First(c => c.MaDV == dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            label3.Text = _dv2.MaDV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_dv2.MaDV == null)
            {
                return;
            }
            _lst2.Remove(_dv2);
            Frm_HopDong.instance._lstPTDV.Remove(Frm_HopDong.instance._lstPTDV.First(c => c.MaPhongTro == label2.Text && c.MaDichVu == _dv2.MaDV));
           _dv2 = new DichVu();
            loadData1();
            loadData2();
        }

        private void Frm_AddDichVu_HopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
