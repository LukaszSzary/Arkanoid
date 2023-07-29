namespace Arkanoid_C_
{
    public partial class Form1 : Form
    {
        bool paddleDirectionLeft = false, paddleDirectionRight = false;

        int paddleSpeed = 10;
        int ballSpeed = 1;
        int ballSpeedVerticalMultiplier = 1;
        int ballSpeedHorizontalMultiplier = 1;
        // vertical true=right,false=left ; horizontal true=down,false=up
        bool ballVerticalDirection = true;
        bool ballHorizontalDirection = true;

        public Form1()
        {
            InitializeComponent();

        }

        private void MainGameLoop(object sender, EventArgs e)
        {
            if (paddleDirectionLeft == true && paddleDirectionRight == false && Paddle.Left >= 1)
            {
                Paddle.Left -= paddleSpeed;
            }
            if (paddleDirectionLeft == false && paddleDirectionRight == true && Paddle.Left <= 575)
            {
                Paddle.Left += paddleSpeed;
            }

            Ball.Left += ballSpeed*ballSpeedHorizontalMultiplier;
            Ball.Top += ballSpeed*ballSpeedVerticalMultiplier;
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
            paddleSpeed = 10;
            ballSpeed = 20;
            ballSpeedVerticalMultiplier = 1;
            ballSpeedHorizontalMultiplier = 1;
            ballVerticalDirection = true;
            ballHorizontalDirection = true;

            timer.Start();


        }

        
    }
}