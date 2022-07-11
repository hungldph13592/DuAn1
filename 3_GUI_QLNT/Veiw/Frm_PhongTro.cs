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
    public partial class Frm_PhongTro : Form
    {
        public IQuanLyPhongTro BUS_PT;
        private IQuanLyLoaiPhong BUS_LP;
        private IQuanLyTang BUS_Tang;
        public PhongTro _pt;
        public Frm_PhongTro()
        {
            InitializeComponent();
            BUS_PT = new QuanLyPhongTro();
            BUS_LP = new QuanLyLoaiPhong();
            BUS_Tang = new QuanLyTang();
            _pt = new PhongTro();
            LoadCbx();
            LoadData();
        }
        void LoadCbx()
        {
            foreach (var item in BUS_LP.GetLstLP())
            {
                comboBox1.Items.Add(item.TenLoaiPhong);
            }
            foreach (var item in BUS_Tang.LstTang())
            {
                comboBox2.Items.Add(item.TangNha);
            }
        }
        void LoadData()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã phòng";
            dataGridView1.Columns[1].Name = "Loại phòng";
            dataGridView1.Columns[2].Name = "Tầng";
            dataGridView1.Columns[3].Name = "Trạng thái";
            dataGridView1.Rows.Clear();
            foreach (var item in BUS_PT.GetLstPhongTro())
            {
                dataGridView1.Rows.Add(item.MaPhongTro, BUS_LP.GetLstLP().FirstOrDefault(c => c.MaLoaiPhong == item.MaLoaiPhong).TenLoaiPhong, BUS_Tang.LstTang().FirstOrDefault(c => c.MaTang == item.MaTang).TangNha, item.TrangThai==1?"Đang thuê":item.TrangThai==0?"Chưa thuê":"Dừng hoạt động");
            }
        }
        private void Frm_PhongTro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ");
                    return;
                }
                int b = int.Parse(comboBox2.SelectedItem.ToString());
                int c = BUS_PT.GetLstPhongTro().Where(c => c.MaTang == BUS_Tang.LstTang().First(c => c.TangNha == comboBox2.SelectedItem.ToString()).MaTang).ToList().Count;
                //int a = BUS_PT.GetLstPhongTro().Count + 1;
                int a = c + 1;
                PhongTro pt = new PhongTro();
                pt.MaTang = BUS_Tang.LstTang().FirstOrDefault(c => c.TangNha == comboBox2.SelectedItem.ToString()).MaTang.ToString();
                pt.MaLoaiPhong = BUS_LP.GetLstLP().FirstOrDefault(c => c.TenLoaiPhong == comboBox1.SelectedItem.ToString()).MaLoaiPhong.ToString();
                pt.TrangThai = 0;
                pt.MaPhongTro = "PT-" + b.ToString() + a.ToString("D2");
                MessageBox.Show(BUS_PT.AddPT(pt));
                LoadData();
            }
            catch (Exception)
            {
                return;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            _pt.MaLoaiPhong = BUS_LP.GetLstLP().First(c => c.TenLoaiPhong == comboBox1.Text).MaLoaiPhong;
            if (_pt.TrangThai == 1)
            {
                MessageBox.Show("Không thể đổi vì đang có người thuê");
                return;
            }
            MessageBox.Show(BUS_PT.UpdatePT(_pt));
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _pt = BUS_PT.GetLstPhongTro().First(c => c.MaPhongTro == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = _pt.MaPhongTro;
            comboBox1.Text = BUS_LP.GetLstLP().First(c => c.MaLoaiPhong == _pt.MaLoaiPhong).TenLoaiPhong;
            comboBox2.Text = BUS_Tang.LstTang().First(c => c.MaTang == _pt.MaTang).TangNha;
            txtStatus.Text = _pt.TrangThai == 1 ? "Đang thuê" : _pt.TrangThai == 0 ? "Chưa thuê" : "Dừng hoạt động";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pt.MaPhongTro == null)
                {
                    return;
                }
                else
                {
                    if (_pt.TrangThai == 1)
                    {
                        MessageBox.Show("Không thể đổi vì đang có người thuê");
                        return;
                    }
                    else if (_pt.TrangThai == 0)
                    {
                        _pt.TrangThai = 2;
                    }
                    else
                    {
                        _pt.TrangThai = 0;
                    }
                    MessageBox.Show(BUS_PT.UpdatePT(_pt));
                    LoadData();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
