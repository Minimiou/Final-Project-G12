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
    public partial class frmStart : Form
    {
        Stream str = Properties.Resources.startAudi;

        public frmStart()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            String message = "This program might be broken...Proceed?";
            string title = "Warning!";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //It will open the program
            }
            else
            {
                Close();
            }

            SoundPlayer snd = new SoundPlayer(str);
            snd.PlayLooping();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(str);
            snd.Stop();

            //Opens the game
            Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
