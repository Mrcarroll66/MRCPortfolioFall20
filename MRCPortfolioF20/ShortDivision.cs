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
    public partial class ShortDivision : Form
    {
        //declare class level variables
        private Random num = new Random();
        public ShortDivision()
        {
            InitializeComponent();
        }

        //Form9 is the short division flashcard
        private void Form9_Load(object sender, EventArgs e)
        {
            //declare local variables and divide
            int dividend = num.Next(1, 10);
            int divisor = num.Next(1, 10);
            int qotient = (int)(dividend / divisor);
            int remainder = dividend % divisor;
            //assign numbers to labels
            label1.Text = dividend.ToString();
            label2.Text = divisor.ToString();
            //show answer
            label3.Text = qotient.ToString();
            label7.Text = remainder.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables and divide
            int dividend = num.Next(1, 10);
            int divisor = num.Next(1, 10);
            int qotient = (int)(dividend / divisor);
            int remainder = dividend % divisor;
            //assign numbers to labels
            label1.Text = dividend.ToString();
            label2.Text = divisor.ToString();
            //show answer
            label3.Text = qotient.ToString();
            label7.Text = remainder.ToString();
        }
    }
}
