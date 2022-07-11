
namespace _3_GUI_QLNT.Veiw
{
    partial class Frm_DoiTrangThai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoiTrangThai));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_doitt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.lbl_maphong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng trọ:";
            // 
            // btn_doitt
            // 
            this.btn_doitt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_doitt.Image = ((System.Drawing.Image)(resources.GetObject("btn_doitt.Image")));
            this.btn_doitt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doitt.Location = new System.Drawing.Point(119, 138);
            this.btn_doitt.Name = "btn_doitt";
            this.btn_doitt.Size = new System.Drawing.Size(88, 46);
            this.btn_doitt.TabIndex = 1;
            this.btn_doitt.Text = "Đổi TT";
            this.btn_doitt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_doitt.UseVisualStyleBackColor = true;
            this.btn_doitt.Click += new System.EventHandler(this.btn_doitt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái:";
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_trangthai.Location = new System.Drawing.Point(185, 53);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(107, 25);
            this.lbl_trangthai.TabIndex = 4;
            this.lbl_trangthai.Text = "Trạng thái:";
            // 
            // lbl_maphong
            // 
            this.lbl_maphong.AutoSize = true;
            this.lbl_maphong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_maphong.Location = new System.Drawing.Point(185, 9);
            this.lbl_maphong.Name = "lbl_maphong";
            this.lbl_maphong.Size = new System.Drawing.Size(141, 25);
            this.lbl_maphong.TabIndex = 3;
            this.lbl_maphong.Text = "Mã phòng trọ:";
            // 
            // Frm_DoiTrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.lbl_trangthai);
            this.Controls.Add(this.lbl_maphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_doitt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DoiTrangThai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi trạng thái phòng trọ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_DoiTrangThai_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_doitt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label lbl_maphong;
    }
}