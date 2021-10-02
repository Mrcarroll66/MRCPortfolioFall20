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
    public partial class LongDivision : Form
    {
        //declare class level variable
        private Random num = new Random();
        public LongDivision()
        {
            InitializeComponent();
        }

        private void LongDivision_Load(object sender, EventArgs e)
        {
            //declare local variables and divide
            int dividend = num.Next(1, 26);
            int divisor = num.Next(1, 10);
            int qotient = (int)(dividend / divisor);
            int remainder = dividend % divisor;
            //assign numbers to labels
            label2.Text = dividend.ToString();
            label1.Text = divisor.ToString();
            //show answer
            label5.Text = qotient.ToString();
            label7.Text = remainder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables and divide
            int dividend = num.Next(1, 26);
            int divisor = num.Next(1, 10);
            int qotient = (int)(dividend / divisor);
            int remainder = dividend % divisor;
            //assign numbers to labels
            label2.Text = dividend.ToString();
            label1.Text = divisor.ToString();
            //show answer
            label5.Text = qotient.ToString();
            label7.Text = remainder.ToString();
        }
    }
}
