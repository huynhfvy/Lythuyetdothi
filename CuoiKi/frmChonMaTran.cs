using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi
{
    public partial class frmChonMaTran : Form
    {
        Matrix matrix = new Matrix();
        public frmChonMaTran()
        {
            InitializeComponent();
        }

        private void ChonMaTran_Load(object sender, EventArgs e)
        {
            // ẩn các button khi chưa nhập dữ liệu
            btnDuyetRong.Enabled = btnDuyetSau.Enabled = btnTimLienThong.Enabled = false;
            btnDraw.Enabled = false;
            txtKetQua.Text = "Kết quả: ";
        }

        private void ChonMaTran_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu1 = new frmMenu();
            menu1.Show();
            //menu1.BorderStyle = BorderStyle.None;

        }
        int somatran = 1;
        private void cboDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Làm trống matrix trước khi load dữ liệu mới vào matrix
            matrix = new Matrix();
            cboDinhBatDau.SelectedItem = null;
            txtKetQua.Text = "";

            // tạo đường dẫn đến testcase được chọn
            string testcase = null;
            testcase = cboDS.SelectedItem.ToString();
            string path = Application.StartupPath + "\\" + testcase + ".txt";

            // load dữ liệu vào matrix
            matrix.LoadAdjacencyMatrix(path);

            // in ra textbox
            txtNhapMaTran.Text = matrix.Print();

            // hiện các button
            btnDuyetRong.Enabled = btnDuyetSau.Enabled = btnTimLienThong.Enabled = true;
            btnDraw.Enabled = true; 

            // thêm các đỉnh vào combobox để chọn
            cboDinhBatDau.Items.Clear();
            for (int i = 0; i < matrix._vertices; i++)
            {
                cboDinhBatDau.Items.Add(i.ToString());
            }
            txtKetQua.Text = "Kết quả: ";
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
            txtKetQua.Text = "Kết quả: ";
        }

        private void txtNhapMaTran_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpNhapMaTran_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            frmDraw draw = new frmDraw(matrix._vertices, matrix._matrix);
            draw.Show();       
        }

        private void frmChonMaTran_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnMenu_Click(sender, e);
        }

        private void btnNhapfile_Click(object sender, EventArgs e)
        {
            string path = "";

            // Làm trống matrix trước khi load dữ liệu mới vào matrix
            matrix = new Matrix();
            cboDinhBatDau.SelectedItem = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            matrix.LoadAdjacencyMatrix(openFileDialog1.FileName);
            // in ra textbox
            txtNhapMaTran.Text = matrix.Print();

            // hiện các button
            btnDuyetRong.Enabled = btnDuyetSau.Enabled = btnTimLienThong.Enabled = true;
            btnDraw.Enabled = true;

            // thêm các đỉnh vào combobox để chọn
            cboDinhBatDau.Items.Clear();
            for (int i = 0; i < matrix._vertices; i++)
            {
                cboDinhBatDau.Items.Add(i.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
