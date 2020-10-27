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

namespace Final_Project_G12
{
    public partial class frmMain : Form
    {
        Stream str = Properties.Resources.gameAudi;

        int seconds = 0;
        int food;
        int cleanliness;
        int xBorder = 417;
        int yBorder = 503;

        Random petGen = new Random();

        int randopet;


        private Random randoMovement;

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

            randoMovement = new Random();

            int x = randoMovement.Next(0, 15);
            int y = randoMovement.Next(0, 15);
            imgPet.Top += y;
            imgPet.Left += x;

            if (imgPet.Bottom > yBorder)
            {
                imgPet.Top -= y;
            }
            else if(imgPet.Right > xBorder)
            {
                imgPet.Left -= x;
            }

            if (imgPet.Top < 10)
            {
                imgPet.Top += y;
            }
            else if (imgPet.Left < 10)
            {
                imgPet.Left += x;
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(str);
            snd.PlayLooping();

            randopet = (petGen.Next(1, 15));

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

        }


        private void imgReset_Click(object sender, EventArgs e)
        {
            frmMain NewForm = new frmMain();
            NewForm.Show();
            Dispose(false);
        }
    }
}
