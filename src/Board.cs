using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public const int ROW = 3;
        public const int COLUMN = 3;
        public readonly IList<MarkType> board;

        public Board()
        {
            var board = new MarkType[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            IList<MarkType> freezedBoard = Array.AsReadOnly(board);
            this.board = freezedBoard;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }

        private string ConvertToString(IList<MarkType> board)
        {
            return "123";
        }

        public override string ToString()
        {
            return this.ConvertToString(this.board);
        }
    }
}
