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
    public partial class DateTimePrivate : Form
    {
        public DateTimePrivate()
        {
            InitializeComponent();
        }

        //this is the private method version of the Date/Time project
        private void button1_Click(object sender, EventArgs e)
        {
            //the first button click calls the GetDate method and displays the date
            label1.Text = GetDate(DateTime.Now.ToString());
        }

        private string GetDate (string p1)
        {
            //this method pulls the date from the substring of the DateTime.Now
            string Date = "";
            int i = 0;

            while (p1.Substring(i, 1) != " ")
            {
                Date += p1.Substring(i, 1);
                i++;
            }
            return Date;
        }

        //this method pulls the hour from the substring of the DateTime.Now
        private string GetHour (string p1)
        {
            string Hour = "";
            int i = 0;
            while (p1.Substring(i, 1) != ":")
            {
                Hour = p1.Substring(i, 1);
                i++;

            }
            return Hour;
        }

        //this method pulls the minute from the substring of the DateTime.Now
        private string GetMinute (string p1)
        {
            string Minute = "";
            int i = 0;

            while (p1.Substring(i, 1) != ":")
            {
                i++;
            }

            i++;

            Minute = p1.Substring(i, 2);

            return Minute;
        }

        //this method pulls the second from the substring of the DateTime.Now
        private string GetSecond (string p1)
        {
            string Second = p1.Substring(p1.Length - 5, 2);
            return Second;
        }

        //this method pulls the AM or PM from the substring of the DateTime.Now
        private string GetMeridian (string p1)
        {
            string Meridian = p1.Substring(p1.Length - 2, 2);
            return Meridian;
        }

        //button 5 will call the GetHour method and display the hour
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = GetHour(DateTime.Now.ToString());
        }

        //button 4 will call the GetMinute method and display the minute
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = GetMinute(DateTime.Now.ToString());
        }

        //button 5 will call the GetSecond method and display the second
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = GetSecond(DateTime.Now.ToString());
        }

        //button 5 will call the GetMeridian method and display the AM or PM
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = GetMeridian(DateTime.Now.ToString());
        }
    }
}
