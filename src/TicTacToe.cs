using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        public void Play()
        {
            //開始
            Console.WriteLine(BuildStartMessage());
            var circle = new Mark(MarkType.Circle);
            var cross = new Mark(MarkType.Cross);
            var playerA = new Player(circle, true);
            var playerB = new Player(cross, false);

            Console.WriteLine(playerA);
            Console.WriteLine(playerB);
            //ボードを表示に先行後攻それぞれ打ち続けてもらう
            //終了処理
        }

        private static string BuildStartMessage()
        {
            var message = "Welcome To TicTacToe!!";
            return message;
        }
    }
}
