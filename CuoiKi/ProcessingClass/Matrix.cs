
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Globalization;

namespace CuoiKi
{
    internal class Matrix
    {
        int vertices; //số đỉnh của đồ thị
        List<List<int>> matrix; //ma trận kề của đồ thị
        
        /// <summary>
        /// Get - Set
        ///     _vertices
        ///     _matrix
        /// </summary>

        public int _vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }
        public List<List<int>> _matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        /// <summary>
        /// Constructor khởi tạo, sao chép
        /// </summary>

        public Matrix()
        {
            vertices = 0;
            matrix = new List<List <int>>(0);
        }
        public Matrix(int vertices, List<List<int>> matrix)
        {
            this.vertices = vertices;
            this.matrix = matrix;
        }
        public Matrix(string Path)
        {
            vertices = 0;
            matrix = new List<List<int>>(0);
            LoadAdjacencyMatrix(Path);
        }
        public Matrix(Matrix m)
        {
            vertices = m.vertices;
            matrix = m.matrix;
        }

        /// <summary>
        /// Nhập ma trận từ file
        /// Path: đường dẫn file
        /// Cấu trúc file:
        /// Dòng đầu tiên là số đỉnh của đồ thị
        /// Dòng tiếp theo là ma trận kề của đồ thị
        /// </summary>
        
        public void LoadAdjacencyMatrix(string Path)
        {
            if (File.Exists(Path)) // Kiểm tra file có tồn tại 
            {
                StreamReader sr = new StreamReader(Path);
                try
                {
                    
                    string s = "";
                    string[] content = null;

                    // Lưu số đỉnh của đồ thị
                    if ((s = sr.ReadLine()) != null)
                        vertices = int.Parse(s.Trim());
                    else
                    {
                        MessageBox.Show("Nhập lỗi!\nKhông có dữ liệu.", "Thông báo", MessageBoxButtons.OK);
                        sr.Close();
                        matrix = null;
                        return;
                    }

                    // Lưu ma trận kề
                    for (int i=0; i<vertices; i++)
                    {
                        s = sr.ReadLine(); // Lưu giá trị đọc từ file
                        content = s.Trim().Split(' '); // Xóa khoảng trắng

                        List<int> temp = new List<int>(vertices); // Biến tạm để lưu từng dòng

                        for (int j = 0; j < content.Length; j ++)
                        {
                            // Kiểm tra dữ liệu nhập vào
                            if (content[j] != "1" && content[j] != "0" && content[j]!="") {
                                MessageBox.Show("Nhập lỗi!\nKhông phải ma trận kề.", "Thông báo", MessageBoxButtons.OK);
                                sr.Close();
                                matrix = null;
                                return;
                            }
                            else
                            {
                                while (content[j] == "")
                                {
                                    j++;
                                }
                                temp.Add(Convert.ToInt32(content[j]));
                            }
                        }
                        if (temp.Count != vertices)
                        {
                            MessageBox.Show("Nhập lỗi!\nKhông phải ma trận kề.", "Thông báo", MessageBoxButtons.OK);
                            sr.Close();
                            matrix = null;
                            return;
                        }
                        matrix.Add(temp); // Lưu dòng thứ i của ma trận
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK);
                    sr.Close();
                }
            }
            else
            {
                MessageBox.Show("Không mở được file!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        // Trả về ma trận kề kiểu string
        public string Print()
        {
            if (matrix == null)
            {
                return "Không có dữ liệu!";
            }
            string strResult = null;
            foreach(List<int> iRow in matrix.ToList()){
                foreach (int j in iRow.ToList())
                {
                    strResult = strResult + " " + j.ToString();
                }
                strResult += "\r\n";
            }
            return strResult;
        }
    }
}
