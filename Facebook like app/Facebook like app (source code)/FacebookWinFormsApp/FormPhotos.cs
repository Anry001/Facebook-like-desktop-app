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
    public partial class FormPhotos : Form
    {
        private static PictureBox m_CurrentImage;

        public FormPhotos()
        {
            InitializeComponent();
        }

        public PictureBox CurrentImage
        {
            get { return m_CurrentImage; }
        }

        public static void ChangePicture(Image I_Image)
        {
            m_CurrentImage.Image = I_Image;
        }

        public void AddPhotos(Album i_Album)
        {
            int x = 20;
            int y = 20;
            int maxHeight = -1;

            foreach (Photo photo in i_Album.Photos)
            {
                PictureBox pic = new PictureBox();

                pic.Size = new Size(100, 100);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.LoadAsync(photo.PictureNormalURL);
                pic.Location = new Point(x, y);
                x += pic.Width + 10;
                maxHeight = Math.Max(pic.Height, maxHeight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHeight + 10;
                }

                this.panelPhotos.Controls.Add(pic);
                pic.DoubleClick += new EventHandler(this.pictureBox_DoubleClicked);
            }
        }

        private void pictureBox_DoubleClicked(object sender, EventArgs e)
        {
            m_CurrentImage = sender as PictureBox;
            FormImageFilters formFilters = new FormImageFilters();

            formFilters.AddSourcePhoto(m_CurrentImage.Image);
            formFilters.ShowDialog();
        }
    }
}