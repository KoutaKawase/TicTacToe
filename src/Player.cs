using System;

namespace TicTacToe
{
    //プレイヤー情報を管理するクラス
    public class Player
    {
        public readonly Mark mark;
        private readonly Boolean isNext = false;

        public Player(Mark mark, Boolean isNext)
        {
            this.mark = mark;
            this.isNext = isNext;
        }

        public Input Play()
        {
            var isValidInput = false;
            int row = 0;
            int col = 0;
            do
            {
                Console.Write("縦 >>");
                var rowBuffer = Console.ReadLine();
                Console.Write("横 >>");
                var colBuffer = Console.ReadLine();

                if (int.TryParse(rowBuffer, out row) && int.TryParse(colBuffer, out col))
                {
                    isValidInput = true;
                }

                isValidInput = Input.isValidRange(col, row);
            } while (!isValidInput);

            return new Input(col, row);
        }

        public override string ToString()
        {
            return $"mark: {this.mark} isNext: {this.isNext}";
        }
    }
}
