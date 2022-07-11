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
    public partial class Frm_LoaiPhong : Form
    {
        private IQuanLyLoaiPhong BUS_LP;
        private LoaiPhong _lp;
        public Frm_LoaiPhong()
        {
            InitializeComponent();
            BUS_LP = new QuanLyLoaiPhong();
            _lp = new LoaiPhong();
            LoadData();
        }
        void LoadData()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã loại phòng";
            dataGridView1.Columns[1].Name = "Tên loại phòng";
            dataGridView1.Columns[2].Name = "Giá thuê";
            dataGridView1.Columns[3].Name = "Diện tích";
            dataGridView1.Rows.Clear();
            foreach (var item in BUS_LP.GetLstLP())
            {
                dataGridView1.Rows.Add(item.MaLoaiPhong, item.TenLoaiPhong, item.GiaThue, item.DienTich);
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (BUS_LP.GetLstLP().Exists(c => c.TenLoaiPhong == textBox1.Text || c.HinhAnh == txtImg.Text) || !float.TryParse(textBox2.Text, out float result) || string.IsNullOrEmpty(txtImg.Text) || string.IsNullOrEmpty(textBox1.Text) || !float.TryParse(txtDienTich.Text, out float result1))
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            }
            int a = BUS_LP.GetLstLP().Count + 1;
            LoaiPhong lp = new LoaiPhong();
            lp.MaLoaiPhong = "LP-" + a.ToString("D3");
            lp.TenLoaiPhong = textBox1.Text;
            lp.GiaThue = float.Parse(textBox2.Text);
            lp.DienTich = float.Parse(txtDienTich.Text);
            lp.HinhAnh = txtImg.Text;
            MessageBox.Show(BUS_LP.AddLP(lp));
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_lp == null)
            {
                return;
            }
            try
            {
                List<LoaiPhong> lst = new List<LoaiPhong>();
                lst = BUS_LP.GetLstLP();
                lst.Remove(_lp);
                if (!float.TryParse(textBox2.Text,out float a)|| !float.TryParse(txtDienTich.Text, out float b) || (lst.Exists(c => c.TenLoaiPhong == textBox1.Text || c.HinhAnh == txtImg.Text)) || string.IsNullOrEmpty(txtImg.Text) || string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ");
                    return;
                }
                _lp.TenLoaiPhong = textBox1.Text;
                _lp.GiaThue = float.Parse(textBox2.Text);
                _lp.HinhAnh = txtImg.Text;
                _lp.DienTich = float.Parse(txtDienTich.Text);
                MessageBox.Show(BUS_LP.Update(_lp));
                LoadData();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Lẽ ra không nên hiện cái này");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _lp = BUS_LP.GetLstLP().FirstOrDefault(c => c.MaLoaiPhong == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = _lp.TenLoaiPhong;
            textBox2.Text = _lp.GiaThue.ToString();
            txtImg.Text = _lp.HinhAnh;
            txtDienTich.Text = _lp.DienTich.ToString();
            pictureBox1.Image = new Bitmap(_lp.HinhAnh);
        }

        private void Frm_LoaiPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp | *.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = dialog.FileName;
                pictureBox1.Image = new Bitmap(dialog.FileName);
            }
        }
    }
}
