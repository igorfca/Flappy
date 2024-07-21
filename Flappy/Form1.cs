using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Flappy : Form
    {
        int pipeSpeed = 7;
        int gravity = 12;
        int scoreG = 0;
        public Flappy()
        {
            InitializeComponent();
        }


        private void gameTimer_Event(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeBotton.Left -= pipeSpeed;
            pipeBotton2.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            pipeUp2.Left -= pipeSpeed;
            scoreText.Text = "Score: " + scoreG;
            

            if(pipeUp.Left  < -100)
            {

            pipeUp.Left = 800;
                scoreG++;
                
            }
            if(pipeUp2.Left < -100) {
                pipeUp2.Left = 800;
                scoreG++;
            }
            if(pipeBotton.Left < -80)
            {
                pipeBotton.Left = 780;
                scoreG++;
            }
            if(pipeBotton2.Left < -80)
            {
                pipeBotton2.Left = 780;
                scoreG++;
            }
           if (scoreG > 15)
            {
                pipeSpeed = 10;
            }


            if (bird.Bounds.IntersectsWith(pipeBotton.Bounds) ||
                bird.Bounds.IntersectsWith(pipeUp2.Bounds) ||
                bird.Bounds.IntersectsWith(pipeBotton2.Bounds) ||
                bird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < 2
                )
            {
                endGame();
            }
        }

        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -12;
            }
        }

        private void gameKeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 12;
            }
        }
        private void endGame()
        {
            
            gameTimer.Stop();
            scoreText.Text = "Game Over!!";

        }
    }
}
