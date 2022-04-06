using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            registerToEvents();
        }

        private void registerToEvents()
        {
            userControlPosts.ListBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            userControlPosts.ButtonPost.Click += new System.EventHandler(this.buttonPost_Click);
            userControlPosts.LinkPost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            userControlFriends.LinkFriends.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            userControlFriends.ListBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            userControlAlbum.LinkAlbums.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            userControlAlbum.ListBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            userControlAlbum.ButtonPhotos.Click += new EventHandler(this.buttonPhotos_Click);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_LoginResult = FacebookService.Login(
                "1157772188124874",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
                MakeComponentsVisible();
                GetCoverPhoto();
                labelProfileName.Text = m_LoginResult.LoggedInUser.Name;
                labelProfileName.Visible = true;
                userIntro.LoggedInUser = m_LoggedInUser;
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        public void MakeComponentsVisible()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
        }

        public void GetCoverPhoto()
        {
            IEnumerable<Album> coverAlbum = m_LoggedInUser.Albums.Where(album => album.Name == "Cover photos");

            foreach (Album alb in coverAlbum)
            {
                pictureBoxCover.LoadAsync(alb.Photos[0].PictureNormalURL);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                userControlPosts.ListBoxPosts.Items.Insert(0, userControlPosts.TextBoxPost.Text);

                MessageBox.Show("Status Posted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userControlFriends.ListBoxFriends.Items.Clear();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                userControlFriends.ListBoxFriends.Items.Add(friend);
            }

            userControlFriends.LinkFriends.Enabled = false;
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userControlFriends.ListBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = userControlFriends.ListBoxFriends.SelectedItem as User;
                userControlFriends.PictureBoxFriend.LoadAsync(selectedFriend.PictureSmallURL);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e) // Only you and admins can see comments
        {
            Post selected = m_LoggedInUser.Posts[userControlPosts.ListBoxPosts.SelectedIndex];

            userControlPosts.ListBoxPostComments.DisplayMember = "Message";
            userControlPosts.ListBoxPostComments.DataSource = selected.Comments;
        }

        private void fetchPosts()
        {
            userControlPosts.ListBoxPosts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    userControlPosts.ListBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    userControlPosts.ListBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    userControlPosts.ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (userControlPosts.ListBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }

            userControlPosts.LinkPost.Enabled = false;
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userControlAlbum.ListBoxAlbums.Items.Clear();
            foreach (Album album in m_LoggedInUser.Albums)
            {
                userControlAlbum.ListBoxAlbums.Items.Add(album);
            }

            if (userControlAlbum.ListBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }

            userControlAlbum.LinkAlbums.Enabled = false;
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userControlAlbum.ListBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = userControlAlbum.ListBoxAlbums.SelectedItem as Album;

                if (selectedAlbum.PictureAlbumURL != null)
                {
                    userControlAlbum.PictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            if (userControlAlbum.ListBoxAlbums.SelectedItems.Count == 1)
            {
                FormPhotos formPhotos = new FormPhotos();

                formPhotos.AddPhotos(userControlAlbum.ListBoxAlbums.SelectedItem as Album);
                formPhotos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No album is Selected");
            }
        }

        private void buttonZodiac_Click(object sender, EventArgs e)
        {
            Zodiac zodiac = new Zodiac(m_LoggedInUser.Birthday);
            FormZodiac formZodiac = new FormZodiac();

            formZodiac.GetUserZodiac(zodiac.ZodiacSign);
            formZodiac.ShowDialog();
        }
    }
}