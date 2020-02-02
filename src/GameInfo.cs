using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class GameInfo
    {
        public readonly Players players;
        public readonly Boolean isActiveGame = false;
        //現在プレイすべきプレイヤー
        public readonly Player nextPlayer;

        public GameInfo(Players players, Boolean isActiveGame, Player firstPlayer)
        {
            this.players = players;
            this.isActiveGame = isActiveGame;
            this.nextPlayer = firstPlayer;
        }

        public override string ToString()
        {
            return $"NEXT: {nextPlayer}";
        }
    }
}
