using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
        private GeneticContext GenticContext { get; set; }
        public GEnZContext Context { get; set; }

        public Individual(GEnZContext context)
        {
            this.Context = context;
            this.GenticContext = context.GeneticContext;

            Genome = new List<Gene>();
            for (int i = 0; i < this.GenticContext.GenomeLength; i++)
            {
                Genome.Add(new Gene(Context));
            }
        }
        public Individual(GEnZContext context, Individual parent1, Individual parent2)
        {
            this.Context = context;
            this.GenticContext = context.GeneticContext;

            for (int i = 0; i < this.GenticContext.GenomeLength; i++)
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
            for (int i = 0; i < this.GenticContext.GenomeLength; i++)
            {
                if (GEnZContext.RandomFloat() < this.GenticContext.MutationRate)
                {
                    Genome[i] = new Gene(Context);
                }
            }
        }
        private Bitmap? DrawPictureOfIndividual()
        {
            Bitmap bmp = new Bitmap(Context.OriginalPictureImg.Width, Context.OriginalPictureImg.Height);
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
            var diff = CalculateDifferenceSum(PictureOfIndividual, Context.OriginalPictureBmp);
            //double diff = FrmMain.IC.CompareImages(PictureOfIndividual, FrmMain.Context.OriginalPictureBmp);

            var illness = diff / (
                                    Context.OriginalPictureBmp.Width *
                                    Context.OriginalPictureBmp.Height * 255 * 3
                                 );
            return 1 - illness;
        }

        public unsafe double CalculateDifferenceSum(Bitmap image1, Bitmap image2)
        {
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                throw new ArgumentException("Images must have the same dimensions.");
            }

            BitmapData bData1 = image1.LockBits(new Rectangle(0, 0, image1.Width, image1.Height), ImageLockMode.ReadOnly, image1.PixelFormat);
            BitmapData bData2 = image2.LockBits(new Rectangle(0, 0, image2.Width, image2.Height), ImageLockMode.ReadOnly, image2.PixelFormat);

            int bytesPerPixel = Image.GetPixelFormatSize(image1.PixelFormat) / 8;
            int heightInPixels = bData1.Height;
            int widthInBytes = bData1.Width * bytesPerPixel;

            byte* scan0_1 = (byte*)bData1.Scan0.ToPointer();
            byte* scan0_2 = (byte*)bData2.Scan0.ToPointer();

            double differenceSum = 0;

            for (int y = 0; y < heightInPixels; y++)
            {
                byte* currentLine1 = scan0_1 + (y * bData1.Stride);
                byte* currentLine2 = scan0_2 + (y * bData2.Stride);

                for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                {
                    int blueDifference = Math.Abs(currentLine1[x] - currentLine2[x]);
                    int greenDifference = Math.Abs(currentLine1[x + 1] - currentLine2[x + 1]);
                    int redDifference = Math.Abs(currentLine1[x + 2] - currentLine2[x + 2]);

                    differenceSum += blueDifference + greenDifference + redDifference;

                    // If the pixel format includes an alpha channel, handle it too
                    if (bytesPerPixel == 4)
                    {
                        int alphaDifference = Math.Abs(currentLine1[x + 3] - currentLine2[x + 3]);
                        differenceSum += alphaDifference;
                    }
                }
            }

            image1.UnlockBits(bData1);
            image2.UnlockBits(bData2);

            return differenceSum;
        }
        
        private double CalculateDifference2(Bitmap img1, Bitmap img2)
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
