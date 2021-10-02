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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }
        //Form12 is the Fibonacci Sequence project
        //it will generate the fibonacci sequence and add it to a list box
        private void Form12_Load(object sender, EventArgs e)
        {
            //this will populate a combo box with numbers from 1 - 250
            for (int x = 1; x <= 250; x += 1)
            {
                comboBox1.Items.Add(x.ToString());

            }
            comboBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button 2 clears the listbox
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1 adds the correct numbers in the sequence to the listbox up to the number selected by the user
            int fib1 = 0;
            int fib2 = 1;
            int Curfib;
            listBox1.Items.Add(fib1.ToString());
            int limit = Convert.ToInt32(comboBox1.Text) - 2;

            for (int x = 0; x <= limit; x++)
            {
                Curfib = fib1 + fib2;
                listBox1.Items.Add(Curfib.ToString());
                fib1 = fib2;
                fib2 = Curfib;
            }
        }
    }
}
