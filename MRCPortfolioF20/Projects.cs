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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        //Form3 is the Projects page where you can navigate to my projects
        private void button1_Click(object sender, EventArgs e)
        {
            //show hello world
            HelloWorld Objform4 = new HelloWorld();
            Objform4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //back to form 1
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show flash cards
            Form5 Objform5 = new Form5();
            Objform5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //show house
            House Objform10 = new House();
            Objform10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //show game v2
            Form11 Objform11 = new Form11();
            Objform11.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //show fibonacci
            Fibonacci Objform12 = new Fibonacci();
            Objform12.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //show game v1
            Form1 Objform = new Form1();
            Objform.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //show math projects
            Math Objform = new Math();
            Objform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //show date/time projects
            EventOrPrivate Objform = new EventOrPrivate();
            Objform.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //show 24 hour conversion
            _24Hr Objform = new _24Hr();
            Objform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //show clock project
            Clock Objform = new Clock();
            Objform.Show();
        }
    }
}
