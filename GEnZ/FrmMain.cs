using GEnZ.GEnZ;
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
        private GEnZContext m_Context;
        public FrmMain()
        {
            InitializeComponent();

            m_Context = new GEnZContext();
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
                    m_Context.ClearContext();
                    m_Context.IsInitiated = true;

                    m_Context.OriginalPictureImg = Image.FromFile(dialog.FileName);
                    m_Context.OriginalPictureBmp = new Bitmap(m_Context.OriginalPictureImg);

                    pic_originalImage.Image = m_Context.OriginalPictureImg;
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
            };
            frm.OnPopulationSizeChanged += (sender, args) =>
            {
                lbl_populationSize.Text = $"Population Size: {args}";
            };

            frm.Show();
        }
    }
}
