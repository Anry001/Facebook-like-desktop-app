using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Zodiac
    {
        private eZodiacSigns m_ZodiacSign;

        public Zodiac(string i_BirthDay)
        {
            checkZodiac(i_BirthDay);
        }

        public eZodiacSigns ZodiacSign
        {
            get { return m_ZodiacSign; }
        }

        private void checkZodiac(string i_BirthDay)
        {
            string[] date = i_BirthDay.Split('/');

            findZodiac(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]));
        }

        private void findZodiac(int i_Month, int i_Day)
        {
            if (((i_Month == 03) && (i_Day >= 21 && i_Day <= 31)) || ((i_Month == 04) && (i_Day >= 01 && i_Day <= 20)))
            {
                m_ZodiacSign = eZodiacSigns.Aries;
            }

            if (((i_Month == 04) && (i_Day >= 21 && i_Day <= 31)) || ((i_Month == 05) && (i_Day >= 01 && i_Day <= 20)))
            {
                m_ZodiacSign = eZodiacSigns.Taurus;
            }

            if (((i_Month == 05) && (i_Day >= 21 && i_Day <= 31)) || ((i_Month == 06) && (i_Day >= 01 && i_Day <= 21)))
            {
                m_ZodiacSign = eZodiacSigns.Gemini;
            }

            if (((i_Month == 06) && (i_Day >= 22 && i_Day <= 31)) || ((i_Month == 07) && (i_Day >= 01 && i_Day <= 22)))
            {
                m_ZodiacSign = eZodiacSigns.Cancer;
            }

            if (((i_Month == 07) && (i_Day >= 23 && i_Day <= 31)) || ((i_Month == 08) && (i_Day >= 01 && i_Day <= 22)))
            {
                m_ZodiacSign = eZodiacSigns.Leo;
            }

            if (((i_Month == 08) && (i_Day >= 23 && i_Day <= 31)) || ((i_Month == 09) && (i_Day >= 01 && i_Day <= 22)))
            {
                m_ZodiacSign = eZodiacSigns.Virgo;
            }

            if (((i_Month == 09) && (i_Day >= 23 && i_Day <= 31)) || ((i_Month == 10) && (i_Day >= 01 && i_Day <= 23)))
            {
                m_ZodiacSign = eZodiacSigns.Libra;
            }

            if (((i_Month == 10) && (i_Day >= 24 && i_Day <= 31)) || ((i_Month == 11) && (i_Day >= 01 && i_Day <= 21)))
            {
                m_ZodiacSign = eZodiacSigns.Scorpio;
            }

            if (((i_Month == 11) && (i_Day >= 22 && i_Day <= 31)) || ((i_Month == 12) && (i_Day >= 01 && i_Day <= 21)))
            {
                m_ZodiacSign = eZodiacSigns.Sagittarius;
            }

            if (((i_Month == 12) && (i_Day >= 22 && i_Day <= 31)) || ((i_Month == 01) && (i_Day >= 01 && i_Day <= 20)))
            {
                m_ZodiacSign = eZodiacSigns.Capricornus;
            }

            if (((i_Month == 01) && (i_Day >= 21 && i_Day <= 31)) || ((i_Month == 02) && (i_Day >= 01 && i_Day <= 18)))
            {
                m_ZodiacSign = eZodiacSigns.Aquarius;
            }

            if (((i_Month == 02) && (i_Day >= 19 && i_Day <= 31)) || ((i_Month == 03) && (i_Day >= 01 && i_Day <= 20)))
            {
                m_ZodiacSign = eZodiacSigns.Pisces;
            }
        }
    }
}