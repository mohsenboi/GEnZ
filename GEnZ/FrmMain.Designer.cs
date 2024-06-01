namespace GEnZ
{
    partial class FrmMain
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
            this.pic_originalImage = new System.Windows.Forms.PictureBox();
            this.btn_loadOriginalImage = new System.Windows.Forms.Button();
            this.txt_origianlImagePath = new System.Windows.Forms.TextBox();
            this.cmb_originalImageSizeMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_geneticAlgorithmSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_maximumShapeColplexity = new System.Windows.Forms.Label();
            this.lbl_maximumShapes = new System.Windows.Forms.Label();
            this.lbl_generations = new System.Windows.Forms.Label();
            this.lbl_mutationRate = new System.Windows.Forms.Label();
            this.lbl_populationSize = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.pic_geneticImage = new System.Windows.Forms.PictureBox();
            this.lbl_currentFitness = new System.Windows.Forms.Label();
            this.lbl_currentGeneration = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_originalImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_geneticImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_originalImage
            // 
            this.pic_originalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_originalImage.Location = new System.Drawing.Point(12, 39);
            this.pic_originalImage.Name = "pic_originalImage";
            this.pic_originalImage.Size = new System.Drawing.Size(312, 279);
            this.pic_originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_originalImage.TabIndex = 0;
            this.pic_originalImage.TabStop = false;
            // 
            // btn_loadOriginalImage
            // 
            this.btn_loadOriginalImage.Location = new System.Drawing.Point(288, 10);
            this.btn_loadOriginalImage.Name = "btn_loadOriginalImage";
            this.btn_loadOriginalImage.Size = new System.Drawing.Size(36, 23);
            this.btn_loadOriginalImage.TabIndex = 1;
            this.btn_loadOriginalImage.Text = "...";
            this.btn_loadOriginalImage.UseVisualStyleBackColor = true;
            this.btn_loadOriginalImage.Click += new System.EventHandler(this.btn_loadOriginalImage_Click);
            // 
            // txt_origianlImagePath
            // 
            this.txt_origianlImagePath.Location = new System.Drawing.Point(12, 10);
            this.txt_origianlImagePath.Name = "txt_origianlImagePath";
            this.txt_origianlImagePath.ReadOnly = true;
            this.txt_origianlImagePath.Size = new System.Drawing.Size(270, 23);
            this.txt_origianlImagePath.TabIndex = 2;
            // 
            // cmb_originalImageSizeMode
            // 
            this.cmb_originalImageSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_originalImageSizeMode.FormattingEnabled = true;
            this.cmb_originalImageSizeMode.Items.AddRange(new object[] {
            "Normal",
            "StretchImage",
            "AutoSize",
            "CenterImage",
            "Zoom"});
            this.cmb_originalImageSizeMode.Location = new System.Drawing.Point(85, 324);
            this.cmb_originalImageSizeMode.Name = "cmb_originalImageSizeMode";
            this.cmb_originalImageSizeMode.Size = new System.Drawing.Size(239, 23);
            this.cmb_originalImageSizeMode.TabIndex = 3;
            this.cmb_originalImageSizeMode.SelectedIndexChanged += new System.EventHandler(this.cmb_originalImageSizeMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size mode: ";
            // 
            // btn_geneticAlgorithmSettings
            // 
            this.btn_geneticAlgorithmSettings.Location = new System.Drawing.Point(384, 12);
            this.btn_geneticAlgorithmSettings.Name = "btn_geneticAlgorithmSettings";
            this.btn_geneticAlgorithmSettings.Size = new System.Drawing.Size(236, 23);
            this.btn_geneticAlgorithmSettings.TabIndex = 5;
            this.btn_geneticAlgorithmSettings.Text = "Genetic Settings";
            this.btn_geneticAlgorithmSettings.UseVisualStyleBackColor = true;
            this.btn_geneticAlgorithmSettings.Click += new System.EventHandler(this.btn_geneticAlgorithmSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_maximumShapeColplexity);
            this.groupBox1.Controls.Add(this.lbl_maximumShapes);
            this.groupBox1.Controls.Add(this.lbl_generations);
            this.groupBox1.Controls.Add(this.lbl_mutationRate);
            this.groupBox1.Controls.Add(this.lbl_populationSize);
            this.groupBox1.Location = new System.Drawing.Point(384, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbl_maximumShapeColplexity
            // 
            this.lbl_maximumShapeColplexity.AutoSize = true;
            this.lbl_maximumShapeColplexity.Location = new System.Drawing.Point(6, 140);
            this.lbl_maximumShapeColplexity.Name = "lbl_maximumShapeColplexity";
            this.lbl_maximumShapeColplexity.Size = new System.Drawing.Size(165, 15);
            this.lbl_maximumShapeColplexity.TabIndex = 4;
            this.lbl_maximumShapeColplexity.Text = "Maximum Shape Colplexity: 0";
            // 
            // lbl_maximumShapes
            // 
            this.lbl_maximumShapes.AutoSize = true;
            this.lbl_maximumShapes.Location = new System.Drawing.Point(6, 110);
            this.lbl_maximumShapes.Name = "lbl_maximumShapes";
            this.lbl_maximumShapes.Size = new System.Drawing.Size(114, 15);
            this.lbl_maximumShapes.TabIndex = 3;
            this.lbl_maximumShapes.Text = "Maximum Shapes: 0";
            // 
            // lbl_generations
            // 
            this.lbl_generations.AutoSize = true;
            this.lbl_generations.Location = new System.Drawing.Point(6, 81);
            this.lbl_generations.Name = "lbl_generations";
            this.lbl_generations.Size = new System.Drawing.Size(82, 15);
            this.lbl_generations.TabIndex = 2;
            this.lbl_generations.Text = "Generations: 0";
            // 
            // lbl_mutationRate
            // 
            this.lbl_mutationRate.AutoSize = true;
            this.lbl_mutationRate.Location = new System.Drawing.Point(6, 50);
            this.lbl_mutationRate.Name = "lbl_mutationRate";
            this.lbl_mutationRate.Size = new System.Drawing.Size(103, 15);
            this.lbl_mutationRate.TabIndex = 1;
            this.lbl_mutationRate.Text = "Mutation Rate: 0.0";
            // 
            // lbl_populationSize
            // 
            this.lbl_populationSize.AutoSize = true;
            this.lbl_populationSize.Location = new System.Drawing.Point(6, 19);
            this.lbl_populationSize.Name = "lbl_populationSize";
            this.lbl_populationSize.Size = new System.Drawing.Size(100, 15);
            this.lbl_populationSize.TabIndex = 0;
            this.lbl_populationSize.Text = "Population Size: 0";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(545, 358);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pic_geneticImage
            // 
            this.pic_geneticImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_geneticImage.Location = new System.Drawing.Point(12, 358);
            this.pic_geneticImage.Name = "pic_geneticImage";
            this.pic_geneticImage.Size = new System.Drawing.Size(312, 279);
            this.pic_geneticImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_geneticImage.TabIndex = 8;
            this.pic_geneticImage.TabStop = false;
            // 
            // lbl_currentFitness
            // 
            this.lbl_currentFitness.AutoSize = true;
            this.lbl_currentFitness.Location = new System.Drawing.Point(330, 622);
            this.lbl_currentFitness.Name = "lbl_currentFitness";
            this.lbl_currentFitness.Size = new System.Drawing.Size(98, 15);
            this.lbl_currentFitness.TabIndex = 9;
            this.lbl_currentFitness.Text = "Current Fitness: 0";
            // 
            // lbl_currentGeneration
            // 
            this.lbl_currentGeneration.AutoSize = true;
            this.lbl_currentGeneration.Location = new System.Drawing.Point(330, 592);
            this.lbl_currentGeneration.Name = "lbl_currentGeneration";
            this.lbl_currentGeneration.Size = new System.Drawing.Size(120, 15);
            this.lbl_currentGeneration.TabIndex = 10;
            this.lbl_currentGeneration.Text = "Current Generation: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_currentGeneration);
            this.Controls.Add(this.lbl_currentFitness);
            this.Controls.Add(this.pic_geneticImage);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_geneticAlgorithmSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_originalImageSizeMode);
            this.Controls.Add(this.txt_origianlImagePath);
            this.Controls.Add(this.btn_loadOriginalImage);
            this.Controls.Add(this.pic_originalImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEnZ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_originalImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_geneticImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_originalImage;
        private Button btn_loadOriginalImage;
        private TextBox txt_origianlImagePath;
        private ComboBox cmb_originalImageSizeMode;
        private Label label1;
        private Button btn_geneticAlgorithmSettings;
        private GroupBox groupBox1;
        private Label lbl_populationSize;
        private Label lbl_mutationRate;
        private Button btn_start;
        private Label lbl_generations;
        private PictureBox pic_geneticImage;
        private Label lbl_currentFitness;
        private Label lbl_maximumShapes;
        private Label lbl_maximumShapeColplexity;
        private Label lbl_currentGeneration;
        private Button button1;
    }
}