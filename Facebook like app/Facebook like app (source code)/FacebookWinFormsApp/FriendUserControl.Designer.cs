namespace BasicFacebookFeatures
{
    public partial class FriendUserControl
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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.linkLabelFetchFriends = new System.Windows.Forms.LinkLabel();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 86);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(503, 184);
            this.listBoxFriends.TabIndex = 7;
            // 
            // linkLabelFetchFriends
            // 
            this.linkLabelFetchFriends.AutoSize = true;
            this.linkLabelFetchFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelFetchFriends.Location = new System.Drawing.Point(0, 41);
            this.linkLabelFetchFriends.Name = "linkLabelFetchFriends";
            this.linkLabelFetchFriends.Size = new System.Drawing.Size(267, 42);
            this.linkLabelFetchFriends.TabIndex = 6;
            this.linkLabelFetchFriends.TabStop = true;
            this.linkLabelFetchFriends.Text = "Fetch Friends\r\n(click on the friend to see the photo)";
            this.linkLabelFetchFriends.UseCompatibleTextRendering = true;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(406, 175);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(100, 95);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 8;
            this.pictureBoxFriend.TabStop = false;
            // 
            // FriendUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.linkLabelFetchFriends);
            this.Name = "FriendUserControl";
            this.Size = new System.Drawing.Size(512, 312);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.LinkLabel linkLabelFetchFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
    }
}
