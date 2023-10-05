using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi
{
    internal class BFS
    {
        Matrix matrix; // Ma trận kề
        bool[] visited; // Lưu vết
        List<int> result; // Kết quả duyệt BFS

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

        public BFS()
        {
            matrix = new Matrix();
            visited = new bool[0];
            result = new List<int>();
        }
        public BFS(Matrix matrix)
        {
            this.matrix = matrix; 
            visited = new bool[matrix._vertices];
            result = new List<int>();
        }
        public BFS(BFS bfs)
        {
            matrix = bfs.matrix;
            visited = bfs.visited;
            result = bfs.result;
        }

        /// <summary>
        /// Duyệt đồ thị BFS
        /// startVertex : Đỉnh bắt đầu
        /// </summary>

        public void GraphBrowsing_BFS(int startVertex)
        {
            LinkedList<int> queue = new LinkedList<int>();

            for (int i =0; i<matrix._vertices; i++)
            {
                visited[i] = false;
            }

            visited[startVertex] = true; // Đánh dấu đỉnh đầu tiên
            queue.AddLast(startVertex);

            while (queue.Any())
            {
                int currVertex = queue.First();
                result.Add(currVertex); // Thêm đỉnh đã duyệt vào kết quả
                queue.RemoveFirst();

                // Duyệt các đỉnh liên thông với đỉnh hiện tại
                List<int> vList = new List<int>(matrix._matrix[currVertex]);

                if (vList != null)
                {
                    for (int i = 0;i < matrix._vertices; i ++)
                    {
                        if (vList[i]==1 &&!visited[i])
                        {
                            visited[i] = true;
                            queue.AddLast(i);
                        }     
                    }
                }
            }
        }

        // Trả về kết quả kiểu string
        public string Print()
        {
            string strResult = "Duyệt theo chiều rộng: ";
            if (result == null)
            {
                return "Đồ thị chưa được duyệt";
            }
            foreach (int i in result.ToArray())
            {
                strResult += i.ToString() +" ";
            }
            return strResult;
        }
    }
}
