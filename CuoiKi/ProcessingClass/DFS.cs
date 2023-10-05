using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi
{
    internal class DFS
    {
        Matrix matrix; // Ma trận kề
        bool[] visited; // Lưu vết
        List<int> result; // Kết quả duyệt DFS

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
        public List<int> _result
        {
            get { return result; }
            set { result = value; }
        }

        /// <summary>
        /// Constructor khởi tạo, sao chép
        /// </summary>
        
        public DFS()
        {
            matrix = new Matrix();
            visited = new bool[0];
            result = new List<int>();
        }
        public DFS(Matrix matrix)
        {
            this.matrix = matrix;
            this.visited = new bool[matrix._vertices];
            this.result = new List<int>();
        }
        public DFS(DFS dfs)
        {
            matrix = dfs.matrix;
            visited = dfs.visited;
            result = dfs.result;
        }

        /// <summary>
        /// Duyệt đồ thị DFS
        /// startVertex : Đỉnh bắt đầu
        /// </summary>

        public void GraphBrowsing_DFS(int startVertex)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < matrix._vertices; i++)
            {
                visited[i] = false;
            }

            visited[startVertex] =true; // Đánh dấu đỉnh đã được duyệt
            stack.Push(startVertex); 
            result.Add(startVertex);

            while (stack.Any())
            {
                int currVertex = stack.Peek(); //Lấy đỉnh hiện tại
                List<int> vList = new List<int>();

                // Tìm một đỉnh chưa duyệt liên thông với đỉnh hiện tại
                for (int i = 0; i < matrix._vertices; i++)
                {
                    if (matrix._matrix[currVertex][i] == 1 && visited[i] == false)
                    {
                        vList.Add(i);
                        break;
                    }
                }

                if (vList.Count == 0) //Nếu không còn đỉnh nào để tiếp tục
                {
                    stack.Pop(); //Loại đỉnh ra khỏi stack
                }
                else
                {
                    stack.Push(vList[0]); // Thêm đỉnh vào stack
                    visited[vList[0]] = true; // Đánh dấu đỉnh đã duyệt
                    result.Add(vList[0]); // Thêm đỉnh vào kết quả
                }
            }
        }

        // Trả về kết quả kiểu string
        public string Print()
        {
            string strResult = "Duyệt theo chiều sâu: ";
            if (result == null)
            {
                return "Đồ thị chưa được duyệt";
            }
            foreach (int i in result.ToArray())
            {
                strResult += i.ToString() + " ";
            }
            return strResult;
        }
    }
}
