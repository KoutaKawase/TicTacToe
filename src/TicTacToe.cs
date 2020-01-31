using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Player playerA;
        private readonly Player playerB;
        private readonly Board board;

        public TicTacToe()
        {
            var circle = new Mark(MarkType.Circle);
            var cross = new Mark(MarkType.Cross);
            this.playerA = new Player(circle, true);
            this.playerB = new Player(cross, false);
            this.board = new Board();
        }
        public void Play()
        {
            //開始
            Console.WriteLine(BuildStartMessage());
            //ボードを表示
            board.Display();
            //先行後攻それぞれ打ち続けてもらう
            //終了処理
        }

        private static string BuildStartMessage()
        {
            var message = "Welcome To TicTacToe!!";
            return message;
        }
    }
}
