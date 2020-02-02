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
            do
            {

            } while (isValidInput);
            return new Input(1, 1);
        }

        public override string ToString()
        {
            return $"mark: {this.mark} isNext: {this.isNext}";
        }
    }
}
