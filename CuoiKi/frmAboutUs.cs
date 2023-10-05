using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi
{
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
                GraphicsPath path = new GraphicsPath();
                int radius = 20; // Độ cong của góc
                int diameter = radius * 2;
                // Góc trên cùng bên trái
                path.AddArc(new Rectangle(0, 0, diameter, diameter), 180, 90);

                // Góc trên cùng bên phải
                path.AddArc(new Rectangle(pictureBox1.Width - diameter, 0, diameter, diameter), 270, 90);

                // Góc dưới cùng bên phải
                path.AddArc(new Rectangle(pictureBox1.Width - diameter, pictureBox1.Height - diameter, diameter, diameter), 0, 90);

                // Góc dưới cùng bên trái
                path.AddArc(new Rectangle(0, pictureBox1.Height - diameter, diameter, diameter), 90, 90);

                path.CloseAllFigures();

                pictureBox1.Region = new Region(path);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void frmAboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
