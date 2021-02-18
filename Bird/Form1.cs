using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird
{
    public partial class BirdForm : Form
    {
        bool onlyonce = true;
        int wings = 0;
        int score = 0;
        int sleepTime = 10;
        // pipes objects
        List<UpPipe> upPipes = new List<UpPipe>();
        List<DownPipe> downPipes = new List<DownPipe>();
        // pipes pictureboxes
        List<PictureBox> upPipesBox = new List<PictureBox>();
        List<PictureBox> downPipesBox = new List<PictureBox>();
        public BirdForm()
        {
            InitializeComponent();
            // create first positions of pipes
            upPipes.Add(new UpPipe());
            upPipes.Add(new UpPipe());
            upPipes.Add(new UpPipe());
            for (int i = 0; i < 3; i++)
            {
                upPipes[i].GenerateRandomPoint(i);
                downPipes.Add(new DownPipe(upPipes[i].PositionX, upPipes[i].PositionY));
                upPipesBox.Add(CreateNewPipe(upPipes[i], i + 1, true));
                downPipes[i].GenerateDownPipePoint(upPipes[i].PositionY, i);
                downPipesBox.Add(CreateNewPipe(downPipes[i], i + 1, false));
                Controls.Add(upPipesBox[i]);
                Controls.Add(downPipesBox[i]);
                downPipesBox[i].BringToFront();
                upPipesBox[i].BringToFront();
                pictureBox1.BringToFront();
            }
            scoreLabel.ForeColor = Color.White;
        }

        private void BirdForm_Load(object sender, EventArgs e)
        {

        }
        // Method to create PictureBox
        private PictureBox CreateNewPipe(Pipe pipe, int number, bool up)
        {
            PictureBox temp = new PictureBox();
            temp.Location = pipe.GetStartingPos;
            temp.Size = new Size(100, 300);
            temp.SizeMode = PictureBoxSizeMode.StretchImage;
            if (up)
                temp.Image = Image.FromFile("images\\upPipe.png");
            else
                temp.Image = Image.FromFile("images\\downPipe.png");
            return temp;
        }
        // Timer to move pipes 
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)
            {
                upPipesBox[i].Location = upPipes[i].MovePipe;
                downPipesBox[i].Location = downPipes[i].MovePipe;
                if (upPipes[i].PositionX <= -100)
                {
                    upPipes[i].GenerateRandomPoint(0);
                    downPipes[i].GenerateDownPipePoint(upPipes[i].PositionY, 0);
                }
            }
            wings++;
            Colision();
            Wings();
            CalculateScore();
            SpeedUp();
        }
        // gravity method
        private void Gravity(int y)
        {
            if (y <= pictureBox1.Location.Y - birdBox.Height)
            {
                Point tmp = new Point(birdBox.Location.X, y);
                tmp.Y += 2;
                birdBox.Location = tmp;
            }
        }

        // bird falls down
        private void gravity_Tick_1(object sender, EventArgs e)
        {
            Gravity(birdBox.Location.Y);
        }
        // Hand;e events method
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    Point tmp = new Point(birdBox.Location.X, birdBox.Location.Y);
                    tmp.Y -= 50;
                    birdBox.Location = tmp;
                    break;
            }
        }

        // Colision check method
        private void Colision()
        {
            for (int i = 0; i < 3; ++i)
            {
                if (birdBox.Location.X >= upPipesBox[i].Location.X && birdBox.Location.X <= upPipesBox[i].Location.X + upPipesBox[i].Width
                    && birdBox.Location.Y >= upPipesBox[i].Location.Y && birdBox.Location.Y <= upPipesBox[i].Location.Y + upPipesBox[i].Height)
                    EndGame();
                if (birdBox.Location.X >= downPipesBox[i].Location.X && birdBox.Location.X <= downPipesBox[i].Location.X + downPipesBox[i].Width
                    && birdBox.Location.Y >= downPipesBox[i].Location.Y && birdBox.Location.Y <= downPipesBox[i].Location.Y + downPipesBox[i].Height)
                    EndGame();
            }
        }

        // Method to mvoe wings
        private void Wings()
        {
            if (wings % 2 == 0)
                birdBox.Image = Image.FromFile("images\\bird.png");
            else
                birdBox.Image = Image.FromFile("images\\bird2.png");
        }

        // Method to calculate current score
        private void CalculateScore()
        {
            for (int i=0; i<3; ++i)
            {
                if (birdBox.Location.X == upPipesBox[i].Location.X + 50)
                    score++;
            }
            scoreLabel.Text = $"{score}"; 
        }

        // This shows when u lose
        private void EndGame()
        {
            gameLoop.Stop();
            gravity.Stop();
            MessageBox.Show($"GAME OVER!\nYOUR SCORE: {score}!", "FlappyBird --- Dawid Bańczak");
        }

        // Method to speed up pipes
        private void SpeedUp()
        {
            if (score % 5 == 0 && score > 0)
            {
                if (onlyonce)
                {
                    gameLoop.Interval--;
                    onlyonce = false;
                }
            }
            else
                onlyonce = true;
        }
    }
}
