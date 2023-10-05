namespace CuoiKi
{
    partial class frmNhapMaTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapMaTran));
            this.btnNhapXong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDinhBatDau = new System.Windows.Forms.ComboBox();
            this.txtNhapMaTran = new System.Windows.Forms.TextBox();
            this.btnTimLienThong = new System.Windows.Forms.Button();
            this.btnDuyetRong = new System.Windows.Forms.Button();
            this.btnDuyetSau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNhapXong
            // 
            this.btnNhapXong.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapXong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapXong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNhapXong.Location = new System.Drawing.Point(443, 111);
            this.btnNhapXong.Name = "btnNhapXong";
            this.btnNhapXong.Size = new System.Drawing.Size(128, 40);
            this.btnNhapXong.TabIndex = 7;
            this.btnNhapXong.Text = "Nhập xong";
            this.btnNhapXong.UseVisualStyleBackColor = false;
            this.btnNhapXong.Click += new System.EventHandler(this.btnNhapXong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đỉnh bắt đầu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboDinhBatDau
            // 
            this.cboDinhBatDau.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboDinhBatDau.FormattingEnabled = true;
            this.cboDinhBatDau.Items.AddRange(new object[] {
            "Testcase1",
            "Testcase2",
            "Testcase3",
            "Testcase4",
            "Testcase5"});
            this.cboDinhBatDau.Location = new System.Drawing.Point(196, 111);
            this.cboDinhBatDau.Name = "cboDinhBatDau";
            this.cboDinhBatDau.Size = new System.Drawing.Size(201, 37);
            this.cboDinhBatDau.TabIndex = 7;
            this.cboDinhBatDau.SelectedIndexChanged += new System.EventHandler(this.cboDinhBatDau_SelectedIndexChanged);
            // 
            // txtNhapMaTran
            // 
            this.txtNhapMaTran.Location = new System.Drawing.Point(13, 425);
            this.txtNhapMaTran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapMaTran.Multiline = true;
            this.txtNhapMaTran.Name = "txtNhapMaTran";
            this.txtNhapMaTran.Size = new System.Drawing.Size(332, 245);
            this.txtNhapMaTran.TabIndex = 2;
            this.txtNhapMaTran.Text = "4\r\n0 1 1 0\r\n1 0 1 1\r\n0 1 0 0\r\n1 0 1 0";
            this.txtNhapMaTran.TextChanged += new System.EventHandler(this.txtNhapMaTran_TextChanged);
            // 
            // btnTimLienThong
            // 
            this.btnTimLienThong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimLienThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimLienThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimLienThong.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLienThong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTimLienThong.Location = new System.Drawing.Point(59, 201);
            this.btnTimLienThong.Name = "btnTimLienThong";
            this.btnTimLienThong.Size = new System.Drawing.Size(253, 76);
            this.btnTimLienThong.TabIndex = 3;
            this.btnTimLienThong.Text = "Tìm thành phần liên thông";
            this.btnTimLienThong.UseVisualStyleBackColor = false;
            this.btnTimLienThong.Click += new System.EventHandler(this.btnTimLienThong_Click);
            // 
            // btnDuyetRong
            // 
            this.btnDuyetRong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDuyetRong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDuyetRong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetRong.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetRong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDuyetRong.Location = new System.Drawing.Point(59, 317);
            this.btnDuyetRong.Name = "btnDuyetRong";
            this.btnDuyetRong.Size = new System.Drawing.Size(253, 80);
            this.btnDuyetRong.TabIndex = 4;
            this.btnDuyetRong.Text = "Duyệt theo chiều rộng";
            this.btnDuyetRong.UseVisualStyleBackColor = false;
            this.btnDuyetRong.Click += new System.EventHandler(this.btnDuyetRong_Click);
            // 
            // btnDuyetSau
            // 
            this.btnDuyetSau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDuyetSau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDuyetSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetSau.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetSau.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDuyetSau.Location = new System.Drawing.Point(443, 317);
            this.btnDuyetSau.Name = "btnDuyetSau";
            this.btnDuyetSau.Size = new System.Drawing.Size(253, 80);
            this.btnDuyetSau.TabIndex = 5;
            this.btnDuyetSau.Text = "Duyệt theo chiều sâu";
            this.btnDuyetSau.UseVisualStyleBackColor = false;
            this.btnDuyetSau.Click += new System.EventHandler(this.btnDuyetSau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDraw.Location = new System.Drawing.Point(443, 197);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(253, 80);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Vẽ đồ thị";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.White;
            this.txtKetQua.Location = new System.Drawing.Point(423, 425);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(338, 245);
            this.txtKetQua.TabIndex = 8;
            this.txtKetQua.Text = "Kết quả:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gluten SemiBold", 31F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 91);
            this.label1.TabIndex = 9;
            this.label1.Text = "NHẬP MA TRẬN KỀ";
            // 
            // frmNhapMaTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(785, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnNhapXong);
            this.Controls.Add(this.txtNhapMaTran);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboDinhBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDuyetSau);
            this.Controls.Add(this.btnDuyetRong);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnTimLienThong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhapMaTran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập ma trận kề";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhapMaTran_FormClosed);
            this.Load += new System.EventHandler(this.NhapMaTran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhapMaTran;
        private System.Windows.Forms.Button btnTimLienThong;
        private System.Windows.Forms.Button btnDuyetRong;
        private System.Windows.Forms.Button btnDuyetSau;
        private System.Windows.Forms.ComboBox cboDinhBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNhapXong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label1;
    }
}