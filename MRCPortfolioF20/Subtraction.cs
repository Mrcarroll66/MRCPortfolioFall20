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
    public partial class Subtraction : Form
    {
        //declare class level variables
        private Random num = new Random();
        public Subtraction()
        {
            InitializeComponent();
        }

        //Form7 is the subtraction flashcard
        private void Form7_Load(object sender, EventArgs e)
        {
            //declare local variables and subtract
            int minuend = num.Next(0, 10);
            int subtrahend = num.Next(0, 10);
            int diff = minuend - subtrahend;
            //assign numbers to labels
            label1.Text = minuend.ToString();
            label2.Text = subtrahend.ToString();
            //show answer
            label3.Text = diff.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables and subtract
            int minuend = num.Next(0, 10);
            int subtrahend = num.Next(0, 10);
            int diff = minuend - subtrahend;
            //assign numbers to labels
            label1.Text = minuend.ToString();
            label2.Text = subtrahend.ToString();
            //show answer
            label3.Text = diff.ToString();
        }
    }
}
