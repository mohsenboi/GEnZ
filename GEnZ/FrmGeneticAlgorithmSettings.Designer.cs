namespace GEnZ
{
    partial class FrmGeneticAlgorithmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.num_populationSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mutationRate = new System.Windows.Forms.TextBox();
            this.pic_confirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_populationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Population Size: ";
            // 
            // num_populationSize
            // 
            this.num_populationSize.Location = new System.Drawing.Point(197, 25);
            this.num_populationSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_populationSize.Name = "num_populationSize";
            this.num_populationSize.Size = new System.Drawing.Size(120, 23);
            this.num_populationSize.TabIndex = 1;
            this.num_populationSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_populationSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mutation Rate: ";
            // 
            // txt_mutationRate
            // 
            this.txt_mutationRate.Location = new System.Drawing.Point(197, 67);
            this.txt_mutationRate.Name = "txt_mutationRate";
            this.txt_mutationRate.Size = new System.Drawing.Size(120, 23);
            this.txt_mutationRate.TabIndex = 3;
            this.txt_mutationRate.Text = "0.02";
            this.txt_mutationRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_confirm
            // 
            this.pic_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_confirm.Image = global::GEnZ.Properties.Resources._1;
            this.pic_confirm.Location = new System.Drawing.Point(197, 203);
            this.pic_confirm.Name = "pic_confirm";
            this.pic_confirm.Size = new System.Drawing.Size(47, 41);
            this.pic_confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_confirm.TabIndex = 4;
            this.pic_confirm.TabStop = false;
            this.pic_confirm.Click += new System.EventHandler(this.pic_confirm_Click);
            // 
            // FrmGeneticAlgorithmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 256);
            this.Controls.Add(this.pic_confirm);
            this.Controls.Add(this.txt_mutationRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_populationSize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeneticAlgorithmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetic Algorithm Settings";
            ((System.ComponentModel.ISupportInitialize)(this.num_populationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown num_populationSize;
        private Label label2;
        private TextBox txt_mutationRate;
        private PictureBox pic_confirm;
    }
}