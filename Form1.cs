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

        Random petGen = new Random();
        Random locationGen = new Random();
        int randopet;
        int randoLocationNum;

        public frmMain()
        {
            InitializeComponent();
            //location();
        }



        private void tmEggCrack_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 8)
            {
                imgEgg.Visible = false;
            }
            randoLocationNum = (locationGen.Next(1));


            if (imgPet.Location.Y >= imgBorder.Location.Y)
            {
                SuspendLayout();
                imgPet.Location = new Point(imgPet.Location.Y - randoLocationNum);
                ResumeLayout();
            }
            else if (imgPet.Location.Y <= imgBorder.Location.Y)
            {
                SuspendLayout();
                imgPet.Location = new Point(imgPet.Location.Y + randoLocationNum);
                ResumeLayout();
            }
            if (imgPet.Location.X >= imgBorder.Location.X)
            {
                SuspendLayout();
                imgPet.Location = new Point(imgPet.Location.X - randoLocationNum);//   , imgPet.Location.Y + randoLocationNum);
                ResumeLayout();
            }
            else if (imgPet.Location.X <= imgBorder.Location.X)
            {
                SuspendLayout();
                imgPet.Location = new Point(imgPet.Location.X + randoLocationNum);
                ResumeLayout();
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
                BackColor = Color.Navy;
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


            int x = imgPet.Location.X;
            int y = imgPet.Location.Y;
            randoLocationNum = (locationGen.Next(30));

            for (int i = 1; i < x; i++)
            {
                x = x + randoLocationNum;
            }
            for (int i = 1; i < y; i++)
            {
                y = y + randoLocationNum;
            }



        }

        private void location()
        {
            int x = imgPet.Location.X;
            int y = imgPet.Location.Y;
            randoLocationNum = (locationGen.Next(30));

            for (int i = 1; i < x; i++)
            {
                x = x + randoLocationNum;
            }
            for (int i = 1; i < y; i++)
            {
                y = y + randoLocationNum;
            }
        }




    }
}
