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

        public Gene(GEnZContext context)
        {
            n_vertices = GEnZContext.RandomInt(3, context.GeneticContext.MaxVertices);
            vertices = new List<Point>();

            R = GEnZContext.RandomInt(context.ColorRanges[0].X, context.ColorRanges[0].Y);
            G = GEnZContext.RandomInt(context.ColorRanges[1].X, context.ColorRanges[1].Y);
            B = GEnZContext.RandomInt(context.ColorRanges[2].X, context.ColorRanges[2].Y);
            A = GEnZContext.RandomInt(0, 255);

            for (int i = 0; i < n_vertices; i++)
            {
                var vertex = new Point(
                    GEnZContext.RandomInt(-10, context.OriginalPictureImg.Width + 10), 
                    GEnZContext.RandomInt(-10, context.OriginalPictureImg.Height + 10)
                );
                vertices.Add(vertex);
            }
        }
        
    }
}
