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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        //Author: Michael Carroll
        //Date of last edit: October 20, 2020
        //Discription: This is my portfolio program for CPSC 1400
        //It includes all the projects that we worked on in the class
        //Form1 is the welcome form, from which you can navigate to the about me page, or the projects page
        private void button4_Click(object sender, EventArgs e)
        {
           //show aboutme form
            AboutMe objForm = new AboutMe();
            objForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Exit program
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //show projects form
            Projects objForm3 = new Projects();
            objForm3.Show();
        }
    }
}
