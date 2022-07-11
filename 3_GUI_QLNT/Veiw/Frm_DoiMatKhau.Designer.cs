
namespace _3_GUI_QLNT.Veiw
{
    partial class Frm_DoiMatKhau
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_MatKhau2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DangKi = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MatKhau = new System.Windows.Forms.TextBox();
            this.tbx_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(95, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mật khẩu mới";
            // 
            // tbx_MatKhau2
            // 
            this.tbx_MatKhau2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_MatKhau2.Location = new System.Drawing.Point(95, 280);
            this.tbx_MatKhau2.MaximumSize = new System.Drawing.Size(340, 40);
            this.tbx_MatKhau2.MinimumSize = new System.Drawing.Size(340, 40);
            this.tbx_MatKhau2.Multiline = true;
            this.tbx_MatKhau2.Name = "tbx_MatKhau2";
            this.tbx_MatKhau2.Size = new System.Drawing.Size(340, 40);
            this.tbx_MatKhau2.TabIndex = 31;
            this.tbx_MatKhau2.TextChanged += new System.EventHandler(this.tbx_MatKhau2_TextChanged);
            this.tbx_MatKhau2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_MatKhau2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "-----------Hoặc----------";
            // 
            // btn_DangKi
            // 
            this.btn_DangKi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_DangKi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DangKi.Location = new System.Drawing.Point(95, 349);
            this.btn_DangKi.Name = "btn_DangKi";
            this.btn_DangKi.Size = new System.Drawing.Size(342, 49);
            this.btn_DangKi.TabIndex = 29;
            this.btn_DangKi.Text = "Đổi mật khẩu";
            this.btn_DangKi.UseVisualStyleBackColor = false;
            this.btn_DangKi.Click += new System.EventHandler(this.btn_DangKi_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(95, 456);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(342, 49);
            this.btn_Thoat.TabIndex = 28;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(95, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tài Khoản (Email)";
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_MatKhau.Location = new System.Drawing.Point(95, 206);
            this.tbx_MatKhau.MaximumSize = new System.Drawing.Size(340, 40);
            this.tbx_MatKhau.MinimumSize = new System.Drawing.Size(340, 40);
            this.tbx_MatKhau.Multiline = true;
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.Size = new System.Drawing.Size(340, 40);
            this.tbx_MatKhau.TabIndex = 25;
            this.tbx_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_MatKhau_KeyPress);
            // 
            // tbx_TaiKhoan
            // 
            this.tbx_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_TaiKhoan.Location = new System.Drawing.Point(95, 132);
            this.tbx_TaiKhoan.MaximumSize = new System.Drawing.Size(340, 40);
            this.tbx_TaiKhoan.MinimumSize = new System.Drawing.Size(340, 40);
            this.tbx_TaiKhoan.Multiline = true;
            this.tbx_TaiKhoan.Name = "tbx_TaiKhoan";
            this.tbx_TaiKhoan.Size = new System.Drawing.Size(340, 40);
            this.tbx_TaiKhoan.TabIndex = 24;
            this.tbx_TaiKhoan.Leave += new System.EventHandler(this.tbx_TaiKhoan_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(158, 35);
            this.label1.MaximumSize = new System.Drawing.Size(400, 50);
            this.label1.MinimumSize = new System.Drawing.Size(400, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 23;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 593);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_MatKhau2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DangKi);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MatKhau);
            this.Controls.Add(this.tbx_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_MatKhau2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DangKi;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_MatKhau;
        private System.Windows.Forms.TextBox tbx_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}