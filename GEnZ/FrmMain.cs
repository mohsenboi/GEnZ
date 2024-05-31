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
            GeneticContext = new GeneticContext(50, 0, 100, 5, 0);
            FrmMain.Context.GeneticContext = GeneticContext;
            GeneticContext.PopulationSize = 50;


            var frm = new FrmGeneticAlgorithmSettings();
            frm.OnMutationRateChanged += (sender, args) =>
            {
                lbl_mutationRate.Text = $"Mutation Rate: {args}";
                GeneticContext.MutationRate = args;
            };
            frm.OnPopulationSizeChanged += (sender, args) =>
            {
                lbl_populationSize.Text = $"Population Size: {args}";
                GeneticContext.PopulationSize = args;
            };
            frm.OnGenerationsChanged += (sender, args) =>
            {
                lbl_generations.Text = $"Generations: {args}";
                GeneticContext.Generations = args;
            };

            frm.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Context.GeneticContext = GeneticContext;
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
                    }));
                }
            });
            t.Start();
            
        }
    }
}
