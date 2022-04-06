using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MyFilters;

namespace BasicFacebookFeatures
{
    public partial class FormImageFilters : Form
    {
        public FormImageFilters()
        {
            InitializeComponent();
        }

        public void AddSourcePhoto(Image I_image)
        {
            pictureBoxImage.Image = I_image;
        }

        private void OnCheckChangedEventHandler(object sender, EventArgs e)
        {
            if (pictureBoxImage.Image != null)
            {
                if (radioButtonGrayScale.Checked == true)
                {
                    pictureBoxFilteredImage.Image = pictureBoxImage.Image.DrawAsGrayscale();
                }
                else if (radioButtonTransparency.Checked == true)
                {
                    pictureBoxFilteredImage.Image = pictureBoxImage.Image.DrawWithTransparency();
                }
                else if (radioButtonNegative.Checked == true)
                {
                    pictureBoxFilteredImage.Image = pictureBoxImage.Image.DrawAsNegative();
                }
                else if (radioButtonSepia.Checked == true)
                {
                    pictureBoxFilteredImage.Image = pictureBoxImage.Image.DrawAsSepiaTone();
                }
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            FormPhotos.ChangePicture(pictureBoxFilteredImage.Image);
            this.Close();
        }
    }
}