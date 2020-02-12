using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class TicTacToe
    {
        private GameInfo info;
        private Board board;
        //試合中かどうか

        public TicTacToe()
        {
            var players = new Players(new List<Player>());
            var circle = new Player(MarkType.Circle, true);
            var cross = new Player(MarkType.Cross, false);
            var addedCirclePlayers = players.Add(circle);
            var addedCrossPlayers = addedCirclePlayers.Add(cross);
            this.info = new GameInfo(addedCrossPlayers, true);
            this.board = new Board();
        }

        public void Play()
        {
            //開始
            Console.WriteLine("Welcome To TicTacToe!!");

            while (info.isActiveGame)
            {
                board.Display();
                //先行後攻それぞれ打ち続けてもらう
                Player next = info.ObtainNextPlayer();
                //TODO: 既に置いてある場合は繰り返す
                var input = next.Play(board.state);
                board = board.ChangeState(input, next);
                info = info.SwitchNext();
            }
            //終了処理
        }
    }
}
