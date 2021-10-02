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
    public partial class NextPrime : Form
    {
        public NextPrime()
        {
            InitializeComponent();
        }


        //this is the next prime project
        //it will accept user input, then find the next prime number
        private void button1_Click(object sender, EventArgs e)
        {
            //check if the user input an integer
            try
            {
                //declare local variables
                bool Prime = false;
                int divisor = 2;
                int remainder = 0;
                int n = Convert.ToInt32(textBox1.Text);
                //decision logic to find the next prime number
                if (n > 1)
                {
                    while (Prime == false)
                    {
                        n++;
                        remainder = n % divisor;
                        while (divisor < n && remainder != 0)
                        {
                            remainder = n % divisor;
                            divisor++;
                        }
                        if (divisor == n)
                        {
                            Prime = true;
                        }
                        divisor = 2;
                    }
                    label3.Text = n.ToString();
                }
                else
                {
                    MessageBox.Show("Enter Value Greater than 1");
                }


            }
            catch
            {
                MessageBox.Show("ERR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //resets the form
            textBox1.Text = "";
            label3.Text = "";
        }
    }
}
