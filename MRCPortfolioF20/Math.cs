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
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        //this form is a switch which lets you navigate to the Base2 Conversion,
        //the check prime, or the next prime pojects
        private void button9_Click(object sender, EventArgs e)
        {
            //base2 conversion project
            Base2Convert Objform = new Base2Convert();
            Objform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //check prime project
            CheckPrime Objform = new CheckPrime();
            Objform.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //next prime project
            NextPrime Objform = new NextPrime();
            Objform.Show();
        }
    }
}
