
using System.Drawing;

namespace Arkanoid_C_
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        PictureBox[] ArrayOfBoxes = new PictureBox[10];
        bool paddleDirectionLeft = false;
        bool paddleDirectionRight = false;
        bool ballOnField = true;
        int paddleSpeed = 15;
        double ballSpeed = 1;
        double ballSpeedVerticalMultiplier = 6;
        double ballSpeedHorizontalMultiplier = 6;
        // vertical true=right,false=left ; horizontal true=down,false=up
        bool ballVerticalDirection = true;
        bool ballHorizontalDirection = true;
        //Points

        int scorePt = 0;

        public Form1()
        {
            InitializeComponent();
            ArrayOfBoxes[0] = GreemBox1;
            ArrayOfBoxes[1] = GreemBox2;
            ArrayOfBoxes[2] = GreemBox3;
            ArrayOfBoxes[3] = GreemBox4;
            ArrayOfBoxes[4] = GreemBox5;
            ArrayOfBoxes[5] = RedBox1;
            ArrayOfBoxes[6] = RedBox2;
            ArrayOfBoxes[7] = RedBox3;
            ArrayOfBoxes[8] = RedBox4;
            ArrayOfBoxes[9] = RedBox5;

        }

        private void MainGameLoop(object sender, EventArgs e)
        {
            //paddle move
            if (paddleDirectionLeft == true && paddleDirectionRight == false && Paddle.Left >= 1)
            {
                Paddle.Left -= paddleSpeed;
            }
            if (paddleDirectionLeft == false && paddleDirectionRight == true && Paddle.Left <= 575)
            {
                Paddle.Left += paddleSpeed;
            }

            //ball move
            if (ballHorizontalDirection)
            {
                Ball.Left += (int)(ballSpeed * ballSpeedHorizontalMultiplier);
            }
            else
            {
                Ball.Left -= (int)(ballSpeed * ballSpeedHorizontalMultiplier);
            }

            if (ballVerticalDirection)
            {
                Ball.Top += (int)(ballSpeed * ballSpeedVerticalMultiplier);
            }
            else
            {
                Ball.Top -= (int)(ballSpeed * ballSpeedVerticalMultiplier);
            }
            //colisions with paddle and borders
            if (((Ball.Bounds.IntersectsWith(Paddle.Bounds)) || Ball.Bottom <= 16) && ballOnField)
            {
                ballOnField = false;
                BounceTopBot();
            }

            if (((Ball.Left <= 1 || Ball.Left >= 680) && ballOnField) || (Ball.Right <= 15 && Ball.Bottom <= 15) || (Ball.Left >= 680 && Ball.Bottom <= 15))
            {
                ballOnField = false;
                BounceRigLef();
            }

            if (Ball.Left > 1 && Ball.Right < 699 && Ball.Top > 2 && Ball.Bottom < 439)
            {
                ballOnField = true;
            }

            foreach (PictureBox box in ArrayOfBoxes)
            {

                if (box.Bounds.IntersectsWith(Ball.Bounds))
                {
                    BounceTopBot();
                    BounceRigLef();
                    scorePt++;
                    if (box.BackColor == Color.Red)
                    {
                        box.BackColor = Color.Lime;
                    }
                    else if (box.BackColor == Color.Lime)
                    {
                        box.Location = new Point(1000, 180);
                    }
                }
            }
            UpdatePoints();
            if (Ball.Bottom >= 500)
            {
                GameLost();
            }
            if (scorePt == 15)
            {
                GameWon();
            }
        }

        private void GameWon()
        {
            labelEndGame.Text = "You won" + System.Environment.NewLine + System.Environment.NewLine + "Score: 15 " + System.Environment.NewLine + System.Environment.NewLine + " Press Enter to restart the game";
            labelEndGame.Visible = true;
        }

        private void GameLost()
        {
            labelEndGame.Text = "You lost" + System.Environment.NewLine + System.Environment.NewLine + "Score: "+scorePt + System.Environment.NewLine + System.Environment.NewLine + " Press Enter to restart the game";
            labelEndGame.Visible = true;
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddleDirectionLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                paddleDirectionRight = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddleDirectionLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                paddleDirectionRight = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                ResetGame();
            }
        }
        private void BounceTopBot()
        {
            int RandomBallSpeedVerticalMultiplier = random.Next(4, 21);

            ballVerticalDirection = !ballVerticalDirection;


            ballSpeed = 1;
            ballSpeedVerticalMultiplier = RandomBallSpeedVerticalMultiplier;
            ballSpeedHorizontalMultiplier = 10;
        }
        private void BounceRigLef()
        {
            int RandomBallSpeedVerticalMultiplier = random.Next(4, 21);

            ballHorizontalDirection = !ballHorizontalDirection;

            ballSpeed = 1;
            ballSpeedVerticalMultiplier = RandomBallSpeedVerticalMultiplier;
            ballSpeedHorizontalMultiplier = 10;
        }

        private void UpdatePoints()
        {
            Score.Text = "Score: " + scorePt;
        }
        private void ResetGame()
        {

            scorePt = 0;
            //make objects visible and colors
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Visible == false) { }
                control.Visible = true;
            }
            RedBox2.BackColor = Color.Red;
            RedBox4.BackColor = Color.Red;
            RedBox3.BackColor = Color.Red;
            RedBox5.BackColor = Color.Red;
            RedBox1.BackColor = Color.Red;

            labelEndGame.Visible = false;
            //reset positions

            Ball.Left = 250;
            Ball.Top = 260;

            Paddle.Left = 300;
            Paddle.Top = 439;

            GreemBox1.Location = new Point(28, 180);
            GreemBox5.Location = new Point(565, 180);
            GreemBox3.Location = new Point(295, 180);
            GreemBox4.Location = new Point(425, 180);
            GreemBox2.Location = new Point(157, 180);
            RedBox2.Location = new Point(157, 88);
            RedBox4.Location = new Point(425, 88);
            RedBox3.Location = new Point(295, 88);
            RedBox5.Location = new Point(565, 88);
            RedBox1.Location = new Point(28, 88);

            //reset movement

            paddleDirectionLeft = false;
            paddleDirectionRight = false;
            paddleSpeed = 15;
            ballSpeed = 1;
            ballSpeedVerticalMultiplier = 6;
            ballSpeedHorizontalMultiplier = 6;
            ballVerticalDirection = true;
            ballHorizontalDirection = true;

            UpdatePoints();
            timer.Start();


        }



    }
}