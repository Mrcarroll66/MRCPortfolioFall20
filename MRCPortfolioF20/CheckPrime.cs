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
    public partial class CheckPrime : Form
    {
        public CheckPrime()
        {
            InitializeComponent();
        }
        //this project will check the user's input to determine if it is prime or composite
        private void button1_Click(object sender, EventArgs e)
        {
            //check if the user input an integer
            try
            {
                bool isPrime = true;
                int count = 2;
                int rem = 0;
                int n = Convert.ToInt32(textBox1.Text);
                //use decision logic to do all the necessary conversion steps
                if (n > 1)
                {
                    while ((count < n) && (isPrime == true))
                    {
                        rem = n % count;
                        if (rem == 0)
                        {
                            isPrime = false;
                        }
                        count++;
                    }
                    //if true it's prime
                    if (isPrime == true)
                    {
                        MessageBox.Show("Prime");
                    }
                    //otherwise it's composite
                    else
                    {
                        MessageBox.Show("Composite");
                    }
                }
                //the input must be greater than 1
                else
                {
                    MessageBox.Show("Enter Value Greater than 1");
                }
            }
            //show message if the input is not an integer
            catch
            {
                MessageBox.Show("ERR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
