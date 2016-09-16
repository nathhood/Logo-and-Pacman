//This program is created by Nathan Hood
//This program is created for starting a game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//changes comment for testing GitHub

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {         
            InitializeComponent();
            PacManButton.Visible = false;
        }

        private void PlayButtonHoverOff(object sender, EventArgs e) //change the button when hovered on with mouse
        {
            playButton.BackColor = Color.Green;
        }

        private void PlayButtonHoverOn(object sender, EventArgs e) //change back to original button when not hovered on with mouse
        {
            playButton.BackColor = Color.Black;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer three = new SoundPlayer(Properties.Resources.three); //designate the sound file three
            SoundPlayer two = new SoundPlayer(Properties.Resources.two); //designate the sound file two
            SoundPlayer one = new SoundPlayer(Properties.Resources.one); //designate the sound file one
                                                                        
            Graphics formGraphics = this.CreateGraphics(); //Allow fo graphics to be created
            SolidBrush whiteBrush = new SolidBrush(Color.White); //Create a white brush
            SolidBrush redBrush = new SolidBrush(Color.Red); //create a red brush
            Font BigFont = new Font("Times New Roman", 90, FontStyle.Bold); //create a font to use in the code
            Font MediumFont = new Font("Courier", 20, FontStyle.Bold); //create a second font to use int eh code
            Font SmallFont = new Font("Courier", 5, FontStyle.Bold); //create a third font to use in the code

            
            playButton.Visible = false; //hide the button after clicked
            
            /*
            countdowText.Text = "Game Will Start in: 3"; //change the countdown text to "Game Will Start in 3"
            three.Play(); //play the sound file three
            Refresh();
            Thread.Sleep(1000); //pause for 1 second

            countdowText.Text = "Game Will Start in: 2"; //change the countdown text to "Game Will Start in 2"
            two.Play(); //play the sound file two
            Refresh();
            Thread.Sleep(1000); //pause for 1 second

            countdowText.Text = "Game Will Start in: 1"; //change the countdown text to "Game Will Start in 1"
            one.Play(); //play the sound file one
            Refresh();
            Thread.Sleep(1000); //pause for 1 second
            */
            BackColor = Color.Green; //change window background colour to green
            //countdowText.Text = ""; //change the countdown text to "go"
            countdowText.Visible = false;
            Refresh();

            /*formGraphics.FillEllipse(redBrush, 65, 70, 160, 110); //make the oval
            formGraphics.DrawString("C", BigFont, whiteBrush, 55, 55); //write the large 'c'

            formGraphics.DrawString("RAMS", MediumFont, whiteBrush, 115, 110); //write the medium sized font 'RAMS'

            formGraphics.TranslateTransform(230, 160); //to change where the screen starts
            formGraphics.RotateTransform(270); //to change the orientation of the screen
            formGraphics.DrawString("Central Rams Arcade", SmallFont, whiteBrush, new Rectangle()); //to write the sideways text
            formGraphics.ResetTransform(); //reset the screen orientaion and start
            Thread.Sleep(1000);
            */
            BackColor = Color.Black;
            PacManButton.Visible = true;

        }

        /*private void Form1_Load(object sender, EventArgs e)
        {

        }*/

        private void runPacManButton_Click(object sender, EventArgs e)
        {





        }
    }
}
