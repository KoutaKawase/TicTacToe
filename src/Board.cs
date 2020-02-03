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
            var boardState = Enumerable.Repeat(MarkType.None, 9).ToArray();
            IList<MarkType> freezedBoard = Array.AsReadOnly(boardState);
            this.state = freezedBoard;
        }

        public Board(IList<MarkType> state)
        {
            this.state = state;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }

        public Board ChangeState(Input input, Player player)
        {
            var index = input.column * input.row - 1;
            var state = new List<MarkType>(this.state);
            state[index] = player.mark;
            return new Board(state);
        }

        public override string ToString()
        {
            return Converter.ConvertToStringFrom(this.state);
        }
    }
}
