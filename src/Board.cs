using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        public const int ROW = 3;
        public const int COLUMN = 3;
        public readonly IList<MarkType> state;

        public Board()
        {
            var boardState = new MarkType[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            IList<MarkType> freezedBoard = Array.AsReadOnly(boardState);
            this.state = freezedBoard;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return Converter.ConvertToStringFrom(this.state);
        }
    }
}
