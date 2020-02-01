using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class GameInfo
    {
        public readonly Players players;
        public readonly Boolean isActiveGame = false;

        public GameInfo(Players players, Boolean isActiveGame)
        {
            this.players = players;
            this.isActiveGame = isActiveGame;
        }
    }
}
