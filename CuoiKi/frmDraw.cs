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
    public partial class frmDraw : Form
    {
        int vertices;
        List<List<int>> matrix;
        const int PicturePadding = 50;
        public frmDraw(int v, List<List<int>> m)
        {
            InitializeComponent();
            this.vertices = v;    
            this.matrix = m;
        }

        private List<List<int>> adj(List<List<int>> matrix)
        {
            List<List<int>> result = new List<List<int>> ();
            for (int i = 0; i < vertices; i++)
            {
                result.Add(new List<int>());
                for (int j = 0; j<vertices; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        result[i].Add(j);
                    }
                }
            }
            return result;
        }

        private void Draw_Load(object sender, EventArgs e)
        {
            GraphicsTools g = new GraphicsTools(1000, 500);
            List<Point> lstPointVertices;
            lstPointVertices = new Vector2D(this.vertices, this.picGraphics.Width - frmDraw.PicturePadding,
                                               this.picGraphics.Height - frmDraw.PicturePadding).getRandomPoint();
            List<List<int>> Adj = adj(matrix);
            picGraphics.Image = g.CreateGraphics(Adj, lstPointVertices);
        }
    }
}
