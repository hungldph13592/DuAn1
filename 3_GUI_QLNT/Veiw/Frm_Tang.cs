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
    public partial class Frm_Tang : Form
    {
        private IQuanLyTang BUS_Tang;
        public Frm_Tang()
        {
            InitializeComponent();
            BUS_Tang = new QuanLyTang();
            LoadData();
        }

        private void Frm_Tang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
        void LoadData()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Mã tầng";
            dataGridView1.Columns[1].Name = "Tầng";
            dataGridView1.Rows.Clear();
            foreach (var item in BUS_Tang.LstTang())
            {
                dataGridView1.Rows.Add(item.MaTang, item.TangNha);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm tầng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = BUS_Tang.LstTang().Count;
                Tang tg = new Tang();
                tg.MaTang = "T" + (a + 1).ToString("D3");
                tg.TangNha = (a + 1).ToString();
                MessageBox.Show(BUS_Tang.AddTang(tg));
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
           
        }
    }
}
