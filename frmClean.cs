using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_G12
{
    public partial class frmClean : Form
    {
        public static System.Drawing.Image petClean;

        Random randoDust = new Random();
        int dustLocation;
        int dirtCleaned = 0;
        int cursorNum = 0;

        public frmClean()
        {
            InitializeComponent();
        }

        private void frmClean_Load(object sender, EventArgs e)
        {
            imgPet1.Image = frmClean.petClean;
            dustPlacement();
            dustPlacement2();
            dustPlacement3();
        }
                   
        private void dustPlacement()
        {
            dustLocation = (randoDust.Next(1, 4));
            if (dustLocation == 1)
            {
                imgDust1.Top = 0;
                imgDust1.Left = 0;
            }
            else if (dustLocation == 2)
            {
                imgDust1.Top = 0;
                imgDust1.Left = 333;
            }
            else if (dustLocation == 3)
            {
                imgDust1.Top = 174;
                imgDust1.Left = 345;
            }
        }
        private void dustPlacement2()
        {
            dustLocation = (randoDust.Next(1, 4));
            if (dustLocation == 1)
            {
                imgDust2.Top = 200;
                imgDust2.Left = 0;
            }
            else if (dustLocation == 2)
            {
                imgDust2.Top = 0;
                imgDust2.Left = 200;
            }
            else if (dustLocation == 3)
            {
                imgDust2.Top = 0;
                imgDust2.Left = 200;
            }
        }
        private void dustPlacement3()
        {
            dustLocation = (randoDust.Next(1, 4));
            if (dustLocation == 1)
            {
                imgDust3.Top = 400;
                imgDust3.Left = 0;
            }
            else if (dustLocation == 2)
            {
                imgDust3.Top = 0;
                imgDust3.Left = 400;
            }
            else if (dustLocation == 3)
            {
                imgDust3.Top = 405;
                imgDust3.Left = 0;
            }
        }

        private void imgPet_Click(object sender, EventArgs e)
        {

        }

        private void imgPet1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void imgTool1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Properties.Resources.cursor1.GetHicon());
            cursorNum = 1;
        }

        private void imgDust1_MouseDown(object sender, MouseEventArgs e)
        {
            if (cursorNum == 1)
            {
                dirtCleaned += 1;
                dustPlacement();
            }
            if (dirtCleaned == 9)
            {
                frmMain.petCleaned = true;
                Close();
            }
            else
            {
                frmMain.petCleaned = false;
            }
        }

        private void imgDust2_MouseDown(object sender, MouseEventArgs e)
        {
            if (cursorNum == 1)
            {
                dirtCleaned += 1;
                dustPlacement2();
            }
            if (dirtCleaned == 9)
            {
                frmMain.petCleaned = true;
                Close();
            }
            else
            {
                frmMain.petCleaned = false;
            }
        }

        private void imgDust3_MouseDown(object sender, MouseEventArgs e)
        {
            if (cursorNum == 1)
            {
                dirtCleaned += 1;
                dustPlacement3();
            }
            if (dirtCleaned == 9)
            {
                frmMain.petCleaned = true;
                Close();
            }
            else
            {
                frmMain.petCleaned = false;
            }
        }
    }
}
