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
    public partial class Base2Convert : Form
    {
        public Base2Convert()
        {
            InitializeComponent();
        }

        //this project does a conversion from base 10 to base 2
        private void button1_Click(object sender, EventArgs e)
        {
            //first, make sure that the user input is in the correct integer type
            try
            {
                //a constant is used because we will always divide by 2
                const int divisor = 2;
                //declare local variables
                int dividend = Convert.ToInt32(textBox1.Text);
                int quotient;
                int remainder;
                string base2Val = "";
                //if dividend is greater than 0 then drop into this while loop
                if (dividend >= 0)
                {
                    //this loop divides and only a 1 or a 0 is kept
                    while (dividend != 0)
                    {
                        quotient = (int)dividend / divisor;
                        remainder = dividend % divisor;
                        base2Val = remainder.ToString() + base2Val;
                        dividend = quotient;
                    }
                    label2.Text = base2Val;
                }
                else
                {
                    MessageBox.Show("Input value must be greater than 0");
                }
            }
            catch
            {
                MessageBox.Show("Input Integer Value");
            }
        }

        private void Base2Convert_Load(object sender, EventArgs e)
        {

        }
    }
}
