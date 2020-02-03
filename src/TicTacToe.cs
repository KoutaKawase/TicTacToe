using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly GameInfo info;
        private Board board;
        //試合中かどうか

        public TicTacToe()
        {
            var players = new Players(new List<Player>());
            var circle = new Player(new Mark(MarkType.Circle), true);
            var cross = new Player(new Mark(MarkType.Cross), false);
            var addedCirclePlayers = players.Add(circle);
            var addedCrossPlayers = addedCirclePlayers.Add(cross);
            this.info = new GameInfo(addedCrossPlayers, true, circle);
            this.board = new Board();
        }

        public void Play()
        {
            //開始
            Console.WriteLine("Welcome To TicTacToe!!");
            //ボードを表示
            board.Display();
            //先行後攻それぞれ打ち続けてもらう
            Player next = info.nextPlayer;
            //TODO: 既に置いてある場合は繰り返す
            var input = next.Play(board.state);
            board = board.ChangeState(input);
            board.Display();
            //終了処理
        }
    }
}
