namespace SpaceShoot
{
    partial class Form1
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
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.pbShip = new System.Windows.Forms.PictureBox();
            this.pbStars = new System.Windows.Forms.PictureBox();
            this.pbStars2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::SpaceShoot.Properties.Resources.player_img;
            this.pbPlayer.Location = new System.Drawing.Point(200, 366);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(46, 45);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbAlien
            // 
            this.pbAlien.Image = global::SpaceShoot.Properties.Resources.alien_gif;
            this.pbAlien.Location = new System.Drawing.Point(47, 52);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(60, 60);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAlien.TabIndex = 1;
            this.pbAlien.TabStop = false;
            this.pbAlien.Tag = "enemy";
            // 
            // pbShip
            // 
            this.pbShip.Image = global::SpaceShoot.Properties.Resources.ship_gif;
            this.pbShip.Location = new System.Drawing.Point(339, 98);
            this.pbShip.Name = "pbShip";
            this.pbShip.Size = new System.Drawing.Size(50, 27);
            this.pbShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbShip.TabIndex = 2;
            this.pbShip.TabStop = false;
            this.pbShip.Tag = "enemy";
            // 
            // pbStars
            // 
            this.pbStars.Image = global::SpaceShoot.Properties.Resources.Stars_img;
            this.pbStars.Location = new System.Drawing.Point(2, 24);
            this.pbStars.Name = "pbStars";
            this.pbStars.Size = new System.Drawing.Size(462, 188);
            this.pbStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStars.TabIndex = 3;
            this.pbStars.TabStop = false;
            this.pbStars.Tag = "stars";
            // 
            // pbStars2
            // 
            this.pbStars2.Image = global::SpaceShoot.Properties.Resources.Stars_img;
            this.pbStars2.Location = new System.Drawing.Point(12, 285);
            this.pbStars2.Name = "pbStars2";
            this.pbStars2.Size = new System.Drawing.Size(472, 164);
            this.pbStars2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStars2.TabIndex = 4;
            this.pbStars2.TabStop = false;
            this.pbStars2.Tag = "stars";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 27);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(112, 225);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(252, 57);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "GameOver";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbShip);
            this.Controls.Add(this.pbAlien);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbStars);
            this.Controls.Add(this.pbStars2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceShoot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.PictureBox pbShip;
        private System.Windows.Forms.PictureBox pbStars;
        private System.Windows.Forms.PictureBox pbStars2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
    }
}

