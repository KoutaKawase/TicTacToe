using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly GameInfo info;
        private readonly Board board;
        //試合中かどうか

        public TicTacToe()
        {
            var players = new Players(new List<Player>());
            var circle = new Player(new Mark(MarkType.Circle), true);
            var cross = new Player(new Mark(MarkType.Cross), false);
            var addedCirclePlayers = players.Add(circle);
            var addedCrossPlayers = addedCirclePlayers.Add(cross);
            this.info = new GameInfo(players, true);
            this.board = new Board();
        }

        public void Play()
        {
            //開始
            Console.WriteLine("Welcome To TicTacToe!!");
            Console.WriteLine(info.players);
            //ボードを表示
            board.Display();
            //先行後攻それぞれ打ち続けてもらう

            //終了処理
        }
    }
}
