using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi
{
    internal class ConnectedComponents
    {
        Matrix matrix; // Ma trận kề
        bool[] visited; // Lưu vết
        List<List<int>> result; // Các đỉnh liên thông
        int number; // Số miền liên thông 

        /// <summary>
        /// Get-Set
        ///     _matrix
        ///     _visited
        ///     _result
        /// </summary>

        public Matrix _matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public bool[] _visited
        {
            get { return visited; }
            set { visited = value; }
        }
        public List<List<int>> _result
        {
            get { return result; }
            set { result = value; }
        }
        public int _number
        {
            get { return number; }
            set { number = value; }
        }

        /// <summary>
        /// Constructor khởi tạo, sao chép
        /// </summary>

        public ConnectedComponents()
        {
            matrix = new Matrix();
            visited = new bool[0];
            result = new List<List<int>>();
            number = 0;
        }
        public ConnectedComponents(Matrix matrix)
        {
            this.matrix = matrix;
            visited = new bool[matrix._vertices];
            result = new List<List<int>>();
            number = 0;
        }
        public ConnectedComponents(ConnectedComponents cc)
        {
            matrix = cc.matrix;
            visited = cc.visited;
            result = cc.result;
            number = cc.number;
        }

        /// <summary>
        /// Tìm thành phần liên thông bằng cách duyệt đồ thị DFS
        /// </summary>

        public void connectedComponents()
        {
            for (int v = 0; v<matrix._vertices; v++)
            {
                visited[v] = false;
            }
            for(int v = 0; v<matrix._vertices; v++)
            {
                if (!visited[v])
                {
                    DFS dfs = new DFS(matrix);
                    dfs.GraphBrowsing_DFS(v); // Duyệt đồ thị DFS
                    result.Add(dfs._result); // Thêm thành phần liên thông vào kết quả
                    number++; // Tăng thành phần liên thông
                    visited = dfs._visited; // Lưu các đỉnh đã duyệt
                }
            }
        }

        // Trả về ma trận kề kiểu string
        public string Print()
        {
            string strResult = "";
            int flag = 1;
            if (number == 1)
            {
                strResult = "Đồ thị có thành phần liên thông duy nhất là: \r\n";

                foreach (var i in result)
                {
                    foreach (int j in i)
                    {
                        strResult += j.ToString() + " ";
                    }
                }
                return strResult;
            }
            else
            {
                strResult = "Số thành phần liên thông: " + number + "\r\n";
            }
            foreach (var i in result)
            {

                strResult += "Thành phần liên thông thứ " + flag + " là: ";
                foreach (int j in i)
                {
                    strResult += j.ToString() + " ";
                }
                strResult += "\r\n";
                flag++;
            }
            return strResult;
        }
    }
}
