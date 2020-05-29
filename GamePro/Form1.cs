using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePro
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int gameSpeed=5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovePicBox(gameSpeed);
            EnemyMove(gameSpeed);
            GameOver();
        }

        void MovePicBox(int speed)
        {
            if (pictureBox1.Top >= 400)
            {
                this.pictureBox1.Top = 13;
            }
            else 
            {
                this.pictureBox1.Top += speed; 
            }

            if (pictureBox2.Top >= 400)
            {
                this.pictureBox2.Top = 13;
            }
            else
            {
                this.pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 400)
            {
                this.pictureBox3.Top = 13;
            }
            else
            {
                this.pictureBox3.Top += speed;
            }
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        Random random = new Random();
        int x, y;

        void EnemyMove(int enemySpeed)
        {
            if (enemyObj1.Top >= 400)
            {
                x = random.Next(0,350);
                y = random.Next(0,375);
                enemyObj1.Location = new Point(x,0);

            }
            else
            {
                this.enemyObj1.Top += enemySpeed;
            }


            if (enemyObj2.Top >= 400)
            {
                x = random.Next(0, 350);
                y = random.Next(0, 350);
                enemyObj2.Location = new Point(x,0);
            }
            else
            {
                this.enemyObj2.Top += enemySpeed;
            }

            if (enemyObj3.Top >= 400)
            {
                x = random.Next(0, 350);
                y = random.Next(0, 350);
                enemyObj3.Location = new Point(x,0);
            }
            else
            {
                this.enemyObj3.Top += enemySpeed;
            }

            if (enemyObj4.Top >= 400)
            {
                x = random.Next(0, 350);
                y = random.Next(0, 313);
                enemyObj4.Location = new Point(x, 0);
            }
            else
            {
                this.enemyObj4.Top += enemySpeed;
            }

        }

        void GameOver()
        {
            if (Object.Bounds.IntersectsWith(enemyObj1.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (Object.Bounds.IntersectsWith(enemyObj2.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (Object.Bounds.IntersectsWith(enemyObj3.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (Object.Bounds.IntersectsWith(enemyObj4.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }


        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            { 
                if(Object.Left > 10)
                Object.Left += -8;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
             { 
                if(Object.Right<273)
                Object.Left += +8; 
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (gameSpeed < 20)
                    gameSpeed++;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (gameSpeed > 5)
                    gameSpeed--;
            }

        }

     


    }
}
