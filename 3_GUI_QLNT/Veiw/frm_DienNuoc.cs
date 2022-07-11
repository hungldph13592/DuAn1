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
    public partial class frm_DienNuoc : Form
    {
        private IQuanLyDienNuoc QLDienNuoc;
        public string MADN;
        public frm_DienNuoc()
        {
            InitializeComponent();
            QLDienNuoc = new QuanLyDienNuoc();
                loadData();
        }
        public void loadData()
        {
           datadiennuoc.ColumnCount = 3;
           datadiennuoc.Columns[0].Name = "Mã Điện Nước";
           datadiennuoc.Columns[1].Name = "Giá Điện  ";
           datadiennuoc.Columns[2].Name = "Giá nước ";
            
          datadiennuoc.Rows.Clear();
           foreach (var x in QLDienNuoc.LoadDataLoaiDn())
           {
               datadiennuoc.Rows.Add(x.MaDienNuoc, x.GiaDien, x.GiaNuoc);  
           }
        }

        public void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DienNuoc NT = new DienNuoc();
                NT.MaDienNuoc = "DN" + (QLDienNuoc.LoadDataLoaiDn().Count + 1);
                NT.GiaDien = float.Parse(txt_dien.Text);
                NT.GiaNuoc = float.Parse( txt_nuoc.Text);
               
                MessageBox.Show(QLDienNuoc.AddDV(NT), "Thông báo");
                loadData();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Lỗi nhập", "Thông báo");
            }
        }

        private void datadiennuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= QLDienNuoc.LoadDataLoaiDn().Count) return;
            MADN= label3.Text = datadiennuoc.Rows[index].Cells[0].Value.ToString();
            txt_dien.Text = datadiennuoc.Rows[index].Cells[1].Value.ToString();
            txt_nuoc.Text = datadiennuoc.Rows[index].Cells[2].Value.ToString();
            MADN = datadiennuoc.Rows[index].Cells[0].Value.ToString();

        }

        public void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var NT = QLDienNuoc.LoadDataLoaiDn().Where(c => c.MaDienNuoc == MADN).FirstOrDefault();
                NT.GiaDien = float.Parse( txt_dien.Text);
                NT.GiaNuoc = float.Parse(txt_nuoc.Text);
               
                MessageBox.Show(QLDienNuoc.EditDV(NT), "Thông báo");
            }
            catch (Exception exception)
            {

                MessageBox.Show("Sửa lỗi");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Frm_Main nt = new Frm_Main();
            nt.Show();
            this.Hide();

        }

        private void frm_DienNuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
