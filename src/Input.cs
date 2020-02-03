using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Input
    {
        public readonly int column;
        public readonly int row;

        public Input(int column, int row)
        {
            this.column = column;
            this.row = row;
        }

        public static Boolean isValidRange(int column, int row)
        {
            if (!(1 <= column && column <= 3) || !(1 <= row && row <= 3))
            {
                Console.WriteLine("無効な入力です。");
                return false;
            }
            return true;
        }

        public static Boolean isAlreadyExistsMark(int index, IList<MarkType> state)
        {
            if (state[index] != MarkType.None)
            {
                Console.WriteLine("既に置かれています。");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"col: {this.column} row: {this.row}";
        }
    }
}
