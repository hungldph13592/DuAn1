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
    public partial class Frm_QLLoaiDV : Form
    {
        public string Maldv;
        private IServicesQLLoaiDV _iServicesQlLoaiDv;
        public Frm_QLLoaiDV()
        {
            InitializeComponent();
            _iServicesQlLoaiDv = new ServicesQLLoaiDV();
            LoadGrv();
        }

        public void LoadGrv()
        {
            dgrv_qldichvu.ColumnCount = 2;
            dgrv_qldichvu.Columns[0].Name = "Mã loại dịch vụ";
            dgrv_qldichvu.Columns[1].Name = "Tên loại dịch vụ";
            dgrv_qldichvu.Rows.Clear();
            foreach (var x in _iServicesQlLoaiDv.LoadDataLoaiDV())
            {
                dgrv_qldichvu.Rows.Add(x.MaLoaiDV, x.TenLoaiDV);
            }
        }
        private void Frm_QLLoaiDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_TK_Click(object sender, EventArgs e)
        {
            var lst = _iServicesQlLoaiDv.LoadDataLoaiDV().Where(c=>c.TenLoaiDV.Contains(txt_tkldv.Text));
            dgrv_qldichvu.Rows.Clear();
            foreach (var x in lst)
            {
                dgrv_qldichvu.Rows.Add(x.MaLoaiDV, x.TenLoaiDV);
            }
        }

        public void dgrv_qldichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index<0||index>=_iServicesQlLoaiDv.LoadDataLoaiDV().Count)return;
            Maldv=lbl_hienthima.Text = dgrv_qldichvu.Rows[index].Cells[0].Value.ToString();
            txt_TenLoaiDV.Text = dgrv_qldichvu.Rows[index].Cells[1].Value.ToString();
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiDichVu ldv = new LoaiDichVu();
                ldv.MaLoaiDV = "LDV" + (_iServicesQlLoaiDv.LoadDataLoaiDV().Count + 1);
                ldv.TenLoaiDV = txt_TenLoaiDV.Text;
                MessageBox.Show(_iServicesQlLoaiDv.AddLoaiDV(ldv), "Thông báo");
                LoadGrv();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi nhập", "Thông báo");
            }
        }

        public void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var lst = _iServicesQlLoaiDv.LoadDataLoaiDV().Where(c => c.MaLoaiDV == Maldv).FirstOrDefault();
                lst.TenLoaiDV = txt_TenLoaiDV.Text;
                MessageBox.Show(_iServicesQlLoaiDv.EditLoaiDV(lst), "Thông báo");
                LoadGrv();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi sửa", "Thông báo");
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadGrv();
        }
    }
}
