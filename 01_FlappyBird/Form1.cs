using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speed = 8;
        int yercekim = 15;
        int skor = 0;

        private void GameTimerEvent(object sender, EventArgs e)
        {
            flappy.Top += yercekim;
            altkolon.Left -= speed;
            ustkolon.Left -= speed;
            label1.Text = skor.ToString();
            
            if (altkolon.Left < -150)
            {
                altkolon.Left = 300;
                skor++;
            }

            if (ustkolon.Left< -180)
            {
                ustkolon.Left = 350;
                skor++;
            }

            if (flappy.Bounds.IntersectsWith(altkolon.Bounds) ||   //eğer flappy Alt boruya değerse 
                flappy.Bounds.IntersectsWith(ustkolon.Bounds) || // eğer flappy üst boruya değerse 
                flappy.Bounds.IntersectsWith(zemin.Bounds) || flappy.Top <-25  )   // flappy zemine değerse 
            {
                EndGame();
            }

            if (skor> 7)
            {
                speed = 16;
            }
        }

        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yercekim = -15;
            }
        }

        private void gameKeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
               yercekim = 15;
            }
        }

        public void EndGame()
        {
            timer.Stop();
            MessageBox.Show("Your score : {0} Game Over!!!", skor.ToString());
        }

       
    }
}
