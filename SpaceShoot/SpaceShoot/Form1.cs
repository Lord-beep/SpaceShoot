﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShoot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblGameOver.Hide();
          
        }


        bool right, left, space;
        int score;
        void Game_Result()
        {
            foreach(Control j in this.Controls)
            {
                foreach(Control i in this.Controls)
                {
                    if(j is PictureBox && j.Tag == "bullet")
                    {
                        if(i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resources.explosion;
                                score++;
                                lblScore.Text = "Score : " + score;
                            }
                        }
                    }
                }
            }

            if(pbPlayer.Bounds.IntersectsWith(pbShip.Bounds) || pbPlayer.Bounds.IntersectsWith(pbAlien.Bounds))
            {
                timer1.Stop();
                lblGameOver.Show();
                lblGameOver.BringToFront();
            }
        }

        void Star()
        {
            foreach(Control j in this.Controls)
            {
                if(j is PictureBox && j.Tag == "stars")
                {
                    j.Top += 10;
                    if(j.Top > 400)
                    {
                        j.Top = 0;
                    }
                }
            }
        }

        void Add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.bullet_img;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = pbPlayer.Left + 15;
            bullet.Top = pbPlayer.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        void Bullet_Movement()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if(x.Top<100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }
        void Enemy_Movement()
        {
            Random rnd = new Random();
            int x, y;
            if (pbAlien.Top >= 500)
            {
                x = rnd.Next(0,300);
                pbAlien.Location = new Point(x, 0);
            }
            if (pbShip.Top >= 500)
            {
                y = rnd.Next(0,300);
                pbShip.Location = new Point(y, 0);
            }
            else
            {
                pbAlien.Top += 15;
                pbShip.Top += 10;
            }

        }
        void Arrow_Key_Movment()
        {
            if (right == true)
            {
                if (pbPlayer.Left < 425)
                {
                    pbPlayer.Left += 20;
                }
            }

            if (left == true)
            {
                if (pbPlayer.Left > 10)
                {
                    pbPlayer.Left -= 20;
                }
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();
            }   
        }

    

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_Key_Movment();
            Enemy_Movement();
            Bullet_Movement();
            Star();
            Game_Result();
        }


    }
}
