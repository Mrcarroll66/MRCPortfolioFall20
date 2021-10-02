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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //Form5 is the Flashcards v1. project, which includes flashcards for addition, subtraction, multiplication, and division.
        private void button6_Click(object sender, EventArgs e)
        {
            //back to projects
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open addition flashcard
            Addition Objform6 = new Addition();
            Objform6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Open subtraction flashcard
            Subtraction Objform7 = new Subtraction();
            Objform7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Open multiplication flashcard
            Multiplication Objform8 = new Multiplication();
            Objform8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Open short division flashcard
            ShortDivision Objform9 = new ShortDivision();
            Objform9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Open long division flashcard
            LongDivision Objform14 = new LongDivision();
            Objform14.Show();
        }
    }
}
