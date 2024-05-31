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
    public partial class FrmGeneticAlgorithmSettings : Form
    {
        public EventHandler<int> OnPopulationSizeChanged;
        public EventHandler<double> OnMutationRateChanged;
        public EventHandler<int> OnGenerationsChanged;
        public EventHandler<int> OnMaximumShapesChanged;
        public EventHandler<int> OnMaximumShapeComplexityChanged;

        public FrmGeneticAlgorithmSettings()
        {
            InitializeComponent();
        }

        private void pic_confirm_Click(object sender, EventArgs e)
        {
            OnPopulationSizeChanged?.Invoke(this, (int)num_populationSize.Value);
            if (double.TryParse(txt_mutationRate.Text, out var mutationRate))
            {
                OnMutationRateChanged?.Invoke(this, mutationRate);
            }
            OnGenerationsChanged?.Invoke(this, (int)num_generations.Value);
            OnMaximumShapesChanged?.Invoke(this, (int)num_maximumShapesChanged.Value);
            OnMaximumShapeComplexityChanged?.Invoke(this, (int)num_maximumShapeComplexity.Value);
        }
    }
}
