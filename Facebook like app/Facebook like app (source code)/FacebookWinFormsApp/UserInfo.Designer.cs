namespace BasicFacebookFeatures
{
    public partial class UserIntro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxIntro = new System.Windows.Forms.ListBox();
            this.linkLabelFetchIntro = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxIntro);
            this.panel1.Controls.Add(this.linkLabelFetchIntro);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 257);
            this.panel1.TabIndex = 0;
            // 
            // listBoxIntro
            // 
            this.listBoxIntro.FormattingEnabled = true;
            this.listBoxIntro.HorizontalScrollbar = true;
            this.listBoxIntro.ItemHeight = 20;
            this.listBoxIntro.Location = new System.Drawing.Point(2, 64);
            this.listBoxIntro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxIntro.Name = "listBoxIntro";
            this.listBoxIntro.Size = new System.Drawing.Size(284, 184);
            this.listBoxIntro.TabIndex = 1;
            // 
            // linkLabelFetchIntro
            // 
            this.linkLabelFetchIntro.AutoSize = true;
            this.linkLabelFetchIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelFetchIntro.LinkArea = new System.Windows.Forms.LinkArea(0, 11);
            this.linkLabelFetchIntro.Location = new System.Drawing.Point(0, 8);
            this.linkLabelFetchIntro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelFetchIntro.Name = "linkLabelFetchIntro";
            this.linkLabelFetchIntro.Size = new System.Drawing.Size(234, 42);
            this.linkLabelFetchIntro.TabIndex = 0;
            this.linkLabelFetchIntro.TabStop = true;
            this.linkLabelFetchIntro.Text = "Fetch Intro\r\n(click \"Fetch Intro\" to get intro)\r\n";
            this.linkLabelFetchIntro.UseCompatibleTextRendering = true;
            this.linkLabelFetchIntro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchIntro_LinkClicked);
            // 
            // UserIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserIntro";
            this.Size = new System.Drawing.Size(292, 262);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxIntro;
        private System.Windows.Forms.LinkLabel linkLabelFetchIntro;
    }
}
