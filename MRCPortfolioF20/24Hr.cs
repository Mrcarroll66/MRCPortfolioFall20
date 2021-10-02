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
    public partial class _24Hr : Form
    {
        public _24Hr()
        {
            InitializeComponent();
        }
        //Class level variable that will be used throught the project
        private string ConvertedHour = "";

        //this project lets a user input a 12 hour time and it will convert that to the 24 hour time

        //this is a private method that returns true if the number that the user had input is between 1 and 12
        private bool VerifyHour(string pHr)
        {
            bool ValidHour = true;
            try
            {
                int Hour = Convert.ToInt32(pHr);
                if ((Hour > 12) || (Hour < 1))
                {
                    ValidHour = false;
                }
            }
            catch
            {
                ValidHour = false;
            }
            return ValidHour;
        }

        //This private method will take the user's input and attempt to convert it to upper so that it is either AM or PM
        //if it can, it will return true
        private bool VerifyMeridian(string pMeridian)
        {
            bool ValidMeridian = false;
            try
            {
                pMeridian = textBox2.Text.ToUpper();
                if ((pMeridian == "AM") || (pMeridian == "PM"))
                {
                    ValidMeridian = true;
                }
            }
            catch
            {
                ValidMeridian = false;
            }
            return ValidMeridian;
        }

        //This private method converts the time to 24 hour time
        //it uses decision logic to decide whether to add 12 to the original hour
        //it also turns the background black if it is PM time and yellow if AM
        private string ConvertTime(int pHr, string pMeridian)
        {

            if ((pHr == 12) && (pMeridian == "AM"))
            {
                pHr = 0;
                ConvertedHour = pHr.ToString() + ":00";
                label4.BackColor = Color.Yellow;
                label4.ForeColor = Color.Black;
            }
            else
            {
                if ((pHr == 12) && (pMeridian == "PM"))
                {
                    pHr = 12;
                    ConvertedHour = pHr.ToString() + ":00";
                    label4.BackColor = Color.Black;
                    label4.ForeColor = Color.Yellow;
                }
                else
                {

                    if (pMeridian == "PM")
                    {
                        pHr = pHr + 12;
                        ConvertedHour = pHr.ToString() + ":00";
                        label4.BackColor = Color.Black;
                        label4.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        ConvertedHour = pHr.ToString() + ":00";
                        label4.BackColor = Color.Yellow;
                        label4.ForeColor = Color.Black;
                    }
                }
            }
            return ConvertedHour;
        }

        //this button click calls all the previous methods
        private void button1_Click(object sender, EventArgs e)
        {
            bool Hour = VerifyHour(textBox1.Text);
            bool Meridian = VerifyMeridian(textBox2.Text.ToUpper());
            if ((Hour) && (Meridian))
            {
                ConvertedHour = ConvertTime(Convert.ToInt32(textBox1.Text), textBox2.Text.ToUpper());
                label4.Text = ConvertedHour;
            }
        }

        //this button click clears the text boxes and label
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            label4.BackColor = Color.LightYellow;
        }
    }
}
