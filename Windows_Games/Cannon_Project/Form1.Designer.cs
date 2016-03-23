namespace Cannon1
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Target = new System.Windows.Forms.PictureBox();
            this.Projectile = new System.Windows.Forms.PictureBox();
            this.GameUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.TitleScreen = new System.Windows.Forms.PictureBox();
            this.LivesDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivesDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = false;
            this.Player.Location = new System.Drawing.Point(222, 330);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(32, 32);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Target
            // 
            this.Target.Enabled = false;
            this.Target.Location = new System.Drawing.Point(222, 12);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(42, 42);
            this.Target.TabIndex = 1;
            this.Target.TabStop = false;
            // 
            // Projectile
            // 
            this.Projectile.Enabled = false;
            this.Projectile.Location = new System.Drawing.Point(234, 283);
            this.Projectile.Name = "Projectile";
            this.Projectile.Size = new System.Drawing.Size(8, 8);
            this.Projectile.TabIndex = 2;
            this.Projectile.TabStop = false;
            // 
            // GameUpdateTimer
            // 
            this.GameUpdateTimer.Enabled = true;
            this.GameUpdateTimer.Interval = 16;
            this.GameUpdateTimer.Tick += new System.EventHandler(this.GameUpdateTimer_Tick);
            // 
            // TitleScreen
            // 
            this.TitleScreen.Enabled = false;
            this.TitleScreen.Location = new System.Drawing.Point(4, 4);
            this.TitleScreen.Name = "TitleScreen";
            this.TitleScreen.Size = new System.Drawing.Size(100, 50);
            this.TitleScreen.TabIndex = 3;
            this.TitleScreen.TabStop = false;
            // 
            // LivesDisplay
            // 
            this.LivesDisplay.Location = new System.Drawing.Point(4, 4);
            this.LivesDisplay.Name = "LivesDisplay";
            this.LivesDisplay.Size = new System.Drawing.Size(48, 16);
            this.LivesDisplay.TabIndex = 4;
            this.LivesDisplay.TabStop = false;
            this.LivesDisplay.Click += new System.EventHandler(this.LivesDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(522, 374);
            this.Controls.Add(this.LivesDisplay);
            this.Controls.Add(this.TitleScreen);
            this.Controls.Add(this.Projectile);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cannon 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivesDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.PictureBox Projectile;
        private System.Windows.Forms.Timer GameUpdateTimer;
        private System.Windows.Forms.PictureBox TitleScreen;
        private System.Windows.Forms.PictureBox LivesDisplay;
    }
}

