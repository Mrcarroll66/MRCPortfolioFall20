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
    public partial class Multiplication : Form
    {
        //declare class level variables
        private Random num = new Random();
        public Multiplication()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Form8 is the multiplication flashcard
        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables and multiply
            int factor1 = num.Next(0, 10);
            int factor2 = num.Next(0, 10);
            int product = factor1 * factor2;
            //assign numbers to labels
            label1.Text = factor1.ToString();
            label2.Text = factor2.ToString();
            //show answer
            label3.Text = product.ToString();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //declare local variables and multiply
            int factor1 = num.Next(0, 10);
            int factor2 = num.Next(0, 10);
            int product = factor1 * factor2;
            //assign numbers to labels
            label1.Text = factor1.ToString();
            label2.Text = factor2.ToString();
            //show answer
            label3.Text = product.ToString();
        }
    }
}
