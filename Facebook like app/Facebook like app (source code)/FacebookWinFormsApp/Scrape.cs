using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace BasicFacebookFeatures
{
    public class Scrape
    {
        public async Task<string> ScrapeTask(int i_ZodiacNumber, int i_SectionID)
        {
            HtmlDocument doc = await LoadHtmlDocument(string.Format("https://horoscope.walla.co.il/zodiac/{0}", i_ZodiacNumber));
            HtmlNodeCollection nodesForGoBy = doc.DocumentNode.SelectNodes(string.Format("/html/body/div[2]/div/section/section/main/article/section[{0}]/div", i_SectionID));
            string result = nodesForGoBy.FirstOrDefault().InnerText;
            return result;
        }

        private async Task<HtmlDocument> LoadHtmlDocument(string i_Url)
        {
            try
            {
                ValidateUrl(ref i_Url);
                HtmlWeb web = new HtmlWeb();
                return await web.LoadFromWebAsync(i_Url);
            }
            catch (UriFormatException)
            {
            }
            catch (HtmlWebException)
            {
                Console.WriteLine($"the website :{i_Url} is not responding");
            }

            return null;
        }

        private void ValidateUrl(ref string i_Url)
        {
            if (i_Url == string.Empty)
            {
                throw new InvalidOperationException("Given url is Empty");
            }

            if (!i_Url.Contains("http"))
            {
                string uri = string.Format("http://" + i_Url);

                i_Url = uri;
            }
        }
    }
}