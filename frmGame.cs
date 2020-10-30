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
        //frmMain frm2;
        int seconds = 0;

        int x ;
        int y ;
        public frmGame()
        {
            InitializeComponent();
            int win = 1;
            int loose = 2;
            //imgPet.Image = frmMain.imgPet.Image;

        }


        private void frmGame_Load(object sender, EventArgs e)
        {
            //imgPet.Image = frmMain.imgPet.Image;
        }

        private void tmCandyDropper_Tick(object sender, EventArgs e)
        {
            
            seconds++;
            imgCandy.Top += y;
           //imgCandy.Left += x;
           
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                imgPet.Left = imgPet.Left + 10;
            }
            else if (e.KeyCode == Keys.Left)
            {
                imgPet.Left = imgPet.Left - 10;
            }
            //if (imgPet.Right >= ClientSize.Width)
            //{
            //    imgPet.Left = imgPet.Left - 20;
            //}
            //if (imgPet.Left <= ClientSize.Width)
            //{
            //    imgPet.Left = imgPet.Left + 20;
            //}


        }
    }
}
