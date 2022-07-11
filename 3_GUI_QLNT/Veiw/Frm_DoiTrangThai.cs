using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_QLNT.IServices;
using _2_BUS_QLNT.Services;

namespace _3_GUI_QLNT.Veiw
{
    public partial class Frm_DoiTrangThai : Form
    {
        private IServicesDoiTT _iServicesDoiTt;
        public Frm_DoiTrangThai()
        {
            InitializeComponent();
            _iServicesDoiTt = new ServicesDoiTT();
            Load();
        }

        private void Frm_DoiTrangThai_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_doitt_Click(object sender, EventArgs e)
        {
            var pt = _iServicesDoiTt.LoadDataPhongTro().Where(c => c.MaPhongTro == lbl_maphong.Text).FirstOrDefault();
            if (pt.TrangThai==0)
            {
                pt.TrangThai = 2;
                _iServicesDoiTt.Update(pt);
                Load();
                return;
            }
            if (pt.TrangThai == 1)
            {
                return;
            }
            if (pt.TrangThai == 2)
            {
                pt.TrangThai = 0;
                _iServicesDoiTt.Update(pt);
                Load();
                return;
            }
        }

        public void Load()
        {
            lbl_maphong.Text = Properties.Settings.Default.MaPhongTro;
            lbl_trangthai.Text = _iServicesDoiTt.LoadDataPhongTro().Where(c => c.MaPhongTro == lbl_maphong.Text)
                .Select(c => c.TrangThai).FirstOrDefault()==0?"Phòng trống": _iServicesDoiTt.LoadDataPhongTro().Where(c => c.MaPhongTro == lbl_maphong.Text)
                .Select(c => c.TrangThai).FirstOrDefault() ==1?"Đã có người thuê":"Đang sửa";
        }
    }
}
