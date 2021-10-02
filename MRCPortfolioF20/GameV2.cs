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
    public partial class Form11 : Form
    {
        //declare the class level variables
        private Random Rnd = new Random();
        private int Counter = 6;
        private int RollVal;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Text = "# Left: " + Counter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Author: Michael Carroll
            //Date: 9/30/2020

            //Overview: 
            //this program has a series of 6 black boxes which all turn blue 
            //after recieving a corresponding number
            //a random number is generated and turns corresponding box blue
            //after all boxes turn blue, the program ends

            //this declares a local variable of a random number and assigns it to the label
            //then disbales button1, and enables button2
            RollVal = Rnd.Next(1, 7);
            label2.Text = RollVal.ToString();
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //this code will divide the random number by 6, and keep the remainder.
            //the remainder will be used in a switch statement, in order to determine where to place pictureBox7,
            //and which pictureBox to change the color of
            int rem;
            rem = RollVal % 6;

            switch (rem)
            {
                case 1:
                    pictureBox7.Location = pictureBox1.Location;
                    if (pictureBox1.BackColor == Color.Black)
                    {
                        pictureBox1.BackColor = Color.Blue;
                        Counter--;
                        this.Text = "# Left: " + Counter;
                    }
                    break;
                case 2:
                    pictureBox7.Location = pictureBox2.Location;
                    if (pictureBox2.BackColor == Color.Black)
                    {
                        pictureBox2.BackColor = Color.Blue;
                        Counter--;
                        this.Text = "# Left: " + Counter;
                    }
                    break;
                case 3:
                    pictureBox7.Location = pictureBox3.Location;
                    if (pictureBox3.BackColor == Color.Black)
                    {
                        pictureBox3.BackColor = Color.Blue;
                        Counter--;
                        this.Text = "# Left: " + Counter;
                    }
                    break;
                case 4:
                    pictureBox7.Location = pictureBox4.Location;
                    if (pictureBox4.BackColor == Color.Black)
                    {
                        pictureBox4.BackColor = Color.Blue;
                        Counter--;
                        this.Text = "# Left: " + Counter;
                    }
                    break;
                case 5:
                    pictureBox7.Location = pictureBox5.Location;
                    if (pictureBox5.BackColor == Color.Black)
                    {
                        pictureBox5.BackColor = Color.Blue;
                        Counter--;
                        this.Text = "# Left: " + Counter;
                    }
                    break;
                case 0:
                    pictureBox7.Location = pictureBox6.Location;
                    if (pictureBox6.BackColor == Color.Black)
                    {
                        pictureBox6.BackColor = Color.Blue;
                        Counter--;
                        this.Text = "# Left: " + Counter;
                    }
                    break;
            }
            
            //this enables the roll button and disables the go button
            button1.Enabled = true;
            button2.Enabled = false;
            //this if statement disables the roll button if the variable Counter is equal to 0
            if (Counter == 0)
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button 3 is the reset button. when this button is pressed, it resets the form to its
            //original state
            button1.Enabled = true;
            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.Location = new Point(110, 250);
            Counter = 6;
            this.Text = "# Left: " + Counter;
            label2.Text = "?";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this will close the form
            this.Dispose();
        }
    }
}
