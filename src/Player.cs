using System;
using System.Collections.Generic;

namespace TicTacToe
{
    //プレイヤー情報を管理するクラス
    public class Player
    {
        public readonly MarkType mark;
        public Boolean isNext = false;

        public Player(MarkType mark, Boolean isNext)
        {
            this.mark = mark;
            this.isNext = isNext;
        }

        public Player(MarkType mark)
        {
            this.mark = mark;
            this.isNext = false;
        }

        public Input Play(IList<MarkType> state)
        {
            var isValidInput = false;
            int row = 0;
            int col = 0;
            //state上の位置
            int index = 0;
            do
            {
                //何か動いてるからとにかくヨシ！
                Console.Write("縦 >>");
                var colBuffer = Console.ReadLine();
                Console.Write("横 >>");
                var rowBuffer = Console.ReadLine();

                if (int.TryParse(rowBuffer, out row) && int.TryParse(colBuffer, out col))
                {
                    try
                    {
                        index = Board.CalcIndex(col, row);
                    }
                    catch
                    {
                        Console.WriteLine("無効な入力です");
                        continue;
                    }

                    isValidInput = true;
                }

                isValidInput = Input.isValidRange(col, row) && !Input.isAlreadyExistsMark(index, state);

            } while (!isValidInput);

            return new Input(col, row);
        }

        public override string ToString()
        {
            return $"mark: {this.mark} isNext: {this.isNext}";
        }
    }
}
