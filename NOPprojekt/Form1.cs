using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOPprojekt
{
    public partial class Form1 : Form
    {
        private Player[] Players = { new Player { Name = "Player1", Score = 0 }, new Player { Name = "Player2", Score = 0 } };
        /// <summary>
        /// The random number the players are guessing
        /// </summary>
        private int RandomNumber;
        /// <summary>
        /// Represents which players turn it is
        /// </summary>
        private Player CurrentPlayer;
        /// <summary>
        /// Hint if the guess needs to be more or less
        /// </summary>
        private GuessHint GuessHint = GuessHint.None;
        private string LabelScoreDefaultText;
        private string LabelCurrentTurnDefaultText;
        private Random Random;

        private Image ImageMore;
        private Image ImageLess;
        private Image ImageWrong;

        bool invalidInput = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Random = new Random();
            this.CurrentPlayer = Players[0];
            

            this.LabelScoreDefaultText = labelScore.Text;
            this.LabelCurrentTurnDefaultText = labelCurrentTurn.Text;

            this.labelCurrentTurn.Text = LabelCurrentTurnDefaultText + " " + CurrentPlayer.Name;
            this.RandomNumber = Random.Next(0, 101);


            this.ImageMore = Image.FromFile("Imgs/more.png");
            int newWidth = (int)(ImageMore.Width * 0.2);
            int newHeight = (int)(ImageMore.Height * 0.2);
            this.ImageMore= ImageMore.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);

            this.ImageLess = Image.FromFile("Imgs/less.png");
            newWidth = (int)(ImageLess.Width * 0.2);
            newHeight = (int)(ImageLess.Height * 0.2);
            this.ImageLess = ImageLess.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);

            this.ImageWrong = Image.FromFile("Imgs/wrong.jpg");
            newWidth = (int)(ImageWrong.Width * 0.1);
            newHeight = (int)(ImageWrong.Height * 0.2);
            this.ImageWrong = ImageWrong.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            int guess = -1;
            if (CurrentPlayer.Name == Players[0].Name)
            {
                if (textBoxPlayer1.Text != "" && !textBoxPlayer1.Text.Contains("."))
                {
                    try
                    {
                        guess = int.Parse(textBoxPlayer1.Text);
                    }
                    catch { MessageBox.Show("Invalid Input"); pictureBoxHint.Image = this.ImageWrong; invalidInput = true; return; }
                    if (guess == RandomNumber)
                    {
                        Players [0].Score++;
                        GuessHint = GuessHint.None;
                        RandomNumber = Random.Next(0, 101);
                    }
                    else if (guess > RandomNumber)
                    {
                        GuessHint = GuessHint.Less;
                    }
                    else
                    {
                        GuessHint = GuessHint.More;
                    }
                    CurrentPlayer = Players [1];
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                    pictureBoxHint.Image = this.ImageWrong;
                    invalidInput = true;
                }
                textBoxPlayer2.Text = "";
            }
            else if (CurrentPlayer.Name == Players [1].Name)
            {
                if (textBoxPlayer2.Text != "" && !textBoxPlayer2.Text.Contains("."))
                {
                    try
                    {
                        guess = int.Parse(textBoxPlayer2.Text);
                    }
                    catch { MessageBox.Show("Invalid Input"); pictureBoxHint.Image = this.ImageWrong; invalidInput = true; return; }
                    if (guess == RandomNumber)
                    {
                        Players [1].Score++;
                        GuessHint = GuessHint.None;
                        RandomNumber = Random.Next(0, 101);
                    }
                    else if (guess > RandomNumber)
                    {
                        GuessHint = GuessHint.Less;
                    }
                    else
                    {
                        GuessHint = GuessHint.More;
                    }
                    CurrentPlayer = Players [0];
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                    pictureBoxHint.Image = this.ImageWrong;
                    invalidInput = true;
                }
                textBoxPlayer1.Text = "";
            }
            labelScore.Text = LabelScoreDefaultText + "\n" + Players[0].Name + ": " + Players[0].Score + "\n" + Players[1].Name + ": " + Players[1].Score;

            if (CurrentPlayer.Name == Players[0].Name)
            {
                labelCurrentTurn.Text = LabelCurrentTurnDefaultText + " " + Players[0].Name;
            }
            else
            {
                labelCurrentTurn.Text = LabelCurrentTurnDefaultText + " " + Players[1].Name;
            }
            if (!invalidInput)
            {
                if (GuessHint == GuessHint.More)
                {
                    pictureBoxHint.Image = this.ImageMore;
                }
                else if (GuessHint == GuessHint.Less)
                {
                    pictureBoxHint.Image = this.ImageLess;
                }
            }
            else
            {
                invalidInput = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public struct Player
    {
        public string Name;
        public int Score;
    }
    public enum GuessHint
    {
        None,
        More,
        Less
    }
}
