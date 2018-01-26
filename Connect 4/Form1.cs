using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Connect_4
{
    public partial class Form1 : Form
    {
        private Rectangle[] boardColumns;
        private int[,] board;
        private int turn;
        int redScore = 0;
        int yellowScore = 0;
        

        System.Windows.Media.MediaPlayer eightBitPlayer;
        
        public Form1()
        {
            InitializeComponent();

            this.boardColumns = new Rectangle[7];

            this.board = new int[6, 7];

            this.turn = 1;

            eightBitPlayer = new System.Windows.Media.MediaPlayer();
            eightBitPlayer.Open(new Uri(Application.StartupPath + "/Resources/08_Ascending.wav"));

            eightBitPlayer.Stop();
            eightBitPlayer.Play();
            
        }

        //private void gameTimerMethod(object sender, EventArgs e, int gameTime, int gSeconds, int gMinutes)
        //{
        //    gameTime++;
        //    gSeconds = gameTime;

        //    if (gSeconds >= 60)
        //    {
        //        gSeconds = 0;
        //        gMinutes++;
        //    }
            

        //    gameTimeLabel.Text = ("Game Time: " + gMinutes.ToString("00") + ":" + gSeconds.ToString("00"));
        //}



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, 24, 24, 700, 600);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0)
                    {
                        this.boardColumns[j] = new Rectangle(48 + 96 * j, 48, 64, 600);
                    }
                    e.Graphics.FillEllipse(Brushes.White, 48 + 96 * j, 64 + 96 * i, 64, 64);
                }
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int columnIndex = this.ColumnNumber(e.Location);
            Console.WriteLine();
            if (columnIndex != -1)
            {
                int rowIndex = this.EmptyRow(columnIndex);
                if (rowIndex != -1)
                {
                    this.lastTurn.Text = "Last Turn: " + (columnIndex + 1);

                    this.board[rowIndex, columnIndex] = this.turn;
                    if (this.turn == 1)
                    {
                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Red, 48 + 96 * columnIndex, 64 + 96 * rowIndex, 64, 64);
                    }
                    else if (this.turn == 2)
                    {
                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Yellow, 48 + 96 * columnIndex, 64 + 96 * rowIndex, 64, 64);
                    }

                    int winner = this.WinnerPlayer(this.turn);
                    if (winner != -1)
                    {
                        string player = (winner == 1) ? "Red" : "Yellow";
                        MessageBox.Show("Congratulations!  " + player + " Player has won!");
                        roundWin();

                        if (winner == 1)
                        {
                            redScore++;
                            redScoreLabel.Text = ("Red Score: " + redScore);
                            roundWin();
                        }
                        else
                        {
                            yellowScore++;
                            yellowScoreLabel.Text = ("Yellow Score: " + yellowScore);
                            roundWin();
                        }
                    }

                    if (this.turn == 1)
                        this.turn = 2;
                    else
                        this.turn = 1;
                }
            }
        }

        private int WinnerPlayer(int playerToCheck)
        {
            //vertical win check (|)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1); col++)
                {
                    if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row + 1, col], this.board[row + 2, col], this.board[row + 3, col]))
                        return playerToCheck;
                }
            }

            //horizontal win check (-)
            for (int row = 0; row < this.board.GetLength(0); row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row, col + 1], this.board[row, col + 2], this.board[row, col + 3]))
                        return playerToCheck;
                }
            }

            //top left diagonal win check (\)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row + 1, col + 1], this.board[row + 2, col + 2], this.board[row + 3, col + 3]))
                        return playerToCheck;
                }
            }

            //top right win check (/)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 3; col < this.board.GetLength(1); col++)
                {
                    if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row + 1, col - 1], this.board[row + 2, col - 2], this.board[row + 3, col - 3]))
                        return playerToCheck;
                }
            }

            return -1;
        }

        private bool AllNumbersEqual(int toCheck, params int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (num != toCheck)
                    return false;
            }
            return true;
        }

        private int ColumnNumber(Point mouse)
        {
            for (int i = 0; i < this.boardColumns.Length; i++)
            {
                if ((mouse.X >= this.boardColumns[i].X) && (mouse.Y >= this.boardColumns[i].Y))
                {
                    if ((mouse.X <= this.boardColumns[i].X + this.boardColumns[i].Width) && (mouse.Y <= this.boardColumns[i].Y + this.boardColumns[i].Height))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private int EmptyRow(int col)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (this.board[i, col] == 0)
                    return i;
            }
            return -1;
        }

        private void restartGame()
        {

            Application.Restart();
        }

        private void restartRound()
        {
            
        }

        private void roundWin() 
        {
            
        }
    }    
}