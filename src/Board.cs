using System;
using System.Collections.Generic;

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

        private string ConvertToStringFrom(IList<MarkType> board)
        {
            return "123";
        }

        public override string ToString()
        {
            return this.ConvertToStringFrom(this.state);
        }
    }
}
