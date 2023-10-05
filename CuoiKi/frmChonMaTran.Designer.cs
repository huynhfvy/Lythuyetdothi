namespace CuoiKi
{
    partial class frmChonMaTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonMaTran));
            this.btnDuyetSau = new System.Windows.Forms.Button();
            this.btnDuyetRong = new System.Windows.Forms.Button();
            this.btnTimLienThong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDinhBatDau = new System.Windows.Forms.ComboBox();
            this.cboDS = new System.Windows.Forms.ComboBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnNhapfile = new System.Windows.Forms.Button();
            this.txtNhapMaTran = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuyetSau
            // 
            this.btnDuyetSau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDuyetSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetSau.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetSau.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDuyetSau.Location = new System.Drawing.Point(673, 462);
            this.btnDuyetSau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDuyetSau.Name = "btnDuyetSau";
            this.btnDuyetSau.Size = new System.Drawing.Size(306, 100);
            this.btnDuyetSau.TabIndex = 4;
            this.btnDuyetSau.Text = "Duyệt theo chiều sâu";
            this.btnDuyetSau.UseVisualStyleBackColor = false;
            this.btnDuyetSau.Click += new System.EventHandler(this.btnDuyetSau_Click);
            // 
            // btnDuyetRong
            // 
            this.btnDuyetRong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDuyetRong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetRong.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetRong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDuyetRong.Location = new System.Drawing.Point(65, 462);
            this.btnDuyetRong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDuyetRong.Name = "btnDuyetRong";
            this.btnDuyetRong.Size = new System.Drawing.Size(306, 100);
            this.btnDuyetRong.TabIndex = 3;
            this.btnDuyetRong.Text = "Duyệt theo chiều rộng";
            this.btnDuyetRong.UseVisualStyleBackColor = false;
            this.btnDuyetRong.Click += new System.EventHandler(this.btnDuyetRong_Click);
            // 
            // btnTimLienThong
            // 
            this.btnTimLienThong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimLienThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimLienThong.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLienThong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTimLienThong.Location = new System.Drawing.Point(65, 281);
            this.btnTimLienThong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimLienThong.Name = "btnTimLienThong";
            this.btnTimLienThong.Size = new System.Drawing.Size(306, 100);
            this.btnTimLienThong.TabIndex = 2;
            this.btnTimLienThong.Text = "Tìm thành phần liên thông";
            this.btnTimLienThong.UseVisualStyleBackColor = false;
            this.btnTimLienThong.Click += new System.EventHandler(this.btnTimLienThong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(70, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đỉnh bắt đầu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(70, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Testcase mẫu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboDinhBatDau
            // 
            this.cboDinhBatDau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboDinhBatDau.FormattingEnabled = true;
            this.cboDinhBatDau.Location = new System.Drawing.Point(285, 174);
            this.cboDinhBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDinhBatDau.Name = "cboDinhBatDau";
            this.cboDinhBatDau.Size = new System.Drawing.Size(150, 28);
            this.cboDinhBatDau.TabIndex = 2;
            this.cboDinhBatDau.SelectedIndexChanged += new System.EventHandler(this.cboDinhBatDau_SelectedIndexChanged);
            // 
            // cboDS
            // 
            this.cboDS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboDS.FormattingEnabled = true;
            this.cboDS.Items.AddRange(new object[] {
            "Testcase1",
            "Testcase2",
            "Testcase3",
            "Testcase4",
            "Testcase5",
            "Testcase6",
            "Testcase7",
            "Testcase8",
            "Testcase9"});
            this.cboDS.Location = new System.Drawing.Point(285, 116);
            this.cboDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDS.Name = "cboDS";
            this.cboDS.Size = new System.Drawing.Size(218, 28);
            this.cboDS.TabIndex = 0;
            this.cboDS.SelectedIndexChanged += new System.EventHandler(this.cboDS_SelectedIndexChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(597, 614);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(442, 263);
            this.txtKetQua.TabIndex = 1;
            this.txtKetQua.Text = "Kết quả:";
            // 
            // btnNhapfile
            // 
            this.btnNhapfile.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapfile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNhapfile.Location = new System.Drawing.Point(568, 112);
            this.btnNhapfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhapfile.Name = "btnNhapfile";
            this.btnNhapfile.Size = new System.Drawing.Size(126, 39);
            this.btnNhapfile.TabIndex = 2;
            this.btnNhapfile.Text = "Nhập file";
            this.btnNhapfile.UseVisualStyleBackColor = false;
            this.btnNhapfile.Click += new System.EventHandler(this.btnNhapfile_Click);
            // 
            // txtNhapMaTran
            // 
            this.txtNhapMaTran.Location = new System.Drawing.Point(14, 614);
            this.txtNhapMaTran.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNhapMaTran.Multiline = true;
            this.txtNhapMaTran.Name = "txtNhapMaTran";
            this.txtNhapMaTran.Size = new System.Drawing.Size(442, 263);
            this.txtNhapMaTran.TabIndex = 1;
            this.txtNhapMaTran.TextChanged += new System.EventHandler(this.txtNhapMaTran_TextChanged);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDraw.Location = new System.Drawing.Point(673, 281);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(306, 100);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Vẽ đồ thị";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gluten SemiBold", 31F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(217, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(645, 91);
            this.label3.TabIndex = 10;
            this.label3.Text = "CHỌN MA TRẬN KỀ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmChonMaTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1085, 962);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.cboDinhBatDau);
            this.Controls.Add(this.txtNhapMaTran);
            this.Controls.Add(this.btnNhapfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDuyetSau);
            this.Controls.Add(this.btnDuyetRong);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnTimLienThong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChonMaTran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn ma trận kề";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChonMaTran_FormClosed);
            this.Load += new System.EventHandler(this.ChonMaTran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDuyetSau;
        private System.Windows.Forms.Button btnTimLienThong;
        private System.Windows.Forms.ComboBox cboDS;
        private System.Windows.Forms.TextBox txtNhapMaTran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDinhBatDau;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnNhapfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDuyetRong;
    }
}