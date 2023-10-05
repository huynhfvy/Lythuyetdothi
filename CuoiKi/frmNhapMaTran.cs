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
using System.IO;

namespace CuoiKi
{
    public partial class frmNhapMaTran : Form
    {
        Matrix matrix = new Matrix();
        public frmNhapMaTran()
        {
            InitializeComponent();
        }

        private void NhapMaTran_Load(object sender, EventArgs e)
        {
            // ẩn các button khi chưa nhập dữ liệu
            btnDuyetRong.Enabled = btnDuyetSau.Enabled = btnTimLienThong.Enabled = false;
            btnDraw.Enabled = false;
            cboDinhBatDau.Items.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu1 = new frmMenu();
            menu1.Show();
            
        }
        int numberOfFileCreated = 1;
        private void btnNhapXong_Click(object sender, EventArgs e)
        {
            try
            {
                // Làm trống matrix trước khi load dữ liệu mới vào matrix
                matrix = new Matrix();

                // viết dữ liệu vào file text
                string dataInput = txtNhapMaTran.Text;
                string path = Application.StartupPath + "\\nhaptubanphim" + numberOfFileCreated++ + ".txt";
                File.WriteAllText(path, dataInput);

                // load dữ liệu vào matrix
                matrix.LoadAdjacencyMatrix(path);

                // in ra textbox
                txtNhapMaTran.Text = matrix.Print();

                // hiện các button
                btnDuyetRong.Enabled = btnDuyetSau.Enabled = btnTimLienThong.Enabled = true;
                btnDraw.Enabled = true;

                // load các đỉnh vào combobox để chọn
                cboDinhBatDau.Items.Clear();
                for (int i = 0; i < matrix._vertices; i++)
                {
                    cboDinhBatDau.Items.Add(i.ToString());
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimLienThong_Click(object sender, EventArgs e)
        {
            //txtNhapMaTran.Text = "";
            ConnectedComponents cc = new ConnectedComponents(matrix);
            cc.connectedComponents();
            txtKetQua.Text = cc.Print();
        }

        private void btnDuyetRong_Click(object sender, EventArgs e)
        {
            if (cboDinhBatDau.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đỉnh bắt đầu!", "Thông báo.", MessageBoxButtons.OK);
                return;
            }
            //txtNhapMaTran.Text = "";
            BFS bfs = new BFS(matrix);
            int vertice = int.Parse(cboDinhBatDau.SelectedItem.ToString());
            bfs.GraphBrowsing_BFS(vertice);
            txtKetQua.Text = bfs.Print();
        }

        private void btnDuyetSau_Click(object sender, EventArgs e)
        {
            if (cboDinhBatDau.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đỉnh bắt đầu!", "Thông báo.", MessageBoxButtons.OK);
                return;
            }
            //txtNhapMaTran.Text = "";
            DFS dfs = new DFS(matrix);
            int vertice = int.Parse(cboDinhBatDau.SelectedItem.ToString());
            dfs.GraphBrowsing_DFS(vertice);
            txtKetQua.Text = dfs.Print();
        }

        private void cboDinhBatDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grpNhapMaTran_Enter(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            frmDraw draw = new frmDraw(matrix._vertices, matrix._matrix);
            draw.Show();  
        }

        private void frmNhapMaTran_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnMenu_Click(sender, e);
        }

        private void txtNhapMaTran_TextChanged(object sender, EventArgs e)
        {
            cboDinhBatDau.SelectedItem = null;
            txtKetQua.Text = "Kết quả: ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
