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
            ((System.ComponentModel.ISupportInitialize)(this.pic_originalImage)).BeginInit();
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 564);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_originalImage;
        private Button btn_loadOriginalImage;
        private TextBox txt_origianlImagePath;
        private ComboBox cmb_originalImageSizeMode;
        private Label label1;
    }
}