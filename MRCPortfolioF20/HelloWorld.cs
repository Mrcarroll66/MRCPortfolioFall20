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
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        //Form4 is the hello world project, which writes hello world on a button click
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //back to form 3
            this.Dispose();
        }
    }
}
