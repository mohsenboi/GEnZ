using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEnZ.GEnZ.GenticAlgorithm
{
    public class Gene
    {
        public int n_vertices { get; set; }
        public List<Point> vertices { get; set; }

        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        public Gene()
        {
            n_vertices = GEnZContext.RandomInt(3, FrmMain.Context.GeneticContext.MaxVertices);
            vertices = new List<Point>();

            R = GEnZContext.RandomInt(0, 255);
            G = GEnZContext.RandomInt(0, 255);
            B = GEnZContext.RandomInt(0, 255);
            A = GEnZContext.RandomInt(0, 255);

            for (int i = 0; i < n_vertices; i++)
            {
                var vertex = new Point(
                    GEnZContext.RandomInt(-10, FrmMain.Context.OriginalPictureImg.Width + 10), 
                    GEnZContext.RandomInt(-10, FrmMain.Context.OriginalPictureImg.Height + 10)
                );
                vertices.Add(vertex);
            }
        }
        
    }
}
