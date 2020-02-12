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
            Player winner;

            while (info.isActiveGame)
            {
                board.Display();

                //先行後攻それぞれ打ち続けてもらう
                Player next = info.ObtainNextPlayer();
                Console.WriteLine("現在のターン" + next.mark);
                //TODO: 既に置いてある場合は繰り返す
                var input = next.Play(board.state);
                board = board.ChangeState(input, next);
                info = info.SwitchNext();
                //勝敗判定
                winner = CalcWinner(board.state);

                if (winner != null)
                {
                    board.Display();
                    Console.WriteLine("Winner: " + winner.mark);
                    break;
                }

                if (board.isFilled())
                {
                    board.Display();
                    Console.WriteLine("あいこです！閉廷！");
                    break;
                }
            }
        }

        public Player CalcWinner(IList<MarkType> state)
        {
            int[][] winLines =
            {
                new int[] {0, 1, 2},
                new int[] {3, 4, 5},
                new int[] {6, 7, 8},
                new int[] {0, 3, 6},
                new int[] {1, 4, 7},
                new int[] {2, 5, 8},
                new int[] {0, 4, 8},
                new int[] {2, 4, 6}
            };

            foreach (var line in winLines)
            {
                var a = line[0];
                var b = line[1];
                var c = line[2];

                MarkType mark = state[a];

                if (mark != MarkType.None)
                {
                    if (mark == state[b])
                    {
                        if (mark == state[c])
                        {
                            return new Player(mark);
                        }
                    }
                }
            }

            return null;
        }
    }
}
