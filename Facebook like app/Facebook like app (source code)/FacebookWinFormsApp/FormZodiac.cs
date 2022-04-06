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
    public partial class FormZodiac : Form
    {
        private Scrape m_Scraper = new Scrape();

        public FormZodiac()
        {
            InitializeComponent();
        }

        public void GetUserZodiac(eZodiacSigns i_MyZodiac)
        {
            labelZodiacName.Text = i_MyZodiac.ToString();
        }

        private async void buttonGeneralInformation_Click(object sender, EventArgs e)
        {
            eZodiacSigns zodiacSign;
            int senderID = Convert.ToInt32((sender as Button).Tag);

            Enum.TryParse(labelZodiacName.Text, out zodiacSign);
            string result = await m_Scraper.ScrapeTask((int) zodiacSign, senderID);
            result = result.Replace(".", "." + Environment.NewLine);
            textBoxGeneralInfo.Text = result;
        }

        private async void buttonDailyHoroscope_Click(object sender, EventArgs e)
        {
            eZodiacSigns zodiacSign;
            int senderID = Convert.ToInt32((sender as Button).Tag);

            Enum.TryParse(labelZodiacName.Text, out zodiacSign);
            string result = await m_Scraper.ScrapeTask((int)zodiacSign, senderID);
            textBoxDailyHoroscope.Text = result;
        }

        private async void buttonYearlyHoroscope_Click(object sender, EventArgs e)
        {
            eZodiacSigns zodiacSign;
            int senderID = Convert.ToInt32((sender as Button).Tag);

            Enum.TryParse(labelZodiacName.Text, out zodiacSign);
            string result = await m_Scraper.ScrapeTask((int)zodiacSign, senderID);
            result = result.Replace(".", "." + Environment.NewLine);
            textBoxYearlyHoroscope.Text = result;
        }
    }
}