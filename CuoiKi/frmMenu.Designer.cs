namespace CuoiKi
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNhapMaTran = new System.Windows.Forms.Button();
            this.btnChonMaTran = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cooper Black", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(365, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(666, 137);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Blue Girls";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnNhapMaTran
            // 
            this.btnNhapMaTran.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapMaTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapMaTran.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMaTran.ForeColor = System.Drawing.Color.SlateGray;
            this.btnNhapMaTran.Location = new System.Drawing.Point(434, 251);
            this.btnNhapMaTran.Name = "btnNhapMaTran";
            this.btnNhapMaTran.Size = new System.Drawing.Size(303, 100);
            this.btnNhapMaTran.TabIndex = 1;
            this.btnNhapMaTran.Text = "Nhập ma trận kề từ bàn phím";
            this.btnNhapMaTran.UseVisualStyleBackColor = false;
            this.btnNhapMaTran.Click += new System.EventHandler(this.btnNhapMaTran_Click);
            // 
            // btnChonMaTran
            // 
            this.btnChonMaTran.BackColor = System.Drawing.Color.Transparent;
            this.btnChonMaTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonMaTran.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMaTran.ForeColor = System.Drawing.Color.SlateGray;
            this.btnChonMaTran.Location = new System.Drawing.Point(434, 376);
            this.btnChonMaTran.Name = "btnChonMaTran";
            this.btnChonMaTran.Size = new System.Drawing.Size(303, 100);
            this.btnChonMaTran.TabIndex = 2;
            this.btnChonMaTran.Text = "Chọn ma trận kề có sẵn";
            this.btnChonMaTran.UseVisualStyleBackColor = false;
            this.btnChonMaTran.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(103, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1374, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm thành phần liên thông và \r\nduyệt đồ thị theo chiều rộng và duyệt theo chiều s" +
    "âu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(475, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Về chúng tôi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1160, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChonMaTran);
            this.Controls.Add(this.btnNhapMaTran);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(193)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ án cuối kỳ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu1_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNhapMaTran;
        private System.Windows.Forms.Button btnChonMaTran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}