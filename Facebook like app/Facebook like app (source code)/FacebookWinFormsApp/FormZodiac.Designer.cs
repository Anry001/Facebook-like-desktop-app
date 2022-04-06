namespace BasicFacebookFeatures
{
    public partial class FormZodiac
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
            this.labelZodiacName = new System.Windows.Forms.Label();
            this.buttonGeneralInformation = new System.Windows.Forms.Button();
            this.buttonDailyHoroscope = new System.Windows.Forms.Button();
            this.buttonYearlyHoroscope = new System.Windows.Forms.Button();
            this.textBoxDailyHoroscope = new System.Windows.Forms.TextBox();
            this.textBoxGeneralInfo = new System.Windows.Forms.TextBox();
            this.textBoxYearlyHoroscope = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelZodiacName
            // 
            this.labelZodiacName.AutoSize = true;
            this.labelZodiacName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZodiacName.Location = new System.Drawing.Point(514, 9);
            this.labelZodiacName.Name = "labelZodiacName";
            this.labelZodiacName.Size = new System.Drawing.Size(126, 46);
            this.labelZodiacName.TabIndex = 0;
            this.labelZodiacName.Text = "label1";
            // 
            // buttonGeneralInformation
            // 
            this.buttonGeneralInformation.Location = new System.Drawing.Point(522, 58);
            this.buttonGeneralInformation.Name = "buttonGeneralInformation";
            this.buttonGeneralInformation.Size = new System.Drawing.Size(102, 87);
            this.buttonGeneralInformation.TabIndex = 1;
            this.buttonGeneralInformation.Tag = 2;
            this.buttonGeneralInformation.Text = "General Information";
            this.buttonGeneralInformation.UseVisualStyleBackColor = true;
            this.buttonGeneralInformation.Click += new System.EventHandler(this.buttonGeneralInformation_Click);
            // 
            // buttonDailyHoroscope
            // 
            this.buttonDailyHoroscope.Location = new System.Drawing.Point(101, 58);
            this.buttonDailyHoroscope.Name = "buttonDailyHoroscope";
            this.buttonDailyHoroscope.Size = new System.Drawing.Size(103, 87);
            this.buttonDailyHoroscope.TabIndex = 2;
            this.buttonDailyHoroscope.Tag = 1;
            this.buttonDailyHoroscope.Text = "Daily Horoscope";
            this.buttonDailyHoroscope.UseVisualStyleBackColor = true;
            this.buttonDailyHoroscope.Click += new System.EventHandler(this.buttonDailyHoroscope_Click);
            // 
            // buttonYearlyHoroscope
            // 
            this.buttonYearlyHoroscope.Location = new System.Drawing.Point(1019, 58);
            this.buttonYearlyHoroscope.Name = "buttonYearlyHoroscope";
            this.buttonYearlyHoroscope.Size = new System.Drawing.Size(103, 87);
            this.buttonYearlyHoroscope.TabIndex = 3;
            this.buttonYearlyHoroscope.Tag = 3;
            this.buttonYearlyHoroscope.Text = "Yearly Horoscope";
            this.buttonYearlyHoroscope.UseVisualStyleBackColor = true;
            this.buttonYearlyHoroscope.Click += new System.EventHandler(this.buttonYearlyHoroscope_Click);
            // 
            // textBoxDailyHoroscope
            // 
            this.textBoxDailyHoroscope.Location = new System.Drawing.Point(1, 151);
            this.textBoxDailyHoroscope.Multiline = true;
            this.textBoxDailyHoroscope.Name = "textBoxDailyHoroscope";
            this.textBoxDailyHoroscope.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDailyHoroscope.Size = new System.Drawing.Size(294, 287);
            this.textBoxDailyHoroscope.TabIndex = 4;
            // 
            // textBoxGeneralInfo
            // 
            this.textBoxGeneralInfo.Location = new System.Drawing.Point(315, 152);
            this.textBoxGeneralInfo.Multiline = true;
            this.textBoxGeneralInfo.Name = "textBoxGeneralInfo";
            this.textBoxGeneralInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGeneralInfo.Size = new System.Drawing.Size(478, 287);
            this.textBoxGeneralInfo.TabIndex = 5;
            // 
            // textBoxYearlyHoroscope
            // 
            this.textBoxYearlyHoroscope.Location = new System.Drawing.Point(799, 151);
            this.textBoxYearlyHoroscope.Multiline = true;
            this.textBoxYearlyHoroscope.Name = "textBoxYearlyHoroscope";
            this.textBoxYearlyHoroscope.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxYearlyHoroscope.Size = new System.Drawing.Size(496, 287);
            this.textBoxYearlyHoroscope.TabIndex = 6;
            // 
            // FormZodiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 451);
            this.Controls.Add(this.textBoxYearlyHoroscope);
            this.Controls.Add(this.textBoxGeneralInfo);
            this.Controls.Add(this.textBoxDailyHoroscope);
            this.Controls.Add(this.buttonYearlyHoroscope);
            this.Controls.Add(this.buttonDailyHoroscope);
            this.Controls.Add(this.buttonGeneralInformation);
            this.Controls.Add(this.labelZodiacName);
            this.Name = "FormZodiac";
            this.Text = "FormZodiac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZodiacName;
        private System.Windows.Forms.Button buttonGeneralInformation;
        private System.Windows.Forms.Button buttonDailyHoroscope;
        private System.Windows.Forms.Button buttonYearlyHoroscope;
        private System.Windows.Forms.TextBox textBoxDailyHoroscope;
        private System.Windows.Forms.TextBox textBoxGeneralInfo;
        private System.Windows.Forms.TextBox textBoxYearlyHoroscope;
    }
}