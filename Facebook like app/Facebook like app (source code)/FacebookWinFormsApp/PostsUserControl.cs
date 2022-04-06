using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class PostsUserControl : UserControl
    {
        public PostsUserControl()
        {
            InitializeComponent();
        }

        public LinkLabel LinkPost
        {
            get { return linkLabelFetchPost; }
        }

        public ListBox ListBoxPosts
        {
            get { return listBoxPosts; }
        }

        public Button ButtonPost
        {
            get { return buttonPost; }
        }

        public TextBox TextBoxPost
        {
            get { return textBoxPostStatus; }
        }

        public ListBox ListBoxPostComments
        {
            get { return listBoxPostComments; }
        }
    }
}