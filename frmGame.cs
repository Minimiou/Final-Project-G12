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
        public frmGame()
        {
            InitializeComponent();
            int win = 1;
            int loose = 2;
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            
            
        }

        private void tmCandyDropper_Tick(object sender, EventArgs e)
        {
            seconds++;
            imgCandy.Top += y;
            imgCandy.Left += x;

        }
    }
}
