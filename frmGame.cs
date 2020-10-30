using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_G12
{
    public partial class frmGame : Form
    {

        int seconds;
        int second;
        int x;
        int y = 10;
        int score = 0;
        int y2 = 13;
        int y3 = 16;
        int randoCandy;
        int win;
        Random generator = new Random();



        //get the pet to be the same
        public frmGame()
        {
            InitializeComponent();
        }


        private void frmGame_Load(object sender, EventArgs e)
        {
            randoCandy = (generator.Next(1, 7));
            
            if (randoCandy == 1)
            {
                imgCandy.Top = 150;
                imgCandy.Left = 30;
                imgCandy2.Top = 115;
                imgCandy2.Left = 340;
                imgCandy3.Top = 30;
                imgCandy3.Left = 100;
            }
            else if (randoCandy == 2)
            {
                imgCandy.Top = 160;
                imgCandy.Left = 40;
                imgCandy2.Top = 55;
                imgCandy2.Left = 110;
                imgCandy3.Top = 125;
                imgCandy3.Left = 350;
            }
            else if (randoCandy == 3)
            {
                imgCandy.Top = 30;
                imgCandy.Left = 100;
                imgCandy2.Top = 125;
                imgCandy2.Left = 350;
                imgCandy3.Top = 160;
                imgCandy3.Left = 40;

            }
            else if (randoCandy == 4)
            {
                imgCandy.Top = 55;
                imgCandy.Left = 110;
                imgCandy2.Top = 30;
                imgCandy2.Left = 100;
                imgCandy3.Top = 160;
                imgCandy3.Left = 40;
            }
            else if (randoCandy == 5)
            {
                imgCandy.Top = 115;
                imgCandy.Left = 340;
                imgCandy2.Top = 150;
                imgCandy2.Left = 30;
                imgCandy3.Top = 160;
                imgCandy3.Left = 40;

            }
            else if (randoCandy == 6)
            {
                imgCandy.Top = 125;
                imgCandy.Left = 350;
                imgCandy2.Top = 150;
                imgCandy2.Left = 30;
                imgCandy3.Top = 150;
                imgCandy3.Left = 30;
            }
            if (imgCandy.Top > 590)
            {
                imgHealth.Visible = false;
            }
            else if (imgCandy2.Top > 590)
            {
                imgHealth2.Visible = false;
            }
            else if (imgCandy3.Top > 590)
            {
                imgHealth3.Visible = false;
            }
            
        }

        private void candyLocation(int candy)
        {
            if (candy == 1)
            {
                if (randoCandy == 1)
                {
                    imgCandy.Top = 150;
                    imgCandy.Left = 30;

                }
                else if (randoCandy == 2)
                {
                    imgCandy.Top = 160;
                    imgCandy.Left = 40;

                }
                else if (randoCandy == 3)
                {
                    imgCandy.Top = 30;
                    imgCandy.Left = 100;


                }
                else if (randoCandy == 4)
                {
                    imgCandy.Top = 55;
                    imgCandy.Left = 110;

                }
                else if (randoCandy == 5)
                {
                    imgCandy.Top = 115;
                    imgCandy.Left = 340;


                }
                else if (randoCandy == 6)
                {
                    imgCandy.Top = 125;
                    imgCandy.Left = 350;

                }
            }
            
            if (candy == 2)
            {
                if (randoCandy == 1)
                {
                    imgCandy2.Top = 115;
                    imgCandy2.Left = 340;

                }
                else if (randoCandy == 2)
                {

                    imgCandy2.Top = 55;
                    imgCandy2.Left = 110;

                }
                else if (randoCandy == 3)
                {

                    imgCandy2.Top = 125;
                    imgCandy2.Left = 350;


                }
                else if (randoCandy == 4)
                {

                    imgCandy2.Top = 30;
                    imgCandy2.Left = 100;

                }
                else if (randoCandy == 5)
                {

                    imgCandy2.Top = 150;
                    imgCandy2.Left = 30;


                }
                else if (randoCandy == 6)
                {

                    imgCandy2.Top = 150;
                    imgCandy2.Left = 30;

                }
            }
            if (candy ==3)
            {
                if (randoCandy == 1)
                {

                    imgCandy3.Top = 30;
                    imgCandy3.Left = 100;
                }
                else if (randoCandy == 2)
                {

                    imgCandy3.Top = 125;
                    imgCandy3.Left = 350;
                }
                else if (randoCandy == 3)
                {

                    imgCandy3.Top = 160;
                    imgCandy3.Left = 40;

                }
                else if (randoCandy == 4)
                {
                    imgCandy3.Top = 160;
                    imgCandy3.Left = 40;
                }
                else if (randoCandy == 5)
                {

                    imgCandy3.Top = 160;
                    imgCandy3.Left = 40;

                }
                else if (randoCandy == 6)
                {

                    imgCandy3.Top = 150;
                    imgCandy3.Left = 30;
                }
            }
            
        }


        private void tmCandyDropper_Tick(object sender, EventArgs e)
        {
            
            seconds++;
            imgCandy.Top += y;
            imgCandy2.Top += y2;
            imgCandy3.Top += y3;
            randoCandy = (generator.Next(1, 7));

            if (imgPet.Bounds.IntersectsWith(imgCandy.Bounds))
            {
                score += 1;
                lblScore.Text = "Score: " + score;
                y += 5;
                candyLocation(1);
            }
            if (imgPet.Bounds.IntersectsWith(imgCandy2.Bounds))
            {
                score += 1;
                lblScore.Text = "Score: " + score;
                y += 5;
                candyLocation(2);

            }
            if (imgPet.Bounds.IntersectsWith(imgCandy3.Bounds))
            {
                score += 1;
                lblScore.Text = "Score: " + score;
                y += 5;
                candyLocation(3);
            }

            if (imgCandy.Top > 590)
            {
                imgHealth.Visible = false;
            }
            if (imgCandy2.Top > 590)
            {
                imgHealth2.Visible = false;
            }
            if (imgCandy3.Top > 590)
            {
                imgHealth3.Visible = false;
            }
            if (score >= 15)
            {
                lblEnd.Visible = true;
                imgEnd.Visible = true;
                tmCandyDropper.Enabled = false;
                tmEnd.Enabled = true;

                win = 1;
            }
            if (!imgHealth.Visible && !imgHealth2.Visible && !imgHealth3.Visible)
            {
                tmCandyDropper.Enabled = false;
                imgEnd.Image = Properties.Resources.gameover;
                lblEnd.Text = "You lost!";
                lblEnd.Visible = true;
                imgEnd.Visible = true;
                tmEnd.Enabled = true;
                
            }
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                imgPet.Left = imgPet.Left + 15;
            }
            else if (e.KeyCode == Keys.Left)
            {
                imgPet.Left = imgPet.Left - 15;
            }
            if (imgPet.Right >= ClientSize.Width)
            {
                imgPet.Left = imgPet.Left - 20;
            }
            if (imgPet.Left <= 0)
            {
                imgPet.Left = imgPet.Left + 20;
            }


        }

        private void tmEnd_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 5)
            {
                if (score >= 15)
                    frmMain.gameWin = true;
                else
                    frmMain.gameWin = false;
                tmEnd.Enabled = false;

                this.Close();

            }
        }
    }
}
