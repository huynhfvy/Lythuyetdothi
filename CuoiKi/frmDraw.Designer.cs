namespace CuoiKi
{
    partial class frmDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDraw));
            this.picGraphics = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // picGraphics
            // 
            this.picGraphics.Location = new System.Drawing.Point(14, 16);
            this.picGraphics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picGraphics.Name = "picGraphics";
            this.picGraphics.Size = new System.Drawing.Size(1101, 646);
            this.picGraphics.TabIndex = 0;
            this.picGraphics.TabStop = false;
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1128, 678);
            this.Controls.Add(this.picGraphics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Draw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGraphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGraphics;
    }
}