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
            this.num_generations = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_maximumShapesChanged = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_maximumShapeComplexity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_populationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_generations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maximumShapesChanged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maximumShapeComplexity)).BeginInit();
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
            this.pic_confirm.Location = new System.Drawing.Point(197, 251);
            this.pic_confirm.Name = "pic_confirm";
            this.pic_confirm.Size = new System.Drawing.Size(47, 41);
            this.pic_confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_confirm.TabIndex = 4;
            this.pic_confirm.TabStop = false;
            this.pic_confirm.Click += new System.EventHandler(this.pic_confirm_Click);
            // 
            // num_generations
            // 
            this.num_generations.Location = new System.Drawing.Point(197, 114);
            this.num_generations.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_generations.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_generations.Name = "num_generations";
            this.num_generations.Size = new System.Drawing.Size(120, 23);
            this.num_generations.TabIndex = 6;
            this.num_generations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_generations.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generations: ";
            // 
            // num_maximumShapesChanged
            // 
            this.num_maximumShapesChanged.Location = new System.Drawing.Point(197, 157);
            this.num_maximumShapesChanged.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_maximumShapesChanged.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_maximumShapesChanged.Name = "num_maximumShapesChanged";
            this.num_maximumShapesChanged.Size = new System.Drawing.Size(120, 23);
            this.num_maximumShapesChanged.TabIndex = 8;
            this.num_maximumShapesChanged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_maximumShapesChanged.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maximum Shapes: ";
            // 
            // num_maximumShapeComplexity
            // 
            this.num_maximumShapeComplexity.Location = new System.Drawing.Point(197, 198);
            this.num_maximumShapeComplexity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_maximumShapeComplexity.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_maximumShapeComplexity.Name = "num_maximumShapeComplexity";
            this.num_maximumShapeComplexity.Size = new System.Drawing.Size(120, 23);
            this.num_maximumShapeComplexity.TabIndex = 10;
            this.num_maximumShapeComplexity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_maximumShapeComplexity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maximum Shape Complexity: ";
            // 
            // FrmGeneticAlgorithmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 318);
            this.Controls.Add(this.num_maximumShapeComplexity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_maximumShapesChanged);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_generations);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.num_generations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maximumShapesChanged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maximumShapeComplexity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown num_populationSize;
        private Label label2;
        private TextBox txt_mutationRate;
        private PictureBox pic_confirm;
        private NumericUpDown num_generations;
        private Label label3;
        private NumericUpDown num_maximumShapesChanged;
        private Label label4;
        private NumericUpDown num_maximumShapeComplexity;
        private Label label5;
    }
}