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
    public partial class Form1 : Form
    {
        //declare the class level variables
        private Random Rnd = new Random();
        private int Counter = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this declares a local variable of a random number and assigns it to the label
            //then disbales button1, and enables button2
            int CurrentVal = Rnd.Next(1, 7);
            label2.Text = CurrentVal.ToString();
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //change form text
            this.Text = "# Left: " + Counter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //each of these if statements corresponds to a black box and a number
            //if 1 is recieved, the first box turns blue, and so on
            //this could be done with 6 if statements or a switch statement

            if ((label2.Text == "1") && (pictureBox1.BackColor == Color.Black))
            {
                pictureBox1.BackColor = Color.Blue;
                Counter--;
            }
            if ((label2.Text == "2") && (pictureBox2.BackColor == Color.Black))
            {
                pictureBox2.BackColor = Color.Blue;
                Counter--;
            }
            if ((label2.Text == "3") && (pictureBox3.BackColor == Color.Black))
            {
                pictureBox3.BackColor = Color.Blue;
                Counter--;
            }
            if ((label2.Text == "4") && (pictureBox4.BackColor == Color.Black))
            {
                pictureBox4.BackColor = Color.Blue;
                Counter--;
            }
            if ((label2.Text == "5") && (pictureBox5.BackColor == Color.Black))
            {
                pictureBox5.BackColor = Color.Blue;
                Counter--;
            }
            if ((label2.Text == "6") && (pictureBox6.BackColor == Color.Black))
            {
                pictureBox6.BackColor = Color.Blue;
                Counter--;
            }
            //after it decides which box to change, it disables the GO button and enables the ROLL button
            this.Text = "# Left: " + Counter;
            button2.Enabled = false;
            button1.Enabled = true;
            //if all the boxes are blue, it disables the ROLL button
            if (Counter == 0)
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this is the reset button, it resets the form to what it was just after load
            button1.Enabled = true;
            Counter = 6;
            this.Text = "# Left: " + Counter;
            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            label2.Text = "?";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Dispose();
        }
    }
}
