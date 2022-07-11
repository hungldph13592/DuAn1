
namespace _3_GUI_QLNT.Veiw
{
    partial class frm_TaoHopDong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_thoihan = new System.Windows.Forms.TextBox();
            this.txt_tratruoc = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.btn_themHD = new System.Windows.Forms.Button();
            this.lbl_maNT = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_Sodt = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.lbl_que = new System.Windows.Forms.Label();
            this.lbl_NS = new System.Windows.Forms.Label();
            this.lbl_GT = new System.Windows.Forms.Label();
            this.lbl_gmail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_maPT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Người Thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD/CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê Quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm Sinh ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới Tính ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gmail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(35, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 182);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thời Hạn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ghi Chú";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Đợt Trả trước";
            // 
            // txt_thoihan
            // 
            this.txt_thoihan.Location = new System.Drawing.Point(513, 30);
            this.txt_thoihan.Name = "txt_thoihan";
            this.txt_thoihan.Size = new System.Drawing.Size(224, 23);
            this.txt_thoihan.TabIndex = 20;
            // 
            // txt_tratruoc
            // 
            this.txt_tratruoc.Location = new System.Drawing.Point(513, 92);
            this.txt_tratruoc.Name = "txt_tratruoc";
            this.txt_tratruoc.Size = new System.Drawing.Size(224, 23);
            this.txt_tratruoc.TabIndex = 21;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(513, 189);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(230, 168);
            this.txt_ghichu.TabIndex = 23;
            // 
            // btn_themHD
            // 
            this.btn_themHD.Location = new System.Drawing.Point(258, 566);
            this.btn_themHD.Name = "btn_themHD";
            this.btn_themHD.Size = new System.Drawing.Size(240, 42);
            this.btn_themHD.TabIndex = 25;
            this.btn_themHD.Text = "Tạo Hợp Đồng";
            this.btn_themHD.UseVisualStyleBackColor = true;
            this.btn_themHD.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_maNT
            // 
            this.lbl_maNT.AutoSize = true;
            this.lbl_maNT.Location = new System.Drawing.Point(178, 37);
            this.lbl_maNT.Name = "lbl_maNT";
            this.lbl_maNT.Size = new System.Drawing.Size(0, 15);
            this.lbl_maNT.TabIndex = 26;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(178, 73);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(0, 15);
            this.lbl_HoTen.TabIndex = 27;
            // 
            // lbl_Sodt
            // 
            this.lbl_Sodt.AutoSize = true;
            this.lbl_Sodt.Location = new System.Drawing.Point(178, 113);
            this.lbl_Sodt.Name = "lbl_Sodt";
            this.lbl_Sodt.Size = new System.Drawing.Size(0, 15);
            this.lbl_Sodt.TabIndex = 28;
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Location = new System.Drawing.Point(178, 147);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(0, 15);
            this.lbl_CCCD.TabIndex = 29;
            // 
            // lbl_que
            // 
            this.lbl_que.AutoSize = true;
            this.lbl_que.Location = new System.Drawing.Point(178, 183);
            this.lbl_que.Name = "lbl_que";
            this.lbl_que.Size = new System.Drawing.Size(0, 15);
            this.lbl_que.TabIndex = 30;
            // 
            // lbl_NS
            // 
            this.lbl_NS.AutoSize = true;
            this.lbl_NS.Location = new System.Drawing.Point(178, 225);
            this.lbl_NS.Name = "lbl_NS";
            this.lbl_NS.Size = new System.Drawing.Size(0, 15);
            this.lbl_NS.TabIndex = 31;
            // 
            // lbl_GT
            // 
            this.lbl_GT.AutoSize = true;
            this.lbl_GT.Location = new System.Drawing.Point(178, 264);
            this.lbl_GT.Name = "lbl_GT";
            this.lbl_GT.Size = new System.Drawing.Size(0, 15);
            this.lbl_GT.TabIndex = 32;
            // 
            // lbl_gmail
            // 
            this.lbl_gmail.AutoSize = true;
            this.lbl_gmail.Location = new System.Drawing.Point(178, 303);
            this.lbl_gmail.Name = "lbl_gmail";
            this.lbl_gmail.Size = new System.Drawing.Size(0, 15);
            this.lbl_gmail.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_gmail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_GT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_NS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_que);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_CCCD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_Sodt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_HoTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbl_maNT);
            this.groupBox2.Location = new System.Drawing.Point(41, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 349);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Người Thuê";
            // 
            // lbl_maPT
            // 
            this.lbl_maPT.AutoSize = true;
            this.lbl_maPT.Location = new System.Drawing.Point(74, 580);
            this.lbl_maPT.Name = "lbl_maPT";
            this.lbl_maPT.Size = new System.Drawing.Size(44, 15);
            this.lbl_maPT.TabIndex = 35;
            this.lbl_maPT.Text = "label21";
            // 
            // frm_TaoHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 620);
            this.Controls.Add(this.lbl_maPT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_themHD);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.txt_tratruoc);
            this.Controls.Add(this.txt_thoihan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_TaoHopDong";
            this.Text = "frm_TaoHopDong";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_themHD;
        private System.Windows.Forms.Label lbl_maNT;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_Sodt;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.Label lbl_que;
        private System.Windows.Forms.Label lbl_NS;
        private System.Windows.Forms.Label lbl_GT;
        private System.Windows.Forms.Label lbl_gmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_thoihan;
        private System.Windows.Forms.TextBox txt_tratruoc;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label lbl_maPT;
    }
}