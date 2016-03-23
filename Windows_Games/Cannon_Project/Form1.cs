using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cannon1
{
    public partial class Form1 : Form
    {
        const int SCREEN_WIDTH = 640;
        const int SCREEN_HEIGHT = 480;

        const int PROJECTILE_SPEED = 12;
        const int BASE_TARGET_SPEED = 8;
        const float COLLISION_DISTANCE = 20.0F;

        const int STARTING_LIVES = 3;
        const int GAME_DIFFICUTLY_CONTROL = 3;
        const int LIVES_TILE_WIDTH = 16;

        int targetVelocityX = 2;
        int targetVelocityY = 5;
        bool isGameRunning = false;
        int lives;
        int level;

        Random random;

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(SCREEN_HEIGHT, SCREEN_HEIGHT);
            random = new Random();

        }
        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            Player.Load("Cannon.png");
            Target.Load("Target.png");
            Projectile.Load("Projectile.png");
            LivesDisplay.Load("Lives.png");
            TitleScreen.Load("Title_Screen.png");
            TitleScreen.Left = 0;
            TitleScreen.Top = 0;
            TitleScreen.Width = SCREEN_WIDTH;
            TitleScreen.Height = SCREEN_HEIGHT;
        }
        private void Player_Click(object sender, EventArgs e)
        {

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Player.Left = e.X - Player.Width / 2;
            Player.Top = SCREEN_HEIGHT - Player.Height;
        }

        private void GameUpdateTimer_Tick(object sender, EventArgs e)
        {
            Projectile.Top -= PROJECTILE_SPEED;
            Target.Top += targetVelocityY;
            Target.Left += targetVelocityX;

            CheckGroundCollision();
            CheckAirCollision();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isGameRunning)
            {
                FireProjectile();
            }
            else
            {
                BeginGame();
            }
        }
        #endregion 
        #region gameplay methods

        private void BeginGame()
        {
            isGameRunning = true;
            lives = STARTING_LIVES;
            level = 1;

            DisplayLives();
            ResetProjectile();
            ResetTarget();

            TitleScreen.Hide();
            Cursor.Hide();
        }
        private void EndGame()
        {
            isGameRunning = false;
            TitleScreen.Show();
            Cursor.Show();
        }
        private void KillPlayer()
        { 
            ResetTarget();

            lives--;
            DisplayLives();
            if (lives == 0)
            {
                EndGame();
            }
        }
        private void KillTarget()
        {
            level++;
            ResetTarget();
            ResetProjectile();
        }
        private void DisplayLives()
        {
            LivesDisplay.Width = lives * LIVES_TILE_WIDTH;
        }
        private void FireProjectile()
        {
            if (Projectile.Bottom < 0)
            {
                Projectile.Left = Player.Left + Player.Width / 2 - Projectile.Width / 2;
                Projectile.Top = Player.Top - Projectile.Height;
            }
        }
        private void ResetProjectile() 
        {
            Projectile.Top = -Projectile.Height;
        }
        private void ResetTarget()
        {
            targetVelocityX = random.Next(2,6);
            targetVelocityY = BASE_TARGET_SPEED + level / GAME_DIFFICUTLY_CONTROL;

            if (random.Next(2) == 0)
            {
                targetVelocityX *= -1;
            }
            Target.Top = -Target.Height;
            Target.Left = SCREEN_WIDTH / 2 - Target.Width / 2;
        }

        #endregion

        #region collision methods
        private void CheckGroundCollision()
        {
            if (Target.Bottom > SCREEN_HEIGHT)
            {
                KillPlayer();
            }
        }
        private void CheckAirCollision()
        {
            Point projectileCenter = GetCenter(Projectile);
            Point targetCenter = GetCenter(Target);

            if (Distance(projectileCenter, targetCenter) < COLLISION_DISTANCE)
            {
                KillTarget();
            }
        }
        #endregion

        #region utility methods
        private Point GetCenter(Control c)
        {
            return new Point(c.Left + c.Width / 2, c.Top + c.Height /2);
        }

        private float Distance(Point pointA, Point pointB)
        {
            int a = pointA.X - pointB.X;
            int b = pointA.Y - pointB.Y;

            float c = (float)Math.Sqrt((a *a) + (b * b));

            return c;
        }
        #endregion

        private void LivesDisplay_Click(object sender, EventArgs e)
        {

        }

    }
}