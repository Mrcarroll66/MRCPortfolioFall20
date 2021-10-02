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
    public partial class DateandTime : Form
    {
        
        public DateandTime()
        {
            InitializeComponent();
        }
        
        //this is the version of the date/time project which uses event methods
       
        private void button2_Click(object sender, EventArgs e)
        {
            //this button click will pull the AM or PM from the DateTime.Now substring
            string dt = DateTime.Now.ToString();
            label1.Text = dt.Substring(dt.Length - 2, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this button click will pull the hour from the DateTime.Now substring
            string dt = DateTime.Now.ToString();
            int i = 0;
            while (dt.Substring(i, 1) != ":")
            {
                label1.Text = dt.Substring(i, 1);
                i++;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this button click will pull the date from the DateTime.Now substring
            label1.Text = "";
            string dt = DateTime.Now.ToString();
            int i = 0;

            while (dt.Substring(i, 1) != " ")
            {
                label1.Text += dt.Substring(i, 1);
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this button click will pull the second from the DateTime.Now substring
            string dt = DateTime.Now.ToString();
            label1.Text = dt.Substring(dt.Length -5, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this button click will pull the minute from the DateTime.Now substring
            string dt = DateTime.Now.ToString();
            int i = 0;
            
            while (dt.Substring(i, 1) != ":")
            {
                i++;
            }
            
            i++;
   
            label1.Text = dt.Substring(i, 2);
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
