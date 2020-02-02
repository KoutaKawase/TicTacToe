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

        public static Boolean isValidRange(int column, int row)
        {
            if (!(1 <= column && column <= 3) || !(1 <= row && row <= 3))
            {
                Console.WriteLine("無効な数字が含まれています。");
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
