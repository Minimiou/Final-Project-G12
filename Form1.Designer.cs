namespace Final_Project_G12
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.probarFood = new System.Windows.Forms.ProgressBar();
            this.probarHappy = new System.Windows.Forms.ProgressBar();
            this.probarClean = new System.Windows.Forms.ProgressBar();
            this.btnFood = new System.Windows.Forms.Button();
            this.tmEggCrack = new System.Windows.Forms.Timer(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.imgEgg = new System.Windows.Forms.PictureBox();
            this.imgPet = new System.Windows.Forms.PictureBox();
            this.imgOption1 = new System.Windows.Forms.PictureBox();
            this.imgOption2 = new System.Windows.Forms.PictureBox();
            this.imgOption3 = new System.Windows.Forms.PictureBox();
            this.imgBorder = new System.Windows.Forms.PictureBox();
            this.imgReset = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOption2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOption3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // probarFood
            // 
            this.probarFood.BackColor = System.Drawing.Color.MidnightBlue;
            this.probarFood.ForeColor = System.Drawing.Color.Gold;
            this.probarFood.Location = new System.Drawing.Point(46, 73);
            this.probarFood.Name = "probarFood";
            this.probarFood.Size = new System.Drawing.Size(84, 23);
            this.probarFood.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.probarFood.TabIndex = 0;
            // 
            // probarHappy
            // 
            this.probarHappy.BackColor = System.Drawing.Color.MidnightBlue;
            this.probarHappy.ForeColor = System.Drawing.Color.GreenYellow;
            this.probarHappy.Location = new System.Drawing.Point(157, 73);
            this.probarHappy.Name = "probarHappy";
            this.probarHappy.Size = new System.Drawing.Size(84, 23);
            this.probarHappy.TabIndex = 1;
            // 
            // probarClean
            // 
            this.probarClean.BackColor = System.Drawing.Color.MidnightBlue;
            this.probarClean.Location = new System.Drawing.Point(266, 73);
            this.probarClean.Name = "probarClean";
            this.probarClean.Size = new System.Drawing.Size(84, 23);
            this.probarClean.TabIndex = 2;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.LightBlue;
            this.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFood.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFood.Location = new System.Drawing.Point(46, 349);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(84, 30);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = false;
            // 
            // tmEggCrack
            // 
            this.tmEggCrack.Enabled = true;
            this.tmEggCrack.Interval = 980;
            this.tmEggCrack.Tick += new System.EventHandler(this.tmEggCrack_Tick);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightBlue;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClean.Location = new System.Drawing.Point(266, 349);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(84, 30);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // imgEgg
            // 
            this.imgEgg.Image = global::Final_Project_G12.Properties.Resources.egg;
            this.imgEgg.Location = new System.Drawing.Point(371, -1);
            this.imgEgg.Name = "imgEgg";
            this.imgEgg.Size = new System.Drawing.Size(402, 468);
            this.imgEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEgg.TabIndex = 6;
            this.imgEgg.TabStop = false;
            // 
            // imgPet
            // 
            this.imgPet.BackColor = System.Drawing.Color.Transparent;
            this.imgPet.Image = global::Final_Project_G12.Properties.Resources.purpleBlob;
            this.imgPet.Location = new System.Drawing.Point(157, 143);
            this.imgPet.Name = "imgPet";
            this.imgPet.Size = new System.Drawing.Size(84, 90);
            this.imgPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPet.TabIndex = 7;
            this.imgPet.TabStop = false;
            // 
            // imgOption1
            // 
            this.imgOption1.Location = new System.Drawing.Point(46, 270);
            this.imgOption1.Name = "imgOption1";
            this.imgOption1.Size = new System.Drawing.Size(84, 50);
            this.imgOption1.TabIndex = 8;
            this.imgOption1.TabStop = false;
            // 
            // imgOption2
            // 
            this.imgOption2.Location = new System.Drawing.Point(157, 270);
            this.imgOption2.Name = "imgOption2";
            this.imgOption2.Size = new System.Drawing.Size(84, 50);
            this.imgOption2.TabIndex = 9;
            this.imgOption2.TabStop = false;
            // 
            // imgOption3
            // 
            this.imgOption3.Location = new System.Drawing.Point(266, 270);
            this.imgOption3.Name = "imgOption3";
            this.imgOption3.Size = new System.Drawing.Size(84, 50);
            this.imgOption3.TabIndex = 10;
            this.imgOption3.TabStop = false;
            // 
            // imgBorder
            // 
            this.imgBorder.Location = new System.Drawing.Point(46, 102);
            this.imgBorder.Name = "imgBorder";
            this.imgBorder.Size = new System.Drawing.Size(304, 229);
            this.imgBorder.TabIndex = 11;
            this.imgBorder.TabStop = false;
            // 
            // imgReset
            // 
            this.imgReset.BackColor = System.Drawing.Color.Transparent;
            this.imgReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgReset.Location = new System.Drawing.Point(150, 421);
            this.imgReset.Name = "imgReset";
            this.imgReset.Size = new System.Drawing.Size(38, 32);
            this.imgReset.TabIndex = 12;
            this.imgReset.TabStop = false;
            this.imgReset.Click += new System.EventHandler(this.imgReset_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Final_Project_G12.Properties.Resources.health;
            this.pictureBox5.Location = new System.Drawing.Point(187, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Final_Project_G12.Properties.Resources.health;
            this.pictureBox6.Location = new System.Drawing.Point(318, 46);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.LightBlue;
            this.btnGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGame.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGame.Location = new System.Drawing.Point(157, 349);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(84, 30);
            this.btnGame.TabIndex = 15;
            this.btnGame.Text = "Games";
            this.btnGame.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::Final_Project_G12.Properties.Resources.frame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 460);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.imgPet);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.imgReset);
            this.Controls.Add(this.imgEgg);
            this.Controls.Add(this.imgOption3);
            this.Controls.Add(this.imgOption2);
            this.Controls.Add(this.imgOption1);
            this.Controls.Add(this.imgBorder);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.probarClean);
            this.Controls.Add(this.probarHappy);
            this.Controls.Add(this.probarFood);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Pet V-0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOption2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOption3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar probarFood;
        private System.Windows.Forms.ProgressBar probarHappy;
        private System.Windows.Forms.ProgressBar probarClean;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.PictureBox imgEgg;
        private System.Windows.Forms.Timer tmEggCrack;
        private System.Windows.Forms.PictureBox imgPet;
        private System.Windows.Forms.PictureBox imgOption1;
        private System.Windows.Forms.PictureBox imgOption2;
        private System.Windows.Forms.PictureBox imgOption3;
        private System.Windows.Forms.PictureBox imgBorder;
        private System.Windows.Forms.PictureBox imgReset;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnGame;
    }
}

