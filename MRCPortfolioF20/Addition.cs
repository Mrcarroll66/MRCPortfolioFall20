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
    public partial class Addition : Form
    {
        //declare class level variables
        private Random num = new Random();
        public Addition()
        {
            InitializeComponent();
        }
        
        //Form6 is the addition flashcard
        private void Form6_Load(object sender, EventArgs e)
        {
           //declare local variables
            int addend1 = num.Next(0, 10);
            int addend2 = num.Next(0, 10);
            int sum = addend1 + addend2;
            //assign number to label
            label1.Text = addend1.ToString();
            label2.Text = addend2.ToString();
            //show answer
            label3.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables
            int addend1 = num.Next(0, 10);
            int addend2 = num.Next(0, 10);
            int sum = addend1 + addend2;
            //assign number to label
            label1.Text = addend1.ToString();
            label2.Text = addend2.ToString();
            //display result
            label3.Text = sum.ToString();
        }
    }
}
