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
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
        }
        //Form2 is the about me page which includes information about me
        private void button1_Click(object sender, EventArgs e)
        {
            //close about me
            this.Dispose();
        }
    }
}
