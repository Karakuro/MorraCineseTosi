using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorraCineseTosi
{
    internal class Statistics
    {
        public int Player1Wins { get; set; } = 0;
        public int Player2Wins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public Turn Turn { get; set; } = Turn.Player1;

        public void NextTurn()
        {
            //if (Turn == Turn.Player1)
            //    Turn = Turn.Player2;
            //else
            //    Turn = Turn.Player1;

            Turn = Turn == Turn.Player1 ? Turn.Player2 : Turn.Player1;
        }
    }
    internal enum Turn
    {
        Player1 = 1,
        Player2
    }
}
