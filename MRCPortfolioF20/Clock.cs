using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRCPortfolioF20
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }
        //Author: Michael Carroll
        //Date: December 17, 2020
        //Summary:
        //Clock project. Displays the current time and 24 hour time and the date
        //Displays a picture of the sun if it is before 7pm and a moon if it is after 7pm
        //On button click converts the current 12 hour time to Base2


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Each time the timer ticks, it will call each method and update the time
            string Time = GetTime(DateTime.Now.ToString(), DateTime.Now.ToString(), DateTime.Now.ToString(), DateTime.Now.ToString());
            string MilTime = ConvertToMilitary(Time);
            string Date = yankDate(DateTime.Now.ToString());

            DisplayTimeDate(Time, MilTime, Date);

            if (button1.Text == "Base10")
            {
                convertB2B10();
            }

            this.Text = DisplayMarquee(this.Text);
        }

        private string GetTime(string pHour, string pMin, string pSec, string pMeridian)
        {
            //this method calls each "yank" method, and concatenates the resulting string values
            //and returns the current time
            string time = yankHour(pHour) + ":" + yankMinute(pMin) + ":" + yankSecond(pSec) + " " + yankAMPM(pMeridian);
            return time;
        }

        private string yankHour (string pHour)
        {
            //this method returns the hour
            string hour = "";
            int i = 0;
            while (pHour.Substring(i, 1) != " ")
            {
                i++;
            }

            while (pHour.Substring(i, 1) != ":")
            {
                hour += pHour.Substring(i, 1);
                i++;
            }
            return hour;
        }

        private string yankMinute (string pMin)
        {
            //this method returns the minute
            string min = "";
            int i = 0;
            while (pMin.Substring(i, 1) != ":")
            {
                i++;
            }
            i++;

            min = pMin.Substring(i, 2);
            return min;
        }

        private string yankSecond (string pSec)
        {
            //this method returns the second
            string sec = pSec.Substring(pSec.Length - 5, 2);
            return sec;
        }

        private string yankAMPM (string pMeridian)
        {
            //this method returns the meridian
            string AMPM = pMeridian.Substring(pMeridian.Length - 2, 2);
            return AMPM;
        }

        private string yankDate (string pDate)
        {
            //this method returns the date
            string date = "";
            int i = 0;
            while (pDate.Substring(i, 1) != " ")
            {
                date += pDate.Substring(i, 1);
                i++;
            }
            return date;
        }

        private string ConvertToMilitary(string pMil)
        {
            //this method converts the hour to military
            string temp = "";
            int i = 0;
            while (pMil.Substring(i, 1) != ":")
            {
                temp += pMil.Substring(i, 1);
                i++;
            }

            int a = Convert.ToInt32(temp);
            string AMPM = pMil.Substring(pMil.Length - 2, 2);

            if (AMPM == "AM" && a == 12)
            {
                a = 0;
            }
            else
            {
                if (AMPM == "PM" && a == 12)
                {
                    a = 12;
                }
                else
                {
                    if (AMPM == "PM")
                    {
                        a = a + 12;
                    }
                }
            }
            string convertedHour = a.ToString();
            return convertedHour;
        }

        private void DisplayTimeDate (string pTime, string pMil, string pDate)
        {
            //this method concatenates the converted military time with the minute and second,
            //then displays the time, converted time, and date
            string MilDt = "";
            int i = 0;
            
            while (pTime.Substring(i, 1) != ":")
            {
                i++;
            }

            while(pTime.Substring(i, 1) != " ")
            {
                MilDt += pTime.Substring(i, 1);
                i++;
            }
            MilDt = pMil + MilDt;

            label1.Text = pTime;
            label2.Text = MilDt;
            label3.Text = pDate;
        }

        private void convertB2B10()
        {
            //this method converts the time to Base2 from base 10
            int Hour = Convert.ToInt32(yankHour(DateTime.Now.ToString()));
            int Minute = Convert.ToInt32(yankMinute(DateTime.Now.ToString()));
            int Second = Convert.ToInt32(yankSecond(DateTime.Now.ToString()));

            const int divisor = 2;
            int dividend = Hour;
            int quotient;
            int remainder;
            string base2Val = "";

            while (dividend != 0)
            {
                quotient = (int)dividend / divisor;
                remainder = dividend % divisor;
                base2Val = remainder.ToString() + base2Val;
                dividend = quotient;
            }
            string B2Hr = base2Val;
            base2Val = "";

            dividend = Minute;
            while (dividend != 0)
            {
                quotient = (int)dividend / divisor;
                remainder = dividend % divisor;
                base2Val = remainder.ToString() + base2Val;
                dividend = quotient;
            }
            string B2Min = base2Val;
            base2Val = "";

            dividend = Second;
            while (dividend != 0)
            {
                quotient = (int)dividend / divisor;
                remainder = dividend % divisor;
                base2Val = remainder.ToString() + base2Val;
                dividend = quotient;
            }
            string B2Sec = base2Val;

            base2Val = B2Hr + ":" + B2Min + ":" + B2Sec;
            label1.Text = base2Val;

        }

        private string DisplayMarquee(string p1)
        {
            //this method changes the string value in the title bar to give it a scrolling effect
            string last = p1.Substring(p1.Length - 1, 1);

            string outval = last + p1.Substring(0, 19);

            return outval;
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            //this displays the current times upon the form load
            string Hour = yankHour(DateTime.Now.ToString());
            string AMPM = yankAMPM(DateTime.Now.ToString());
            int ConvertedHour = Convert.ToInt32(Hour);


            if (ConvertedHour >= 7 && AMPM == "AM")
            {
                pictureBox1.Image = Image.FromFile("sun4.jpg");
            }
            else
            {
                if (ConvertedHour == 12 && AMPM == "PM")
                {
                    pictureBox1.Image = Image.FromFile("sun4.jpg");
                }
                else
                {
                    if (ConvertedHour < 7 && AMPM == "PM")
                    {
                        pictureBox1.Image = Image.FromFile("sun4.jpg");
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("moon.jpg");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on button click this calls the convert to Base2 method and changes the button text
            if (button1.Text == "Base2")
            {
                button1.Text = "Base10";
                convertB2B10();
            }
            else
            {
                if (button1.Text == "Base10")
                {

                    button1.Text = "Base2";
                }
            }
        }
    }
}
