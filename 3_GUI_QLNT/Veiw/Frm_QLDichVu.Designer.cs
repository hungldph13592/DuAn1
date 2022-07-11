
namespace _3_GUI_QLNT.Veiw
{
    partial class Frm_QLDichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QLDichVu));
            this.btn_load = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_TK = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.btn_Quaylai = new System.Windows.Forms.Button();
            this.dgrv_qldichvu = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_hienthima = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.rbtn_hd = new System.Windows.Forms.RadioButton();
            this.rbtn_khd = new System.Windows.Forms.RadioButton();
            this.cmbx_loaidv = new System.Windows.Forms.ComboBox();
            this.grbx_chucnang = new System.Windows.Forms.GroupBox();
            this.grbx_loc = new System.Windows.Forms.GroupBox();
            this.cmbx_loctt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbx_LoaiDichVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_qldichvu)).BeginInit();
            this.grbx_chucnang.SuspendLayout();
            this.grbx_loc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Image = ((System.Drawing.Image)(resources.GetObject("btn_load.Image")));
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.Location = new System.Drawing.Point(6, 67);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(216, 43);
            this.btn_load.TabIndex = 26;
            this.btn_load.Text = "Load danh sách";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(679, 434);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 15);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dự án 1_Phần mềm quản lý nhà trọ";
            // 
            // btn_TK
            // 
            this.btn_TK.Image = ((System.Drawing.Image)(resources.GetObject("btn_TK.Image")));
            this.btn_TK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TK.Location = new System.Drawing.Point(6, 103);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(214, 44);
            this.btn_TK.TabIndex = 24;
            this.btn_TK.Text = "Tìm kiếm";
            this.btn_TK.UseVisualStyleBackColor = true;
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tk.Location = new System.Drawing.Point(4, 69);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.PlaceholderText = "Nhập tên để tìm kiếm";
            this.txt_tk.Size = new System.Drawing.Size(216, 29);
            this.txt_tk.TabIndex = 23;
            this.txt_tk.Tag = "";
            // 
            // btn_Quaylai
            // 
            this.btn_Quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_Quaylai.Image")));
            this.btn_Quaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Quaylai.Location = new System.Drawing.Point(779, 3);
            this.btn_Quaylai.Name = "btn_Quaylai";
            this.btn_Quaylai.Size = new System.Drawing.Size(100, 50);
            this.btn_Quaylai.TabIndex = 22;
            this.btn_Quaylai.Text = "Quay lại";
            this.btn_Quaylai.UseVisualStyleBackColor = true;
            this.btn_Quaylai.Click += new System.EventHandler(this.btn_Quaylai_Click);
            // 
            // dgrv_qldichvu
            // 
            this.dgrv_qldichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrv_qldichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_qldichvu.Location = new System.Drawing.Point(12, 178);
            this.dgrv_qldichvu.Name = "dgrv_qldichvu";
            this.dgrv_qldichvu.RowTemplate.Height = 25;
            this.dgrv_qldichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrv_qldichvu.Size = new System.Drawing.Size(616, 271);
            this.dgrv_qldichvu.TabIndex = 21;
            this.dgrv_qldichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_qldichvu_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(122, 22);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 39);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quản lý dịch vụ";
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(8, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 39);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_hienthima
            // 
            this.lbl_hienthima.AutoSize = true;
            this.lbl_hienthima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hienthima.Location = new System.Drawing.Point(119, 82);
            this.lbl_hienthima.Name = "lbl_hienthima";
            this.lbl_hienthima.Size = new System.Drawing.Size(0, 21);
            this.lbl_hienthima.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenDV.Location = new System.Drawing.Point(119, 129);
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.Size = new System.Drawing.Size(217, 29);
            this.txt_TenDV.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(345, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Đơn giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(345, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Trạng thái:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DonGia.Location = new System.Drawing.Point(436, 74);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(147, 29);
            this.txt_DonGia.TabIndex = 29;
            // 
            // rbtn_hd
            // 
            this.rbtn_hd.AutoSize = true;
            this.rbtn_hd.Location = new System.Drawing.Point(432, 136);
            this.rbtn_hd.Name = "rbtn_hd";
            this.rbtn_hd.Size = new System.Drawing.Size(82, 19);
            this.rbtn_hd.TabIndex = 30;
            this.rbtn_hd.TabStop = true;
            this.rbtn_hd.Text = "Hoạt động";
            this.rbtn_hd.UseVisualStyleBackColor = true;
            // 
            // rbtn_khd
            // 
            this.rbtn_khd.AutoSize = true;
            this.rbtn_khd.Location = new System.Drawing.Point(521, 137);
            this.rbtn_khd.Name = "rbtn_khd";
            this.rbtn_khd.Size = new System.Drawing.Size(118, 19);
            this.rbtn_khd.TabIndex = 31;
            this.rbtn_khd.TabStop = true;
            this.rbtn_khd.Text = "Không hoạt động";
            this.rbtn_khd.UseVisualStyleBackColor = true;
            // 
            // cmbx_loaidv
            // 
            this.cmbx_loaidv.AutoCompleteCustomSource.AddRange(new string[] {
            "Tất cả"});
            this.cmbx_loaidv.FormattingEnabled = true;
            this.cmbx_loaidv.Location = new System.Drawing.Point(6, 14);
            this.cmbx_loaidv.Name = "cmbx_loaidv";
            this.cmbx_loaidv.Size = new System.Drawing.Size(212, 23);
            this.cmbx_loaidv.TabIndex = 33;
            this.cmbx_loaidv.Text = "Lọc theo loại dịch vụ";
            this.cmbx_loaidv.SelectedValueChanged += new System.EventHandler(this.cmbx_loaidv_SelectedValueChanged);
            // 
            // grbx_chucnang
            // 
            this.grbx_chucnang.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbx_chucnang.Controls.Add(this.btn_add);
            this.grbx_chucnang.Controls.Add(this.btn_edit);
            this.grbx_chucnang.Controls.Add(this.btn_load);
            this.grbx_chucnang.Location = new System.Drawing.Point(644, 309);
            this.grbx_chucnang.Name = "grbx_chucnang";
            this.grbx_chucnang.Size = new System.Drawing.Size(228, 122);
            this.grbx_chucnang.TabIndex = 35;
            this.grbx_chucnang.TabStop = false;
            this.grbx_chucnang.Text = "Chức năng";
            // 
            // grbx_loc
            // 
            this.grbx_loc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grbx_loc.Controls.Add(this.txt_tk);
            this.grbx_loc.Controls.Add(this.cmbx_loctt);
            this.grbx_loc.Controls.Add(this.cmbx_loaidv);
            this.grbx_loc.Controls.Add(this.btn_TK);
            this.grbx_loc.Location = new System.Drawing.Point(644, 149);
            this.grbx_loc.Name = "grbx_loc";
            this.grbx_loc.Size = new System.Drawing.Size(228, 154);
            this.grbx_loc.TabIndex = 36;
            this.grbx_loc.TabStop = false;
            this.grbx_loc.Text = "Lọc";
            // 
            // cmbx_loctt
            // 
            this.cmbx_loctt.AutoCompleteCustomSource.AddRange(new string[] {
            "Tất cả"});
            this.cmbx_loctt.FormattingEnabled = true;
            this.cmbx_loctt.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cmbx_loctt.Location = new System.Drawing.Point(6, 41);
            this.cmbx_loctt.Name = "cmbx_loctt";
            this.cmbx_loctt.Size = new System.Drawing.Size(212, 23);
            this.cmbx_loctt.TabIndex = 35;
            this.cmbx_loctt.Text = "Lọc theo trạng thái";
            this.cmbx_loctt.SelectedValueChanged += new System.EventHandler(this.cmbx_loctt_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(644, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Loại dịch vụ:";
            // 
            // cmbx_LoaiDichVu
            // 
            this.cmbx_LoaiDichVu.AutoCompleteCustomSource.AddRange(new string[] {
            "Tất cả"});
            this.cmbx_LoaiDichVu.FormattingEnabled = true;
            this.cmbx_LoaiDichVu.Location = new System.Drawing.Point(644, 110);
            this.cmbx_LoaiDichVu.Name = "cmbx_LoaiDichVu";
            this.cmbx_LoaiDichVu.Size = new System.Drawing.Size(218, 23);
            this.cmbx_LoaiDichVu.TabIndex = 36;
            this.cmbx_LoaiDichVu.Text = "Chọn loại dịch vụ";
            // 
            // Frm_QLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbx_LoaiDichVu);
            this.Controls.Add(this.grbx_loc);
            this.Controls.Add(this.grbx_chucnang);
            this.Controls.Add(this.rbtn_khd);
            this.Controls.Add(this.rbtn_hd);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Quaylai);
            this.Controls.Add(this.dgrv_qldichvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_hienthima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenDV);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_QLDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý dịch vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QLDichVu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_qldichvu)).EndInit();
            this.grbx_chucnang.ResumeLayout(false);
            this.grbx_loc.ResumeLayout(false);
            this.grbx_loc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_load;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Button btn_TK;
        public System.Windows.Forms.TextBox txt_tk;
        public System.Windows.Forms.Button btn_Quaylai;
        public System.Windows.Forms.DataGridView dgrv_qldichvu;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Label lbl_hienthima;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_TenDV;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_DonGia;
        public System.Windows.Forms.RadioButton rbtn_hd;
        public System.Windows.Forms.RadioButton rbtn_khd;
        public System.Windows.Forms.ComboBox cmbx_loaidv;
        public System.Windows.Forms.GroupBox grbx_chucnang;
        public System.Windows.Forms.GroupBox grbx_loc;
        public System.Windows.Forms.ComboBox cmbx_loctt;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbx_LoaiDichVu;
    }
}