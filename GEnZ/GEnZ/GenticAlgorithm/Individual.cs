using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEnZ.GEnZ.GenticAlgorithm
{
    public class Individual
    {
        public List<Gene>? Genome { get; private set; } = new List<Gene>();
        public Bitmap PictureOfIndividual { get; set; }
        public double Fitness { get; set; }

        public Individual()
        {
            for (int i = 0; i < FrmMain.Context.GeneticContext.GenomeLength; i++)
            {
                Genome.Add(new Gene());
            }
        }
        public Individual(Individual parent1, Individual parent2)
        {
            for (int i = 0; i < FrmMain.Context.GeneticContext.GenomeLength; i++)
            {
                if (GEnZContext.RandomFloat() > 0.5f)
                {
                    Genome.Add(parent1.Genome[i]);
                }
                else
                {
                    Genome.Add(parent2.Genome[i]);
                }
            }
            Mutation();

            PictureOfIndividual = DrawPictureOfIndividual();
            Fitness = CalculateFitness();
        }

        private void Mutation()
        {
            for (int i = 0; i < Genome.Count; i++)
            {
                if (GEnZContext.RandomFloat() < FrmMain.Context.GeneticContext.MutationRate)
                {
                    Genome[i] = new Gene();
                }
            }
        }
        private Bitmap? DrawPictureOfIndividual()
        {
            Bitmap bmp = new Bitmap(FrmMain.Context.OriginalPictureImg.Width, FrmMain.Context.OriginalPictureImg.Height);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < Genome.Count; i++)
            {
                var p = Genome[i].vertices;
                Color c = Color.FromArgb(Genome[i].A, Genome[i].R, Genome[i].G, Genome[i].B);
                var b = new SolidBrush(c);
                g.FillPolygon(b, p.ToArray());
            }
            return bmp;
        }
        private double CalculateFitness()
        {
            var diff = CalculateDifference(PictureOfIndividual, FrmMain.Context.OriginalPictureBmp);
            var illness = diff / (
                                    FrmMain.Context.OriginalPictureBmp.Width * 
                                    FrmMain.Context.OriginalPictureBmp.Height * 255 * 3
                                 );
            return 1 - illness;
        }
        private double CalculateDifference(Bitmap img1, Bitmap img2)
        {
            double diff = 0;
            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    var color1 = img1.GetPixel(i, j);
                    var color2 = img2.GetPixel(i, j);

                    diff += (
                        Math.Abs(color1.A - color2.A) + 
                        Math.Abs(color1.R - color2.R) +
                        Math.Abs(color1.G - color2.G) +
                        Math.Abs(color1.B - color2.B)
                    );
                }
            }

            return diff;
        }
    }
}
