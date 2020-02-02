using System;

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
        public static Boolean isValid(int column, int row)
        {
            if (!(1 <= column && column <= 3) || !(1 <= row && row <= 3))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"col: {this.column} row: {this.row}";
        }
    }
}
