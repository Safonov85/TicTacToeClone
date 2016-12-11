using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Structure structure;
        string winner;

        public Form1()
        {
            InitializeComponent();
            structure = new Structure();
            NewGame();
            structure.pointsPlayer = 0;
            structure.pointsComputer = 0;
            winner = "none";
        }

        void NewGame()
        {
            structure.XorO = new string[9];
            structure.MemoryField = new bool[9];
            labelYou.Text = "YOU: " + structure.pointsPlayer.ToString();
            labelComputer.Text = "COMP: " + structure.pointsComputer.ToString();
            winner = "none";

            TicTacLabel1.Text = "";
            TicTacLabel2.Text = "";
            TicTacLabel3.Text = "";
            TicTacLabel4.Text = "";
            TicTacLabel5.Text = "";
            TicTacLabel6.Text = "";
            TicTacLabel7.Text = "";
            TicTacLabel8.Text = "";
            TicTacLabel9.Text = "";
        }

        // producing a random number and seeing if that field is avaliable and then marking it with "O"
        void ComputerTurn()
        {
            bool returnIfAllFalse = true;

            foreach(bool check in structure.MemoryField)
            {
                if(check == true)
                {
                    returnIfAllFalse = false;
                }
                else
                {
                    returnIfAllFalse = true;
                    break;
                }
            }

            if(returnIfAllFalse == false)
            {
                return;
            }

            Random random = new Random();
            int randomNumber = 0;
            bool checkList = true;

            // check MemoryField[] until it finds false in array
            while (checkList)
            {
                randomNumber = random.Next(0, 9);
                if(structure.MemoryField[randomNumber] == false)
                {
                    checkList = false;
                }
            }


            if(structure.MemoryField[randomNumber] == false)
            {
                structure.MemoryField[randomNumber] = true;

                if(randomNumber + 1 == 1)
                {
                    TicTacLabel1.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 2)
                {
                    TicTacLabel2.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 3)
                {
                    TicTacLabel3.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 4)
                {
                    TicTacLabel4.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 5)
                {
                    TicTacLabel5.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 6)
                {
                    TicTacLabel6.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 7)
                {
                    TicTacLabel7.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 8)
                {
                    TicTacLabel8.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
                if (randomNumber + 1 == 9)
                {
                    TicTacLabel9.Text = "O";
                    structure.XorO[randomNumber] = "O";
                    CheckIfWin();
                    if (winner != "none")
                    {
                        NewGame();
                    }
                }
            }
        }

        void CheckIfWin()
        {
            // if statements to see if player wins
            if(structure.XorO[0] == "X" &&
               structure.XorO[1] == "X" &&
               structure.XorO[2] == "X")
            {
                PlayerWin();
            }
            if (structure.XorO[3] == "X" &&
               structure.XorO[4] == "X" &&
               structure.XorO[5] == "X")
            {
                PlayerWin();
            }
            if (structure.XorO[6] == "X" &&
               structure.XorO[7] == "X" &&
               structure.XorO[8] == "X")
            {
                PlayerWin();
            }
            if (structure.XorO[0] == "X" &&
               structure.XorO[3] == "X" &&
               structure.XorO[6] == "X")
            {
                PlayerWin();
            }
            if (structure.XorO[1] == "X" &&
               structure.XorO[4] == "X" &&
               structure.XorO[7] == "X")
            {
                PlayerWin();
            }
            if (structure.XorO[2] == "X" &&
               structure.XorO[5] == "X" &&
               structure.XorO[8] == "X")
            {
                PlayerWin();
            }
            if (structure.XorO[0] == "X" &&
               structure.XorO[4] == "X" &&
               structure.XorO[8] == "X")
            {
                PlayerWin();
            }
            if (structure.XorO[2] == "X" &&
               structure.XorO[4] == "X" &&
               structure.XorO[6] == "X")
            {
                PlayerWin();
            }

            // if statement to is if computer wins
            if (structure.XorO[0] == "O" &&
               structure.XorO[1] == "O" &&
               structure.XorO[2] == "O")
            {
                ComputerWin();
            }
            if (structure.XorO[3] == "O" &&
               structure.XorO[4] == "O" &&
               structure.XorO[5] == "O")
            {
                ComputerWin();
            }
            if (structure.XorO[6] == "O" &&
               structure.XorO[7] == "O" &&
               structure.XorO[8] == "O")
            {
                ComputerWin();
            }
            if (structure.XorO[0] == "O" &&
               structure.XorO[3] == "O" &&
               structure.XorO[6] == "O")
            {
                ComputerWin();
            }
            if (structure.XorO[1] == "O" &&
               structure.XorO[4] == "O" &&
               structure.XorO[7] == "O")
            {
                ComputerWin();
            }
            if (structure.XorO[2] == "O" &&
               structure.XorO[5] == "O" &&
               structure.XorO[8] == "O")
            {
                ComputerWin();
            }
            if (structure.XorO[0] == "O" &&
               structure.XorO[4] == "O" &&
               structure.XorO[8] == "O")
            {
                ComputerWin();
            }
            if (structure.XorO[2] == "O" &&
               structure.XorO[4] == "O" &&
               structure.XorO[6] == "O")
            {
                ComputerWin();
            }
        }

        void PlayerWin()
        {
            MessageBox.Show(structure.YouWon);
            winner = "player";
            structure.pointsPlayer++;
        }

        void ComputerWin()
        {
            MessageBox.Show(structure.ComputerWon);
            winner = "computer";
            structure.pointsComputer++;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
            structure.pointsPlayer = 0;
            structure.pointsComputer = 0;
        }

        void IsMemoryAllTrue()
        {
            foreach(bool check in structure.MemoryField)
            {
                if(check == false)
                {
                    return;
                }
            }
            NewGame();
        }

        void WinnerOrLooser()
        {
            CheckIfWin();
            if (winner == "none")
            {
                ComputerTurn();
            }
            else
            {
                NewGame();
            }
            IsMemoryAllTrue();
        }

        private void TicTacLabel1_Click(object sender, EventArgs e)
        {
            if(structure.MemoryField[0] == false)
            {
                TicTacLabel1.Text = "X";
                structure.XorO[0] = "X";
                structure.MemoryField[0] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel2_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[1] == false)
            {
                TicTacLabel2.Text = "X";
                structure.XorO[1] = "X";
                structure.MemoryField[1] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel3_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[2] == false)
            {
                TicTacLabel3.Text = "X";
                structure.XorO[2] = "X";
                structure.MemoryField[2] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel4_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[3] == false)
            {
                TicTacLabel4.Text = "X";
                structure.XorO[3] = "X";
                structure.MemoryField[3] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel5_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[4] == false)
            {
                TicTacLabel5.Text = "X";
                structure.XorO[4] = "X";
                structure.MemoryField[4] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel6_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[5] == false)
            {
                TicTacLabel6.Text = "X";
                structure.XorO[5] = "X";
                structure.MemoryField[5] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel7_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[6] == false)
            {
                TicTacLabel7.Text = "X";
                structure.XorO[6] = "X";
                structure.MemoryField[6] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel8_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[7] == false)
            {
                TicTacLabel8.Text = "X";
                structure.XorO[7] = "X";
                structure.MemoryField[7] = true;
                WinnerOrLooser();
            }
        }

        private void TicTacLabel9_Click(object sender, EventArgs e)
        {
            if (structure.MemoryField[8] == false)
            {
                TicTacLabel9.Text = "X";
                structure.XorO[8] = "X";
                structure.MemoryField[8] = true;
                WinnerOrLooser();
            }
        }
    }
}
