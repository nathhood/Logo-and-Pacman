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
            
            BackColor = Color.Green; //change window background colour to green
            //countdowText.Text = ""; //change the countdown text to "go"
            countdowText.Visible = false;
            Refresh();

            formGraphics.FillEllipse(redBrush, 65, 70, 160, 110); //make the oval
            formGraphics.DrawString("C", BigFont, whiteBrush, 55, 55); //write the large 'c'

            formGraphics.DrawString("RAMS", MediumFont, whiteBrush, 115, 110); //write the medium sized font 'RAMS'

            formGraphics.TranslateTransform(230, 160); //to change where the screen starts
            formGraphics.RotateTransform(270); //to change the orientation of the screen
            formGraphics.DrawString("Central Rams Arcade", SmallFont, whiteBrush, new Rectangle()); //to write the sideways text
            formGraphics.ResetTransform(); //reset the screen orientaion and start
            Thread.Sleep(1000);
            
            BackColor = Color.Black;
            PacManButton.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void runPacManButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Allow fo graphics to be created
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow); //Create a white brush
            SolidBrush redBrush = new SolidBrush(Color.Red); //create a red brush
            Font BigFont = new Font("Times New Roman", 90, FontStyle.Bold); //create a font to use in the code
            Font MediumFont = new Font("Courier", 20, FontStyle.Bold); //create a second font to use int eh code
            Font SmallFont = new Font("Courier", 5, FontStyle.Bold); //create a third font to use in the code
            Pen bluePen = new Pen(Color.Blue, 5);

            //make the button go away and create the borders
            PacManButton.Visible = false;
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 0, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            
            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 20, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 20, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 40, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 40, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 60, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 60, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 80, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 80, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 100, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 100, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 120, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 120, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 140, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            formGraphics.FillPie(yellowBrush, 140, 30, 65, 65, 25, 300);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders, close mouth, and move forward
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 30, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 30, 65, 65, 25, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 50, 65, 65, 25, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 50, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 70, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 70, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 90, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 90, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 110, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 110, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 130, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 130, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 150, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 150, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 170, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 170, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 190, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 190, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 210, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 210, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 230, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 230, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 250, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 250, 65, 65, 120, 300);

            Thread.Sleep(200);


            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 270, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 270, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.Clear(Color.Black);

            //create the borders, close mouth, and move down
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);
            formGraphics.FillPie(yellowBrush, 160, 290, 65, 65, 120, 360);
            Thread.Sleep(200);

            formGraphics.Clear(Color.Black); //clear screen

            //create the borders
            formGraphics.DrawLine(bluePen, 0, 20, 230, 20);
            formGraphics.DrawLine(bluePen, 0, 100, 150, 100);
            formGraphics.DrawLine(bluePen, 230, 20, 230, 250);
            formGraphics.DrawLine(bluePen, 150, 100, 150, 250);

            //open the pacman mouth
            formGraphics.FillPie(yellowBrush, 160, 290, 65, 65, 120, 300);

            Thread.Sleep(200);

            formGraphics.DrawString("Conrtulatonz", MediumFont, yellowBrush, 50, 40);
        }
    }
}
