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
    public partial class FriendUserControl : UserControl
    {
        public FriendUserControl()
        {
            InitializeComponent();
        }

        public LinkLabel LinkFriends
        {
            get { return linkLabelFetchFriends; }
        }

        public ListBox ListBoxFriends
        {
            get { return listBoxFriends; }
        }

        public PictureBox PictureBoxFriend
        {
            get { return pictureBoxFriend; }
        }
    }
}