namespace Final_Project_G12
{
    partial class frmClean
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
            this.tmdust = new System.Windows.Forms.Timer(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgTool1 = new System.Windows.Forms.PictureBox();
            this.imgDust2 = new System.Windows.Forms.PictureBox();
            this.imgDust3 = new System.Windows.Forms.PictureBox();
            this.imgDust1 = new System.Windows.Forms.PictureBox();
            this.imgPet1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTool1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDust2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDust3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDust1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Roland", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(135, 317);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(204, 63);
            this.lblInstructions.TabIndex = 8;
            this.lblInstructions.Text = "Use the soap bellow to clean up the dirt!";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgTool1
            // 
            this.imgTool1.Image = global::Final_Project_G12.Properties.Resources.cursor1;
            this.imgTool1.Location = new System.Drawing.Point(187, 391);
            this.imgTool1.Name = "imgTool1";
            this.imgTool1.Size = new System.Drawing.Size(100, 50);
            this.imgTool1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTool1.TabIndex = 5;
            this.imgTool1.TabStop = false;
            this.imgTool1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTool1_MouseDown);
            // 
            // imgDust2
            // 
            this.imgDust2.BackColor = System.Drawing.Color.Transparent;
            this.imgDust2.Image = global::Final_Project_G12.Properties.Resources.e1dc796e63ada74f2d9cc16d0fd29acd;
            this.imgDust2.Location = new System.Drawing.Point(341, 176);
            this.imgDust2.Name = "imgDust2";
            this.imgDust2.Size = new System.Drawing.Size(140, 122);
            this.imgDust2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDust2.TabIndex = 4;
            this.imgDust2.TabStop = false;
            this.imgDust2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDust2_MouseDown);
            // 
            // imgDust3
            // 
            this.imgDust3.BackColor = System.Drawing.Color.Transparent;
            this.imgDust3.Image = global::Final_Project_G12.Properties.Resources.e1dc796e63ada74f2d9cc16d0fd29acd1;
            this.imgDust3.Location = new System.Drawing.Point(0, 317);
            this.imgDust3.Name = "imgDust3";
            this.imgDust3.Size = new System.Drawing.Size(132, 118);
            this.imgDust3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDust3.TabIndex = 3;
            this.imgDust3.TabStop = false;
            this.imgDust3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDust3_MouseDown);
            // 
            // imgDust1
            // 
            this.imgDust1.BackColor = System.Drawing.Color.Transparent;
            this.imgDust1.Image = global::Final_Project_G12.Properties.Resources.e1dc796e63ada74f2d9cc16d0fd29acd;
            this.imgDust1.Location = new System.Drawing.Point(0, 174);
            this.imgDust1.Name = "imgDust1";
            this.imgDust1.Size = new System.Drawing.Size(140, 122);
            this.imgDust1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDust1.TabIndex = 2;
            this.imgDust1.TabStop = false;
            this.imgDust1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDust1_MouseDown);
            // 
            // imgPet1
            // 
            this.imgPet1.BackColor = System.Drawing.Color.Transparent;
            this.imgPet1.Location = new System.Drawing.Point(138, 121);
            this.imgPet1.Name = "imgPet1";
            this.imgPet1.Size = new System.Drawing.Size(204, 198);
            this.imgPet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPet1.TabIndex = 0;
            this.imgPet1.TabStop = false;
            this.imgPet1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgPet1_MouseMove);
            // 
            // frmClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.imgPet1);
            this.Controls.Add(this.imgTool1);
            this.Controls.Add(this.imgDust2);
            this.Controls.Add(this.imgDust3);
            this.Controls.Add(this.imgDust1);
            this.Controls.Add(this.lblInstructions);
            this.DoubleBuffered = true;
            this.Name = "frmClean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClean";
            this.Load += new System.EventHandler(this.frmClean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTool1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDust2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDust3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDust1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPet1;
        private System.Windows.Forms.PictureBox imgDust1;
        private System.Windows.Forms.Timer tmdust;
        private System.Windows.Forms.PictureBox imgDust3;
        private System.Windows.Forms.PictureBox imgDust2;
        private System.Windows.Forms.PictureBox imgTool1;
        private System.Windows.Forms.Label lblInstructions;
    }
}