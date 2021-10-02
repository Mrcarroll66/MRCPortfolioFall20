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
    public partial class House : Form
    {
        //class level variables
        private int SwitchFlip = 0;
        private Random FailChance = new Random();
        public House()
        {
            InitializeComponent();
        }
        
        //Form10 is the House project
        //The house project is the first project with decision logic
        //the user presses the "ON" button and it changes the picture boxes (windows) from black to yellow (on to off)
        //However, there is a 40% chance that on the button click, the light bulb will blow and the lights will go out.
        //The lights will also go out if the button has been pressed 10 times.
        private void button1_Click(object sender, EventArgs e)
        {
            //local variable
            int BulbDie = FailChance.Next(1, 11);

            //first decision checks if the switch is in the on or off position
            if (button1.Text == "ON")
            {
                SwitchFlip++;
                pictureBox1.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.Yellow;
                button1.Text = "OFF";
                
                //This if statement will evaluate true if the button has been pressed 10 times
                //it will blow the lights
                if (SwitchFlip == 10)
                {
                    pictureBox1.BackColor = Color.Black;
                    pictureBox2.BackColor = Color.Black;
                    button1.Enabled = false;
                    button3.Enabled = true;
                    MessageBox.Show("Light Bulb is Dead");

                }
                //This if statement will evaluate true if the random number is 4 or less
                //(40% chance for the bulb to blow)
                //it will blow the lights
                if (BulbDie <= 4)
                {

                    pictureBox1.BackColor = Color.Black;
                    pictureBox2.BackColor = Color.Black;
                    button1.Enabled = false;
                    button3.Enabled = true;
                    MessageBox.Show("Light Bulb is Dead");
                }
            }
            //If the lights are on this will turn them off
            else
            {
                
                pictureBox1.BackColor = Color.Black;
                pictureBox2.BackColor = Color.Black;
                button1.Text = "ON";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //this resets everything
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            button1.Text = "OFF";
            button1.Enabled = true;
            button3.Enabled = false;
            SwitchFlip = 0;
        }
    }
}
