using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Structure
    {
        public bool[] MemoryField { get; set; }
        public string[] XorO { get; set; }
        public string YouWon = "You won this round.";
        public string ComputerWon = "Computer won this round.";
        public int pointsPlayer, pointsComputer;
    }
}
