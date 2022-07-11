
namespace _3_GUI_QLNT
{
    partial class Frm_Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_TaiKhoan = new System.Windows.Forms.TextBox();
            this.tbx_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_DangKi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_QuenMk = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(119, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÀ TRỌ";
            // 
            // tbx_TaiKhoan
            // 
            this.tbx_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_TaiKhoan.Location = new System.Drawing.Point(90, 128);
            this.tbx_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_TaiKhoan.MaximumSize = new System.Drawing.Size(298, 31);
            this.tbx_TaiKhoan.MinimumSize = new System.Drawing.Size(298, 31);
            this.tbx_TaiKhoan.Multiline = true;
            this.tbx_TaiKhoan.Name = "tbx_TaiKhoan";
            this.tbx_TaiKhoan.Size = new System.Drawing.Size(298, 31);
            this.tbx_TaiKhoan.TabIndex = 1;
            this.tbx_TaiKhoan.Leave += new System.EventHandler(this.tbx_TaiKhoan_Leave);
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_MatKhau.Location = new System.Drawing.Point(90, 188);
            this.tbx_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_MatKhau.MaximumSize = new System.Drawing.Size(298, 31);
            this.tbx_MatKhau.MinimumSize = new System.Drawing.Size(298, 31);
            this.tbx_MatKhau.Multiline = true;
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.Size = new System.Drawing.Size(298, 31);
            this.tbx_MatKhau.TabIndex = 2;
            this.tbx_MatKhau.TextChanged += new System.EventHandler(this.tbx_MatKhau_TextChanged);
            this.tbx_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_MatKhau_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài Khoản (Email)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(90, 254);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(299, 37);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_DangKi
            // 
            this.btn_DangKi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_DangKi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DangKi.Location = new System.Drawing.Point(90, 336);
            this.btn_DangKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangKi.Name = "btn_DangKi";
            this.btn_DangKi.Size = new System.Drawing.Size(299, 37);
            this.btn_DangKi.TabIndex = 6;
            this.btn_DangKi.Text = "Thoát";
            this.btn_DangKi.UseVisualStyleBackColor = false;
            this.btn_DangKi.Click += new System.EventHandler(this.btn_DangKi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "-----------Hoặc----------";
            // 
            // lbl_QuenMk
            // 
            this.lbl_QuenMk.AutoSize = true;
            this.lbl_QuenMk.Location = new System.Drawing.Point(292, 226);
            this.lbl_QuenMk.Name = "lbl_QuenMk";
            this.lbl_QuenMk.Size = new System.Drawing.Size(89, 15);
            this.lbl_QuenMk.TabIndex = 9;
            this.lbl_QuenMk.TabStop = true;
            this.lbl_QuenMk.Text = "Quên mật khẩu";
            this.lbl_QuenMk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_QuenMk_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 435);
            this.Controls.Add(this.lbl_QuenMk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DangKi);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MatKhau);
            this.Controls.Add(this.tbx_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbx_TaiKhoan;
        public System.Windows.Forms.TextBox tbx_MatKhau;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_Login;
        public System.Windows.Forms.Button btn_DangKi;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.LinkLabel lbl_QuenMk;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}