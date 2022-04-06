namespace BasicFacebookFeatures
{
    public partial class AlbumsUserControl
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
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.linkLabelFetchAlbums = new System.Windows.Forms.LinkLabel();
            this.buttonPhotos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(406, 146);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(100, 95);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 11;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(3, 57);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(503, 184);
            this.listBoxAlbums.TabIndex = 10;
            // 
            // linkLabelFetchAlbums
            // 
            this.linkLabelFetchAlbums.AutoSize = true;
            this.linkLabelFetchAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelFetchAlbums.Location = new System.Drawing.Point(0, 12);
            this.linkLabelFetchAlbums.Name = "linkLabelFetchAlbums";
            this.linkLabelFetchAlbums.Size = new System.Drawing.Size(270, 42);
            this.linkLabelFetchAlbums.TabIndex = 9;
            this.linkLabelFetchAlbums.TabStop = true;
            this.linkLabelFetchAlbums.Text = "Fetch Albums\r\n(click on the album to see the photo)";
            this.linkLabelFetchAlbums.UseCompatibleTextRendering = true;
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.Location = new System.Drawing.Point(378, 72);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(128, 34);
            this.buttonPhotos.TabIndex = 12;
            this.buttonPhotos.Text = "See Photos";
            this.buttonPhotos.UseVisualStyleBackColor = true;
            // 
            // AlbumsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPhotos);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.linkLabelFetchAlbums);
            this.Name = "AlbumsUserControl";
            this.Size = new System.Drawing.Size(512, 247);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.LinkLabel linkLabelFetchAlbums;
        private System.Windows.Forms.Button buttonPhotos;
    }
}
