namespace Flappy
{
    partial class Flappy
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
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBotton = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeUp2 = new System.Windows.Forms.PictureBox();
            this.pipeBotton2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotton2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreText.Location = new System.Drawing.Point(47, 18);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(110, 29);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // ground
            // 
            this.ground.Image = global::Flappy.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 392);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(800, 61);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBotton
            // 
            this.pipeBotton.Image = global::Flappy.Properties.Resources.pipe;
            this.pipeBotton.Location = new System.Drawing.Point(305, 277);
            this.pipeBotton.Name = "pipeBotton";
            this.pipeBotton.Size = new System.Drawing.Size(71, 139);
            this.pipeBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBotton.TabIndex = 2;
            this.pipeBotton.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::Flappy.Properties.Resources.pipedown;
            this.pipeUp.Location = new System.Drawing.Point(439, -37);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(64, 172);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 1;
            this.pipeUp.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(158, 169);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(39, 34);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Event);
            // 
            // pipeUp2
            // 
            this.pipeUp2.Image = global::Flappy.Properties.Resources.pipedown;
            this.pipeUp2.Location = new System.Drawing.Point(849, -8);
            this.pipeUp2.Name = "pipeUp2";
            this.pipeUp2.Size = new System.Drawing.Size(64, 268);
            this.pipeUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp2.TabIndex = 5;
            this.pipeUp2.TabStop = false;
            // 
            // pipeBotton2
            // 
            this.pipeBotton2.Image = global::Flappy.Properties.Resources.pipe;
            this.pipeBotton2.Location = new System.Drawing.Point(741, 349);
            this.pipeBotton2.Name = "pipeBotton2";
            this.pipeBotton2.Size = new System.Drawing.Size(71, 139);
            this.pipeBotton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBotton2.TabIndex = 6;
            this.pipeBotton2.TabStop = false;
            // 
            // Flappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.pipeUp2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBotton);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeBotton2);
            this.Name = "Flappy";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBotton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox pipeBotton;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox pipeUp2;
        private System.Windows.Forms.PictureBox pipeBotton2;
    }
}

