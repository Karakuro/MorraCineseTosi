using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorraCineseTosi
{
    internal class Statistics
    {
        public int PlayerWins { get; set; } = 0;
        public int CpuWins { get; set; } = 0;
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
        Player1,
        Player2
    }
}
