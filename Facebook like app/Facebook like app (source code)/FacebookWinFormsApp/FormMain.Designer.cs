namespace BasicFacebookFeatures
{
    public partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.buttonZodiac = new System.Windows.Forms.Button();
            this.userControlFriends = new BasicFacebookFeatures.FriendUserControl();
            this.userControlAlbum = new BasicFacebookFeatures.AlbumsUserControl();
            this.userControlPosts = new BasicFacebookFeatures.PostsUserControl();
            this.userIntro = new BasicFacebookFeatures.UserIntro();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 18);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 35);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(18, 63);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Location = new System.Drawing.Point(43, 258);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(203, 113);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Location = new System.Drawing.Point(73, 385);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(128, 20);
            this.labelProfileName.TabIndex = 54;
            this.labelProfileName.Text = "labelProfileName";
            this.labelProfileName.Visible = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCover.Location = new System.Drawing.Point(12, 106);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(268, 156);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 56;
            this.pictureBoxCover.TabStop = false;
            // 
            // buttonZodiac
            // 
            this.buttonZodiac.Location = new System.Drawing.Point(926, 138);
            this.buttonZodiac.Name = "buttonZodiac";
            this.buttonZodiac.Size = new System.Drawing.Size(129, 94);
            this.buttonZodiac.TabIndex = 58;
            this.buttonZodiac.Text = "Zodiac";
            this.buttonZodiac.UseVisualStyleBackColor = true;
            this.buttonZodiac.Visible = false;
            this.buttonZodiac.Click += new System.EventHandler(this.buttonZodiac_Click);
            this.buttonZodiac.Visible = false;
            // 
            // userControlFriends
            // 
            this.userControlFriends.Location = new System.Drawing.Point(408, 651);
            this.userControlFriends.Name = "userControlFriends";
            this.userControlFriends.Size = new System.Drawing.Size(512, 312);
            this.userControlFriends.TabIndex = 62;
            this.userControlFriends.Visible = false;
            // 
            // userControlAlbum
            // 
            this.userControlAlbum.Location = new System.Drawing.Point(408, 367);
            this.userControlAlbum.Name = "userControlAlbum";
            this.userControlAlbum.Size = new System.Drawing.Size(512, 247);
            this.userControlAlbum.TabIndex = 61;
            this.userControlAlbum.Visible = false;
            // 
            // userControlPosts
            // 
            this.userControlPosts.Location = new System.Drawing.Point(348, 48);
            this.userControlPosts.Name = "userControlPosts";
            this.userControlPosts.Size = new System.Drawing.Size(572, 423);
            this.userControlPosts.TabIndex = 60;
            this.userControlPosts.Visible = false;
            // 
            // userIntro
            // 
            this.userIntro.Location = new System.Drawing.Point(33, 452);
            this.userIntro.LoggedInUser = null;
            this.userIntro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userIntro.Name = "userIntro1";
            this.userIntro.Size = new System.Drawing.Size(292, 262);
            this.userIntro.TabIndex = 63;
            this.userIntro.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 1011);
            this.Controls.Add(this.userIntro);
            this.Controls.Add(this.userControlFriends);
            this.Controls.Add(this.userControlAlbum);
            this.Controls.Add(this.userControlPosts);
            this.Controls.Add(this.buttonZodiac);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelProfileName;
        private PostsUserControl userControlPosts;
        private FriendUserControl userControlFriends;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private AlbumsUserControl userControlAlbum;
        private System.Windows.Forms.Button buttonZodiac;
        private UserIntro userIntro;
    }
}