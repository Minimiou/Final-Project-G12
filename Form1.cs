using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_G12
{
    public partial class frmMain : Form
    {
        Stream str = Properties.Resources.gameAudi;
        Stream buttonNoise = Properties.Resources.bleep1;
        Stream petNoise = Properties.Resources.bleep2;

        SoundPlayer snd;

        public static bool gameWin;
        public static bool petCleaned;

        int randopet;
        int seconds = 1;

        int food;
        int cleanliness;
        int times = 0;
        string hDirection = "r";
        string vDirection = "u";
        int x;
        int y;

        Random petGen = new Random();
        private Random randoMovement;

        Point location = Point.Empty;



        public frmMain()
        {
            InitializeComponent();
            
        }


        //Intro
        //And
        //Movement
        private void tmEggCrack_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 8)
            {
                imgEgg.Visible = false;
                imgEgg.Enabled = false;
            }

            imgPet.Top += y;
            imgPet.Left += x;

            if (hDirection == "r")
            {
                x = randoMovement.Next(0, 15);
            }
            else
            {
                x = randoMovement.Next(-15, 0);
            }

            if (vDirection == "u")
            {
                y = randoMovement.Next(-15, 0);
            }
            else
            {
                y = randoMovement.Next(0, 15);
            }

            if(imgPet.Right >= imgBorder.Right)
            {
                hDirection = "l";
            }
            else if (imgPet.Left <= imgBorder.Left)
            {
                hDirection = "r";
            }

            if (imgPet.Top <= imgBorder.Top)
            {
                vDirection = "d";
            }
            else if (imgPet.Bottom >= imgBorder.Bottom)
            {
                vDirection = "u";
            }
            if (imgHealth1.Visible == false && imgHealth2.Visible == false && imgHealth3.Visible == false)
            {
                tmEggCrack.Enabled = false;
                String message = "Your pet just died...That's sad... :)";
                string title = "OOF GameOver";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
                Close();
            }
            if (probarClean.Value == 100 && probarHappy.Value == 100 && probarFood.Value == 50)
            {
                tmEggCrack.Enabled = false;
                String message = "Your pet got bored and is now leaving...That's sad... :)";
                string title = "Good Job?";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
                Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            snd = new SoundPlayer(str);
            snd.PlayLooping();


            randoMovement = new Random();

            imgOption1.Enabled = false;
            imgOption2.Enabled = false;
            imgOption3.Enabled = false;

            food = probarFood.Step;
            cleanliness = probarFood.Step;

            probarFood.Minimum = 0;
            probarFood.Maximum = 50;
            probarFood.Step = 20;
            probarFood.Value = 0;

            probarClean.Minimum = 0;
            probarClean.Maximum = 100;
            probarClean.Step = 25;
            probarClean.Value = 100;

            btnClean.Enabled = false;
            frmClean.petClean = imgPet.Image;

            
        }


        private void imgReset_Click(object sender, EventArgs e)
        {
            randopet = (petGen.Next(1, 17));

            if (randopet == 1)
            {
                imgPet.Image = Properties.Resources.tinySad;
            }
            else if (randopet == 2)
            {
                imgPet.Image = Properties.Resources.purpleBlob;
                BackColor = Color.Lavender;
            }
            else if (randopet == 3)
            {
                imgPet.Image = Properties.Resources.bigSad;
                BackColor = Color.LightPink;
            }
            else if (randopet == 4)
            {
                imgPet.Image = Properties.Resources.blob2;
                BackColor = Color.HotPink;
            }
            else if (randopet == 5)
            {
                imgPet.Image = Properties.Resources.blob3;
                BackColor = Color.LightSteelBlue;
            }
            else if (randopet == 6)
            {
                imgPet.Image = Properties.Resources.blob4;
                BackColor = Color.PaleGoldenrod;
            }
            else if (randopet == 7)
            {
                imgPet.Image = Properties.Resources.blob5;
                BackColor = Color.Silver;
            }
            else if (randopet == 8)
            {
                imgPet.Image = Properties.Resources.blob6;
                BackColor = Color.MediumSlateBlue;
            }
            else if (randopet == 9)
            {
                imgPet.Image = Properties.Resources.blob7;
                BackColor = Color.Pink;
            }
            else if (randopet == 10)
            {
                imgPet.Image = Properties.Resources.blob8;
                BackColor = Color.Thistle;
            }
            else if (randopet == 11)
            {
                imgPet.Image = Properties.Resources.blob9;
                BackColor = Color.Thistle;
            }
            else if (randopet == 12)
            {
                imgPet.Image = Properties.Resources.blob10;
                BackColor = Color.SandyBrown;
            }
            else if (randopet == 13)
            {
                imgPet.Image = Properties.Resources.blob11;
                BackColor = Color.LightGoldenrodYellow;
            }
            else if (randopet == 14)
            {
                imgPet.Image = Properties.Resources.blob12;
                BackColor = Color.Black;
            }
            else if (randopet == 15)
            {
                imgPet.Image = Properties.Resources.blob12;
                BackColor = Color.LightPink;
            }
            else if (randopet == 16)
            {
                imgPet.Image = Properties.Resources.fushiaDragon;
                BackColor = Color.White;
                imgPet.SizeMode = PictureBoxSizeMode.Zoom;
            }
            frmClean.petClean = imgPet.Image;
            imgOption1.Enabled = false;
            imgOption2.Enabled = false;
            imgOption3.Enabled = false;

            food = probarFood.Step;


            probarFood.Value = 0;
            btnFood.Enabled = true;
            imgHealth1.Visible = true;
            imgHealth2.Visible = true;
            imgHealth3.Visible = true;
            probarHappy.Value = 0;
            btnGame.Enabled = true;
            probarFood.BackColor = Color.AliceBlue;
            probarFood.ForeColor = Color.Orange;
            probarClean.Value = 100;
            btnClean.Enabled = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            snd.Stop();
        }




        //
        //
        //FOOD
        private void btnFood_Click(object sender, EventArgs e)
        {
            imgOption1.Enabled = true;
            imgOption1.Image = Properties.Resources.Apple;
            imgOption1.Visible = true;
            imgOption2.Enabled = true;
            imgOption2.Image = Properties.Resources.Fish;
            imgOption2.Visible = true;
            imgOption3.Enabled = true;
            imgOption3.Image = Properties.Resources.Carrot;
            imgOption3.Visible = true;
            
        }

        private void imgOption1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location = new Point(e.X, e.Y);
            }
        }

        private void imgOption1_MouseMove(object sender, MouseEventArgs e)
        {
            if (location != Point.Empty)
            {
                Point newlocation = this.imgOption1.Location;
                newlocation.X += e.X - location.X;
                newlocation.Y += e.Y - location.Y;
                this.imgOption1.Location = newlocation;
            }
        }

        private void imgOption1_MouseUp(object sender, MouseEventArgs e)
        {
            location = Point.Empty;
            if (imgPet.Bounds.Contains(imgOption1.Bounds))
            {
                if (probarFood.Value + food <= probarFood.Maximum)
                    probarFood.Value += food;
                else
                    probarFood.Value = probarFood.Maximum;

            }
            imgOption1.Location = new Point(60, 293);
            if (probarFood.Value == probarFood.Maximum)
            {
                probarFood.BackColor = Color.Orange;
                probarFood.ForeColor = Color.Red;
                btnFood.Enabled = false;
                imgOption1.Enabled = false;
                imgOption2.Enabled = false;
                imgOption3.Enabled = false;
                imgOption1.Visible = false;
                imgOption2.Visible = false;
                imgOption3.Visible = false;
                imgHealth1.Visible = false;

                String message = "You overfed your pet, it lost health! It won't let you feed it anymore :(";
                string title = "-1 Health";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
                
            }
        }
        
        private void imgOption2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location = new Point(e.X, e.Y);
            }
        }

        private void imgOption2_MouseMove(object sender, MouseEventArgs e)
        {
            if (location != Point.Empty)
            {
                Point newlocation = this.imgOption2.Location;
                newlocation.X += e.X - location.X;
                newlocation.Y += e.Y - location.Y;
                this.imgOption2.Location = newlocation;
            }
        }

        private void imgOption2_MouseUp(object sender, MouseEventArgs e)
        {
            location = Point.Empty;
            if (imgPet.Bounds.Contains(imgOption2.Bounds))
            {
                if (probarFood.Value + food <= probarFood.Maximum)
                    probarFood.Value += food;
                else
                    probarFood.Value = probarFood.Maximum;
                
            }
            imgOption2.Location = new Point(171, 293);
            if (probarFood.Value == probarFood.Maximum)
            {
                probarFood.BackColor = Color.Orange;
                probarFood.ForeColor = Color.Red;
                btnFood.Enabled = false;
                imgOption1.Enabled = false;
                imgOption2.Enabled = false;
                imgOption3.Enabled = false;
                imgOption1.Visible = false;
                imgOption2.Visible = false;
                imgOption3.Visible = false;
                imgHealth1.Visible = false;
                btnFood.Cursor = Cursors.No;
                String message = "You overfed your pet, it lost health! It won't let you feed it anymore :(";
                string title = "-1 Health";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
        }

        private void imgOption3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location = new Point(e.X, e.Y);
            }
        }

        private void imgOption3_MouseMove(object sender, MouseEventArgs e)
        {
            if (location != Point.Empty)
            {
                Point newlocation = this.imgOption3.Location;
                newlocation.X += e.X - location.X;
                newlocation.Y += e.Y - location.Y;
                this.imgOption3.Location = newlocation;
            }
        }

        private void imgOption3_MouseUp(object sender, MouseEventArgs e)
        {
            location = Point.Empty;
            if (imgPet.Bounds.Contains(imgOption3.Bounds))
            {
                if (probarFood.Value + food <= probarFood.Maximum)
                    probarFood.Value += food;
                else
                    probarFood.Value = probarFood.Maximum;
               
            }
            imgOption3.Location = new Point(278, 293);
            if (probarFood.Value == probarFood.Maximum)
            {
                probarFood.BackColor = Color.Orange;
                probarFood.ForeColor = Color.Red;
                btnFood.Enabled = false;
                imgOption1.Enabled = false;
                imgOption2.Enabled = false;
                imgOption3.Enabled = false;
                imgOption1.Visible = false;
                imgOption2.Visible = false;
                imgOption3.Visible = false;
                imgHealth1.Visible = false;
                String message = "You overfed your pet, it lost health! It won't let you feed it anymore :(";
                string title = "-1 Health";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
        }





        private void btnFood_MouseEnter(object sender, EventArgs e)
        {
       
        }



        // that game where you drag a character at the bottom  and it catches falling foods
        //GAME

        private void btnGame_Click(object sender, EventArgs e)
        {
            bool result;
            frmGame miniGame = new frmGame();
            miniGame.BackColor = this.BackColor;
            miniGame.ShowDialog();

            if (frmMain.gameWin == true)
            {
                
                btnGame.Enabled = false;
                MessageBox.Show("Your pet played a lot and is now happy but dirty!");
                probarClean.Value = 25;
                btnClean.Enabled = true;
                probarHappy.Value = 100;
            }
            else
            {
                imgHealth2.Visible = false;
                String message = "Your pet is sad and dirty!";
                string title = "-1 Health";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
                probarClean.Value = 25;
                btnClean.Enabled = true;
            }
        }

        private void btnFood_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            bool result2;
            frmClean petCleaning = new frmClean();
            petCleaning.BackColor = this.BackColor;
            petCleaning.ShowDialog();

            if (frmMain.petCleaned == true)
            {
                MessageBox.Show("Your pet is clean and happy!");
                probarClean.Value = 100;
                btnClean.Enabled = false;
            }
            else
            {
                imgHealth3.Visible = false;
                String message = "Your pet is sad and dirty!";
                string title = "-1 Health";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
                probarClean.Value = 0;
                btnClean.Enabled = true;
            }
        }
    }
}
