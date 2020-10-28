using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.codeproject.com/Questions/639545/How-to-drag-a-picture-box-on-winForms-at-runtime-i
//https://www.reddit.com/r/csharp/comments/4f6pje/how_do_you_make_a_hp_bar/

namespace Final_Project_G12
{
    public partial class frmMain : Form
    {
        Stream str = Properties.Resources.gameAudi;
        int randopet;
        SoundPlayer snd;

        int seconds = 1;

        int food;
        int cleanliness;

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

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            snd = new SoundPlayer(str);
            snd.PlayLooping();

            randoMovement = new Random();

            imgOption1.Enabled = false;
            imgOption2.Enabled = false;
            imgOption3.Enabled = false;
            //Color BarColor = Color.AliceBlue;
            food = probarFood.Step;

            probarFood.Minimum = 0;
            probarFood.Maximum = 50;
            probarFood.Step = 20;
            probarFood.Value = 0;
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
                BackColor = Color.LightPink;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            snd.Stop();
        }

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
                probarFood.BackColor = Color.Red;
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
                probarFood.BackColor = Color.Red;
                btnFood.Enabled = false;
                imgOption1.Enabled = false;
                imgOption2.Enabled = false;
                imgOption3.Enabled = false;
                imgOption1.Visible = false;
                imgOption2.Visible = false;
                imgOption3.Visible = false;
                imgHealth2.Visible = false;
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
                probarFood.BackColor = Color.Red;
                btnFood.Enabled = false;
                imgOption1.Enabled = false;
                imgOption2.Enabled = false;
                imgOption3.Enabled = false;
                imgOption1.Visible = false;
                imgOption2.Visible = false;
                imgOption3.Visible = false;
                imgHealth3.Visible = false;
                String message = "You overfed your pet, it lost health! It won't let you feed it anymore :(";
                string title = "-1 Health";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
        }
    }
}
