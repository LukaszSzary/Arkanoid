
namespace Arkanoid_C_
{
    public partial class Form1 : Form
    {
        Random random = new Random();
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

        public Form1()
        {
            InitializeComponent();

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
        }
        private void BounceTopBot()
        {
            int RandomBallSpeedVerticalMultiplier = random.Next(4, 21);

            ballVerticalDirection = !ballVerticalDirection;
            //ballHorizontalDirection = random.Next(2) == 1;

            ballSpeed = 1;// Math.Sqrt((72 - RandomBallSpeedVerticalMultiplier* RandomBallSpeedVerticalMultiplier- RandomBallSpeedVerticalMultiplier- ballSpeedHorizontalMultiplier * ballSpeedHorizontalMultiplier- ballSpeedHorizontalMultiplier)/2);
            ballSpeedVerticalMultiplier = RandomBallSpeedVerticalMultiplier;
            ballSpeedHorizontalMultiplier = 10;
        }
        private void BounceRigLef()
        {
            int RandomBallSpeedVerticalMultiplier = random.Next(4, 21);

            ballHorizontalDirection = !ballHorizontalDirection;

            ballSpeed = 1;// Math.Sqrt((72 - RandomBallSpeedVerticalMultiplier* RandomBallSpeedVerticalMultiplier- RandomBallSpeedVerticalMultiplier- ballSpeedHorizontalMultiplier * ballSpeedHorizontalMultiplier- ballSpeedHorizontalMultiplier)/2);
            ballSpeedVerticalMultiplier = RandomBallSpeedVerticalMultiplier;
            ballSpeedHorizontalMultiplier = 10;
        }
        private void ResetGame()
        {
            //make objects visible
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Visible == false) { }
                control.Visible = true;
            }

            //reset positions

            Ball.Left = 250;
            Ball.Top = 260;

            Paddle.Left = 300;
            Paddle.Top = 439;

            //reset movement

            paddleDirectionLeft = false;
            paddleDirectionRight = false;
            paddleSpeed = 15;
            ballSpeed = 1;
            ballSpeedVerticalMultiplier = 6;
            ballSpeedHorizontalMultiplier = 6;
            ballVerticalDirection = true;
            ballHorizontalDirection = true;

            timer.Start();


        }



    }
}