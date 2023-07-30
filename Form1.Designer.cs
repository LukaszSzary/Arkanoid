namespace Arkanoid_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Score = new Label();
            Paddle = new PictureBox();
            Ball = new PictureBox();
            GreemBox1 = new PictureBox();
            GreemBox5 = new PictureBox();
            GreemBox3 = new PictureBox();
            GreemBox4 = new PictureBox();
            GreemBox2 = new PictureBox();
            RedBox2 = new PictureBox();
            RedBox4 = new PictureBox();
            RedBox3 = new PictureBox();
            RedBox5 = new PictureBox();
            RedBox1 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            labelEndGame = new Label();
            ((System.ComponentModel.ISupportInitialize)Paddle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedBox1).BeginInit();
            SuspendLayout();
            // 
            // Score
            // 
            Score.Font = new Font("Consolas", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Score.ForeColor = SystemColors.ActiveCaptionText;
            Score.Location = new Point(1, 0);
            Score.Name = "Score";
            Score.Size = new Size(684, 33);
            Score.TabIndex = 0;
            Score.Text = "Score: 0";
            Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Paddle
            // 
            Paddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Paddle.BackColor = Color.DarkRed;
            Paddle.BorderStyle = BorderStyle.FixedSingle;
            Paddle.Location = new Point(300, 439);
            Paddle.Name = "Paddle";
            Paddle.Size = new Size(110, 10);
            Paddle.TabIndex = 1;
            Paddle.TabStop = false;
            // 
            // Ball
            // 
            Ball.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ball.BackColor = SystemColors.ActiveCaption;
            Ball.BorderStyle = BorderStyle.FixedSingle;
            Ball.Location = new Point(251, 270);
            Ball.Name = "Ball";
            Ball.Size = new Size(15, 15);
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            // 
            // GreemBox1
            // 
            GreemBox1.BackColor = Color.Lime;
            GreemBox1.BorderStyle = BorderStyle.FixedSingle;
            GreemBox1.Location = new Point(28, 180);
            GreemBox1.Name = "GreemBox1";
            GreemBox1.Size = new Size(90, 40);
            GreemBox1.TabIndex = 3;
            GreemBox1.TabStop = false;
            // 
            // GreemBox5
            // 
            GreemBox5.BackColor = Color.Lime;
            GreemBox5.BorderStyle = BorderStyle.FixedSingle;
            GreemBox5.Location = new Point(565, 180);
            GreemBox5.Name = "GreemBox5";
            GreemBox5.Size = new Size(90, 40);
            GreemBox5.TabIndex = 4;
            GreemBox5.TabStop = false;
            // 
            // GreemBox3
            // 
            GreemBox3.BackColor = Color.Lime;
            GreemBox3.BorderStyle = BorderStyle.FixedSingle;
            GreemBox3.Location = new Point(295, 180);
            GreemBox3.Name = "GreemBox3";
            GreemBox3.Size = new Size(90, 40);
            GreemBox3.TabIndex = 6;
            GreemBox3.TabStop = false;
            // 
            // GreemBox4
            // 
            GreemBox4.BackColor = Color.Lime;
            GreemBox4.BorderStyle = BorderStyle.FixedSingle;
            GreemBox4.Location = new Point(425, 180);
            GreemBox4.Name = "GreemBox4";
            GreemBox4.Size = new Size(90, 40);
            GreemBox4.TabIndex = 7;
            GreemBox4.TabStop = false;
            // 
            // GreemBox2
            // 
            GreemBox2.BackColor = Color.Lime;
            GreemBox2.BorderStyle = BorderStyle.FixedSingle;
            GreemBox2.Location = new Point(157, 180);
            GreemBox2.Name = "GreemBox2";
            GreemBox2.Size = new Size(90, 40);
            GreemBox2.TabIndex = 8;
            GreemBox2.TabStop = false;
            // 
            // RedBox2
            // 
            RedBox2.BackColor = Color.Red;
            RedBox2.BorderStyle = BorderStyle.FixedSingle;
            RedBox2.Location = new Point(157, 88);
            RedBox2.Name = "RedBox2";
            RedBox2.Size = new Size(90, 40);
            RedBox2.TabIndex = 13;
            RedBox2.TabStop = false;
            // 
            // RedBox4
            // 
            RedBox4.BackColor = Color.Red;
            RedBox4.BorderStyle = BorderStyle.FixedSingle;
            RedBox4.Location = new Point(425, 88);
            RedBox4.Name = "RedBox4";
            RedBox4.Size = new Size(90, 40);
            RedBox4.TabIndex = 12;
            RedBox4.TabStop = false;
            // 
            // RedBox3
            // 
            RedBox3.BackColor = Color.Red;
            RedBox3.BorderStyle = BorderStyle.FixedSingle;
            RedBox3.Location = new Point(295, 88);
            RedBox3.Name = "RedBox3";
            RedBox3.Size = new Size(90, 40);
            RedBox3.TabIndex = 11;
            RedBox3.TabStop = false;
            // 
            // RedBox5
            // 
            RedBox5.BackColor = Color.Red;
            RedBox5.BorderStyle = BorderStyle.FixedSingle;
            RedBox5.Location = new Point(565, 88);
            RedBox5.Name = "RedBox5";
            RedBox5.Size = new Size(90, 40);
            RedBox5.TabIndex = 10;
            RedBox5.TabStop = false;
            // 
            // RedBox1
            // 
            RedBox1.BackColor = Color.Red;
            RedBox1.BorderStyle = BorderStyle.FixedSingle;
            RedBox1.Location = new Point(28, 88);
            RedBox1.Name = "RedBox1";
            RedBox1.Size = new Size(90, 40);
            RedBox1.TabIndex = 9;
            RedBox1.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += MainGameLoop;
            // 
            // labelEndGame
            // 
            labelEndGame.BackColor = SystemColors.ActiveCaption;
            labelEndGame.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndGame.ForeColor = SystemColors.ActiveCaptionText;
            labelEndGame.Location = new Point(113, 75);
            labelEndGame.Name = "labelEndGame";
            labelEndGame.Size = new Size(476, 238);
            labelEndGame.TabIndex = 14;
            labelEndGame.Text = "Game Over";
            labelEndGame.TextAlign = ContentAlignment.MiddleCenter;
            labelEndGame.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(684, 461);
            Controls.Add(labelEndGame);
            Controls.Add(RedBox2);
            Controls.Add(RedBox4);
            Controls.Add(RedBox3);
            Controls.Add(RedBox5);
            Controls.Add(RedBox1);
            Controls.Add(GreemBox2);
            Controls.Add(GreemBox4);
            Controls.Add(GreemBox3);
            Controls.Add(GreemBox5);
            Controls.Add(GreemBox1);
            Controls.Add(Ball);
            Controls.Add(Paddle);
            Controls.Add(Score);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "Arkanoid";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Paddle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreemBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Score;
        private PictureBox Paddle;
        private PictureBox Ball;
        private PictureBox GreemBox1;
        private PictureBox GreemBox5;
        private PictureBox GreemBox3;
        private PictureBox GreemBox4;
        private PictureBox GreemBox2;
        private PictureBox RedBox2;
        private PictureBox RedBox4;
        private PictureBox RedBox3;
        private PictureBox RedBox5;
        private PictureBox RedBox1;
        private System.Windows.Forms.Timer timer;
        private Label labelEndGame;
    }
}