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
    public partial class EventOrPrivate : Form
    {
        public EventOrPrivate()
        {
            InitializeComponent();
        }

        //from this form you can navigate to the Date/Time project,
        //either the version which uses private methods, or the version which uses event methods
        private void button10_Click(object sender, EventArgs e)
        {
            //event methods
            DateandTime Objform = new DateandTime();
            Objform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //private methods
            DateTimePrivate Objform = new DateTimePrivate();
            Objform.Show();
        }
    }
}
