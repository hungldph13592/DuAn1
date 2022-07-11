
namespace _3_GUI_QLNT.Veiw
{
    partial class Frm_QLLoaiDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QLLoaiDV));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenLoaiDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_hienthima = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dgrv_qldichvu = new System.Windows.Forms.DataGridView();
            this.btn_Quaylai = new System.Windows.Forms.Button();
            this.txt_tkldv = new System.Windows.Forms.TextBox();
            this.btn_TK = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_qldichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại dịch vụ:";
            // 
            // txt_TenLoaiDV
            // 
            this.txt_TenLoaiDV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenLoaiDV.Location = new System.Drawing.Point(169, 132);
            this.txt_TenLoaiDV.Name = "txt_TenLoaiDV";
            this.txt_TenLoaiDV.Size = new System.Drawing.Size(292, 29);
            this.txt_TenLoaiDV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại dịch vụ:";
            // 
            // lbl_hienthima
            // 
            this.lbl_hienthima.AutoSize = true;
            this.lbl_hienthima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hienthima.Location = new System.Drawing.Point(169, 91);
            this.lbl_hienthima.Name = "lbl_hienthima";
            this.lbl_hienthima.Size = new System.Drawing.Size(0, 21);
            this.lbl_hienthima.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(469, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 51);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(210, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quản lý loại dịch vụ";
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(572, 281);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 50);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dgrv_qldichvu
            // 
            this.dgrv_qldichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrv_qldichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_qldichvu.Location = new System.Drawing.Point(33, 178);
            this.dgrv_qldichvu.Name = "dgrv_qldichvu";
            this.dgrv_qldichvu.RowTemplate.Height = 25;
            this.dgrv_qldichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrv_qldichvu.Size = new System.Drawing.Size(428, 244);
            this.dgrv_qldichvu.TabIndex = 8;
            this.dgrv_qldichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_qldichvu_CellClick);
            // 
            // btn_Quaylai
            // 
            this.btn_Quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_Quaylai.Image")));
            this.btn_Quaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Quaylai.Location = new System.Drawing.Point(572, 12);
            this.btn_Quaylai.Name = "btn_Quaylai";
            this.btn_Quaylai.Size = new System.Drawing.Size(100, 50);
            this.btn_Quaylai.TabIndex = 9;
            this.btn_Quaylai.Text = "Quay lại";
            this.btn_Quaylai.UseVisualStyleBackColor = true;
            this.btn_Quaylai.Click += new System.EventHandler(this.btn_Quaylai_Click);
            // 
            // txt_tkldv
            // 
            this.txt_tkldv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tkldv.Location = new System.Drawing.Point(467, 178);
            this.txt_tkldv.Name = "txt_tkldv";
            this.txt_tkldv.PlaceholderText = "Nhập tên để tìm kiếm";
            this.txt_tkldv.Size = new System.Drawing.Size(216, 29);
            this.txt_tkldv.TabIndex = 10;
            this.txt_tkldv.Tag = "";
            // 
            // btn_TK
            // 
            this.btn_TK.Image = ((System.Drawing.Image)(resources.GetObject("btn_TK.Image")));
            this.btn_TK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TK.Location = new System.Drawing.Point(469, 213);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(205, 62);
            this.btn_TK.TabIndex = 11;
            this.btn_TK.Text = "Tìm kiếm";
            this.btn_TK.UseVisualStyleBackColor = true;
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(469, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 15);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dự án 1_Phần mềm quản lý nhà trọ";
            // 
            // btn_load
            // 
            this.btn_load.Image = ((System.Drawing.Image)(resources.GetObject("btn_load.Image")));
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.Location = new System.Drawing.Point(467, 337);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(205, 62);
            this.btn_load.TabIndex = 13;
            this.btn_load.Text = "Load danh sách";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Frm_QLLoaiDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_TK);
            this.Controls.Add(this.txt_tkldv);
            this.Controls.Add(this.btn_Quaylai);
            this.Controls.Add(this.dgrv_qldichvu);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_hienthima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenLoaiDV);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_QLLoaiDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý loại dịch vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QLLoaiDV_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_qldichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_TenLoaiDV;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_hienthima;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.DataGridView dgrv_qldichvu;
        public System.Windows.Forms.Button btn_Quaylai;
        public System.Windows.Forms.TextBox txt_tkldv;
        public System.Windows.Forms.Button btn_TK;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Button btn_load;
    }
}