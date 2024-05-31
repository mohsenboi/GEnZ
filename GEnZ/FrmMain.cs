using GEnZ.GEnZ;
using GEnZ.GEnZ.GenticAlgorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEnZ
{
    public partial class FrmMain : Form
    {
        public static GEnZContext? Context;
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
    }
}
