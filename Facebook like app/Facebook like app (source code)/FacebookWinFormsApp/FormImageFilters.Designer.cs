namespace BasicFacebookFeatures
{
    public partial class FormImageFilters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImageFilters));
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxFilteredImage = new System.Windows.Forms.PictureBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.radioButtonGrayScale = new System.Windows.Forms.RadioButton();
            this.radioButtonTransparency = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.radioButtonSepia = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilteredImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(60, 38);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(262, 292);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // pictureBoxFilteredImage
            // 
            this.pictureBoxFilteredImage.Location = new System.Drawing.Point(446, 38);
            this.pictureBoxFilteredImage.Name = "pictureBoxFilteredImage";
            this.pictureBoxFilteredImage.Size = new System.Drawing.Size(269, 292);
            this.pictureBoxFilteredImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilteredImage.TabIndex = 1;
            this.pictureBoxFilteredImage.TabStop = false;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(139, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(101, 20);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Input Source";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(539, 9);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(115, 20);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Filtered Output";
            // 
            // radioButtonGrayScale
            // 
            this.radioButtonGrayScale.AutoSize = true;
            this.radioButtonGrayScale.Location = new System.Drawing.Point(114, 377);
            this.radioButtonGrayScale.Name = "radioButtonGrayScale";
            this.radioButtonGrayScale.Size = new System.Drawing.Size(108, 24);
            this.radioButtonGrayScale.TabIndex = 4;
            this.radioButtonGrayScale.TabStop = true;
            this.radioButtonGrayScale.Text = "GrayScale";
            this.radioButtonGrayScale.UseVisualStyleBackColor = true;
            this.radioButtonGrayScale.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonTransparency
            // 
            this.radioButtonTransparency.AutoSize = true;
            this.radioButtonTransparency.Location = new System.Drawing.Point(281, 377);
            this.radioButtonTransparency.Name = "radioButtonTransparency";
            this.radioButtonTransparency.Size = new System.Drawing.Size(130, 24);
            this.radioButtonTransparency.TabIndex = 5;
            this.radioButtonTransparency.TabStop = true;
            this.radioButtonTransparency.Text = "Transparency";
            this.radioButtonTransparency.UseVisualStyleBackColor = true;
            this.radioButtonTransparency.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Location = new System.Drawing.Point(462, 377);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(96, 24);
            this.radioButtonNegative.TabIndex = 6;
            this.radioButtonNegative.TabStop = true;
            this.radioButtonNegative.Text = "Negative";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            this.radioButtonNegative.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonSepia
            // 
            this.radioButtonSepia.AutoSize = true;
            this.radioButtonSepia.Location = new System.Drawing.Point(601, 377);
            this.radioButtonSepia.Name = "radioButtonSepia";
            this.radioButtonSepia.Size = new System.Drawing.Size(115, 24);
            this.radioButtonSepia.TabIndex = 7;
            this.radioButtonSepia.TabStop = true;
            this.radioButtonSepia.Text = "Sepia Tone";
            this.radioButtonSepia.UseVisualStyleBackColor = true;
            this.radioButtonSepia.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(349, 170);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 71);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Apply Filter";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FormImageFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.radioButtonSepia);
            this.Controls.Add(this.radioButtonNegative);
            this.Controls.Add(this.radioButtonTransparency);
            this.Controls.Add(this.radioButtonGrayScale);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.pictureBoxFilteredImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImageFilters";
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilteredImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxFilteredImage;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.RadioButton radioButtonGrayScale;
        private System.Windows.Forms.RadioButton radioButtonTransparency;
        private System.Windows.Forms.RadioButton radioButtonNegative;
        private System.Windows.Forms.RadioButton radioButtonSepia;
        private System.Windows.Forms.Button buttonApply;
    }
}