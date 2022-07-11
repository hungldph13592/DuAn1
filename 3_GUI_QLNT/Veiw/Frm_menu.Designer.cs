
namespace _3_GUI_QLNT.Veiw
{
    partial class Frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu));
            this.btn_doitt = new System.Windows.Forms.Button();
            this.btn_chucnang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_doitt
            // 
            this.btn_doitt.Location = new System.Drawing.Point(12, 7);
            this.btn_doitt.Name = "btn_doitt";
            this.btn_doitt.Size = new System.Drawing.Size(160, 43);
            this.btn_doitt.TabIndex = 0;
            this.btn_doitt.Text = "Sửa trạng thái phòng";
            this.btn_doitt.UseVisualStyleBackColor = true;
            this.btn_doitt.Click += new System.EventHandler(this.btn_doitt_Click);
            // 
            // btn_chucnang
            // 
            this.btn_chucnang.Location = new System.Drawing.Point(12, 56);
            this.btn_chucnang.Name = "btn_chucnang";
            this.btn_chucnang.Size = new System.Drawing.Size(160, 43);
            this.btn_chucnang.TabIndex = 1;
            this.btn_chucnang.Text = "Chức năng khác";
            this.btn_chucnang.UseVisualStyleBackColor = true;
            this.btn_chucnang.Click += new System.EventHandler(this.btn_chucnang_Click);
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 111);
            this.Controls.Add(this.btn_chucnang);
            this.Controls.Add(this.btn_doitt);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu tính năng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_doitt;
        private System.Windows.Forms.Button btn_chucnang;
    }
}