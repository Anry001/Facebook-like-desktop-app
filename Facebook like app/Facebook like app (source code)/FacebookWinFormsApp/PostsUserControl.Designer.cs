namespace BasicFacebookFeatures
{
    public partial class PostsUserControl
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
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.linkLabelFetchPost = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPostStatus.Location = new System.Drawing.Point(140, 16);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(100, 20);
            this.labelPostStatus.TabIndex = 0;
            this.labelPostStatus.Text = "Post Status: ";
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(246, 16);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(218, 26);
            this.textBoxPostStatus.TabIndex = 1;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(484, 16);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 35);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            // 
            // linkLabelFetchPost
            // 
            this.linkLabelFetchPost.AutoSize = true;
            this.linkLabelFetchPost.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkLabelFetchPost.Location = new System.Drawing.Point(31, 51);
            this.linkLabelFetchPost.Name = "linkLabelFetchPost";
            this.linkLabelFetchPost.Size = new System.Drawing.Size(291, 42);
            this.linkLabelFetchPost.TabIndex = 3;
            this.linkLabelFetchPost.TabStop = true;
            this.linkLabelFetchPost.Text = "Fetch Posts\r\n(click on the post to see the comments)";
            this.linkLabelFetchPost.UseCompatibleTextRendering = true;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(31, 95);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(528, 184);
            this.listBoxPosts.TabIndex = 4;
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 20;
            this.listBoxPostComments.Location = new System.Drawing.Point(375, 155);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(184, 124);
            this.listBoxPostComments.TabIndex = 5;
            // 
            // Posts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.linkLabelFetchPost);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Name = "Posts";
            this.Size = new System.Drawing.Size(572, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.LinkLabel linkLabelFetchPost;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxPostComments;
    }
}
