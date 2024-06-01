using GEnZ.GEnZ;
using GEnZ.GEnZ.GenticAlgorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEnZ
{
    public partial class FrmMain : Form
    {
        public GEnZContext? Context;
        public static ImageCompartion IC;
        public GeneticContext GeneticContext;

        double m_mutationRate = 0;
        int m_populationSize = 0;
        int m_generations = 0;
        int m_genomeLength = 0;
        int m_maxVertices = 0;

        public FrmMain()
        {
            InitializeComponent();

            Context = new GEnZContext();
            IC = new ImageCompartion();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cmb_originalImageSizeMode.SelectedIndex = 1;
        }
        private void btn_loadOriginalImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*jpg;*jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    txt_origianlImagePath.Text = dialog.FileName;
                    Context.ClearContext();
                    Context.IsInitiated = true;

                    Context.OriginalPictureImg = Image.FromFile(dialog.FileName);
                    Context.OriginalPictureBmp = new Bitmap(Context.OriginalPictureImg);
                    Context.ColorRanges = CalculateColorRange(Context.OriginalPictureBmp);

                    pic_originalImage.Image = Context.OriginalPictureImg;
                }
            }
        }

        private void cmb_originalImageSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mode = cmb_originalImageSizeMode.Text;
            var items = Enum.GetNames(typeof(PictureBoxSizeMode)).ToList();
            var index = items.IndexOf(mode);
            if (index == 2)
                return;

            pic_originalImage.SizeMode = (PictureBoxSizeMode)index;
        }

        private void btn_geneticAlgorithmSettings_Click(object sender, EventArgs e)
        {
            var frm = new FrmGeneticAlgorithmSettings();
            frm.OnMutationRateChanged += (sender, args) =>
            {
                lbl_mutationRate.Text = $"Mutation Rate: {args}";
                m_mutationRate = args;
            };
            frm.OnPopulationSizeChanged += (sender, args) =>
            {
                lbl_populationSize.Text = $"Population Size: {args}";
                m_populationSize = args;
            };
            frm.OnGenerationsChanged += (sender, args) =>
            {
                lbl_generations.Text = $"Generations: {args}";
                m_generations = args;
            };
            frm.OnMaximumShapesChanged += (sender, args) =>
            {
                lbl_maximumShapes.Text = $"Maximum Shapes: {args}";
                m_genomeLength = args;
            };
            frm.OnMaximumShapeComplexityChanged += (sender, args) =>
            {
                lbl_maximumShapeColplexity.Text = $"Maximum Shape Colplexity: {args}";
                m_maxVertices = args;
            };

            frm.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GeneticContext = new GeneticContext
                (
                    Context,
                    m_populationSize, 
                    m_mutationRate, 
                    m_genomeLength, 
                    m_maxVertices, 
                    m_generations
                );
            Context.GeneticContext = GeneticContext;
            GeneticContext.PopulationSize = m_populationSize;

            

            Thread t = new Thread(() =>
            {
                for (int i = 0; i < Context.GeneticContext.Generations; i++)
                {
                    Context.GeneticContext.Forward();
                    var ind = Context.GeneticContext.GetFittest();

                    Invoke(new MethodInvoker(() =>
                    {
                        pic_geneticImage.Image = ind.PictureOfIndividual;
                        lbl_currentFitness.Text = $"Current Fitness: {ind.Fitness}";
                        lbl_currentGeneration.Text = $"Current Generation: {i}";
                    }));
                }
            });
            t.Start();
            
        }
        private Point[] CalculateColorRange(Bitmap bitmap)
        {
            // Initialize min and max values for RGB
            int minRed = 255, maxRed = 0;
            int minGreen = 255, maxGreen = 0;
            int minBlue = 255, maxBlue = 0;

            // Iterate through each pixel in the image
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    // Update min and max values for red
                    if (pixelColor.R < minRed) minRed = pixelColor.R;
                    if (pixelColor.R > maxRed) maxRed = pixelColor.R;

                    // Update min and max values for green
                    if (pixelColor.G < minGreen) minGreen = pixelColor.G;
                    if (pixelColor.G > maxGreen) maxGreen = pixelColor.G;

                    // Update min and max values for blue
                    if (pixelColor.B < minBlue) minBlue = pixelColor.B;
                    if (pixelColor.B > maxBlue) maxBlue = pixelColor.B;
                }
            }

            return new Point[] { new Point(minRed, maxRed), new Point(minGreen, maxGreen), new Point(minBlue, maxBlue) };
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
