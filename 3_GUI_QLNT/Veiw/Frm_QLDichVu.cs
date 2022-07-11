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
    public partial class Frm_QLDichVu : Form
    {
        private string MaDV;
        private int count;
        private IServicesQLDichVu _iServicesQlDichVu;
        public Frm_QLDichVu()
        {
            InitializeComponent();
            _iServicesQlDichVu = new ServicesQLDichVu();
            rbtn_hd.Checked = true;
            addLoaiDV();
            LoadLoaiDV();
            LoadGrv();
            count = _iServicesQlDichVu.LoaDataDV().Count;
        }
        public void LoadLoaiDV()
        {
            cmbx_LoaiDichVu.Items.Clear();
            foreach (var x in _iServicesQlDichVu.LoadDataLoaiDV())
            {
                cmbx_LoaiDichVu.Items.Add(x.TenLoaiDV);
            }
        }
        public void addLoaiDV()
        {
            cmbx_loaidv.Items.Clear();
            foreach (var x in _iServicesQlDichVu.LoadDataLoaiDV())
            {
                cmbx_loaidv.Items.Add(x.TenLoaiDV);
            }
        }

        public void LoadGrv()
        {
            dgrv_qldichvu.ColumnCount = 4;
            dgrv_qldichvu.Columns[0].Name = "Mã DV";
            dgrv_qldichvu.Columns[1].Name = "Tên DV";
            dgrv_qldichvu.Columns[2].Name = "Đơn giá";
            dgrv_qldichvu.Columns[3].Name = "Trạng thái";
            dgrv_qldichvu.Rows.Clear();
            foreach (var x in _iServicesQlDichVu.LoaDataDV())
            {
                dgrv_qldichvu.Rows.Add(x.MaDV, x.TenDV, x.DonGia, x.TrangThai==1?"Hoạt động":"Không hoạt động");
            }
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadGrv();
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dv = new DichVu();
                dv.MaDV="DV"+(_iServicesQlDichVu.LoaDataDV().Count+1);
                dv.MaLoaiDV = _iServicesQlDichVu.LoadDataLoaiDV().Where(c => c.TenLoaiDV == cmbx_LoaiDichVu.Text)
                    .Select(c => c.MaLoaiDV).FirstOrDefault();
                dv.TenDV = txt_TenDV.Text;
                dv.DonGia = float.Parse(txt_DonGia.Text);
                dv.TrangThai = rbtn_hd.Checked == true ? 1 : 0;
                if (dv.MaLoaiDV == null)
                {
                    MessageBox.Show("Bạn chưa chọn loại dịch vụ, xin hãy chọn lại", "Thông báo");
                    return;
                }
                MessageBox.Show(_iServicesQlDichVu.AddDV(dv), "Thông báo");
                LoadGrv();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi nhập", "Thông báo");
            }
        }

        private void Frm_QLDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            var lst = _iServicesQlDichVu.LoaDataDV().Where(c => c.TenDV.Contains(txt_tk.Text));
            dgrv_qldichvu.Rows.Clear();
            foreach (var x in lst)
            {
                dgrv_qldichvu.Rows.Add(x.MaDV, x.TenDV, x.DonGia, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public void dgrv_qldichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= count) return;
            MaDV=lbl_hienthima.Text = dgrv_qldichvu.Rows[index].Cells[0].Value.ToString();
            txt_TenDV.Text = dgrv_qldichvu.Rows[index].Cells[1].Value.ToString();
            txt_DonGia.Text = dgrv_qldichvu.Rows[index].Cells[2].Value.ToString();
            rbtn_hd.Checked = dgrv_qldichvu.Rows[index].Cells[3].Value.ToString()=="Hoạt động"?true:false;
            rbtn_khd.Checked = dgrv_qldichvu.Rows[index].Cells[3].Value.ToString()=="Không hoạt động"?true:false;
            cmbx_LoaiDichVu.Text = _iServicesQlDichVu.LoadDataLoaiDV()
                .Where(c => c.MaLoaiDV == _iServicesQlDichVu.LoaDataDV().Where(c => c.MaDV == MaDV)
                    .Select(c => c.MaLoaiDV).FirstOrDefault()).Select(c => c.TenLoaiDV).FirstOrDefault();
        }

        public void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var dv = _iServicesQlDichVu.LoaDataDV().Where(c => c.MaDV == MaDV).FirstOrDefault();
                dv.TenDV = txt_TenDV.Text;
                dv.DonGia = float.Parse(txt_DonGia.Text);
                dv.TrangThai = rbtn_hd.Checked == true ? 1 : 0;
                MessageBox.Show(_iServicesQlDichVu.EditDV(dv), "Thông báo");
                LoadGrv();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi sửa", "Thông báo");
            }
        }

        private void cmbx_loaidv_SelectedValueChanged(object sender, EventArgs e)
        {
            var lst = _iServicesQlDichVu.LoaDataDV().Where(c =>
                c.MaLoaiDV == _iServicesQlDichVu.LoadDataLoaiDV().Where(c => c.TenLoaiDV == cmbx_loaidv.Text)
                    .Select(c => c.MaLoaiDV).FirstOrDefault());
            count = lst.Count();
            dgrv_qldichvu.Rows.Clear();
            foreach (var x in lst)
            {
                dgrv_qldichvu.Rows.Add(x.MaDV, x.TenDV, x.DonGia,
                    x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void cmbx_loctt_SelectedValueChanged(object sender, EventArgs e)
        {
            var lst = _iServicesQlDichVu.LoaDataDV()
                .Where(c => c.TrangThai ==(cmbx_loctt.Text=="Hoạt động"?1:0));
            count = lst.Count();
            dgrv_qldichvu.Rows.Clear();
            foreach (var x in lst)
            {
                dgrv_qldichvu.Rows.Add(x.MaDV, x.TenDV, x.DonGia,
                    x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
    }
}
