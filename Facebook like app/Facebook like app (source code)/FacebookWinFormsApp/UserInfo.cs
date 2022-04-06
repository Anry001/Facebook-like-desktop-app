using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class UserIntro : UserControl
    {
        private User m_LoggedInUser = null;

        public UserIntro()
        {
            InitializeComponent();
        }

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
            set { m_LoggedInUser = value; }
        }

        private void linkLabelFetchIntro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchIntro();
        }

        /// 1. I want to create a "intro" just like facebook.
        private void fetchIntro()
        {
            listBoxIntro.Items.Clear();
            try
            {
                string[] birthYear = m_LoggedInUser.Birthday.Split('/');

                listBoxIntro.Items.Add($"Birthday: {m_LoggedInUser.Birthday} (age: {int.Parse(DateTime.Today.Year.ToString()) - int.Parse(birthYear[2])})");
                listBoxIntro.Items.Add($"Email: {m_LoggedInUser.Email}");
                listBoxIntro.Items.Add($"Relationship Status: {m_LoggedInUser.RelationshipStatus}");
                listBoxIntro.Items.Add($"Gender: {m_LoggedInUser.Gender}");
                listBoxIntro.Items.Add($"HomeTown: {m_LoggedInUser.Location.Name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxIntro.Items.Count == 0)
            {
                MessageBox.Show("No intro to retrieve :(");
            }
        }
    }
}