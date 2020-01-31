using System;

namespace TicTacToe
{
    //プレイヤーの保持する◯及びXの情報を管理するクラス
    public class Mark
    {
        public readonly MarkType mark;

        public Mark(MarkType mark)
        {
            this.mark = mark;
        }

        public override string ToString()
        {
            return $"{this.mark.ToString()}";
        }
    }
}
